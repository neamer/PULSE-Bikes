namespace PULSE.Services.Utils;

public class ServicingUtils
{
    
    public static string GenerateServicingNumber()
    {
        Random random = new Random();

        int randomNumber = random.Next(1000000, 10000000);

        return $"SERV{randomNumber}";
    }
}