using System.Text;

namespace OopHomework.Helpers;

public class RegistrationNumberGenerator
{
    public static string GenerateRegisterNumber()
    {
        string regNumber = new Random().Next(0, 10000000).ToString("0000000");

        return regNumber;

    }

    private static int GetRandomDigit()
    {
        var digit = new Random().Next(0, 9);
        return digit;
    }

    private static char GetRandomChar()
    {
        return ' ';

    }
}