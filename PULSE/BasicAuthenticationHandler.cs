using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Text;
using PULSE.Services.Interfaces;
using PULSE.Constants;
using PULSE.Model.Requests;
using PULSE.Model;

public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
{
    public IStaffService StaffService { get; set; }
    public ICustomerService CustomerService { get; set; }
    public BasicAuthenticationHandler(
        IStaffService korisniciService, 
        IOptionsMonitor<AuthenticationSchemeOptions> options, 
        ILoggerFactory logger, UrlEncoder encoder,
        ISystemClock clock, 
        ICustomerService customerService)
        : base(options, logger, encoder, clock)
    {
        StaffService = korisniciService;
        CustomerService = customerService;
    }

    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        if (!Request.Headers.ContainsKey("Authorization"))
        {
            return AuthenticateResult.Fail("Missing auth header");
        }

        //var userType = AuthenticationHeaderValue.Parse(Request.Headers["X-User-Type"]).ToString();
        var userType = UserType.STAFF;
        var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);

        var credentialsBytes = Convert.FromBase64String(authHeader.Parameter);

        var credentials = Encoding.UTF8.GetString(credentialsBytes).Split(':');

        var username = credentials[0];
        var password = credentials[1];

        var loginRequest = new LoginRequest() { Username = username, Password = password };

        User user = null;

        if (userType == UserType.STAFF)
        {
            user = StaffService.Login(loginRequest);
        }
        else if (userType == UserType.CUSTOMER)
        {
            user = CustomerService.Login(loginRequest);
        }
        
        if (user == null)
        {
            return AuthenticateResult.Fail("Incorrect username or password");
        }

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, username),
            new Claim(ClaimTypes.Name, user.FirstName),
            new Claim(ClaimTypes.Uri, user.Id.ToString())
        };

        if(userType == UserType.STAFF)
        {
            claims.Add(new Claim(ClaimTypes.Role, (user as Staff).Role.Name));
        }

        var identity = new ClaimsIdentity(claims, Scheme.Name);
        var principal = new ClaimsPrincipal(identity);

        var ticket = new AuthenticationTicket(principal, Scheme.Name);

        return AuthenticateResult.Success(ticket);  
    }
}