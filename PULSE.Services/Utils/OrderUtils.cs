namespace PULSE.Services.Utils;

public class OrderUtils
{
    public static string GenerateOrderNumber()
    {
        Random random = new Random();

        int randomNumber = random.Next(1000000, 10000000);

        return $"ORD{randomNumber}";
    }
}