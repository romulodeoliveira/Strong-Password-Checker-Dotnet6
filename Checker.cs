namespace StrongPasswordChecker;

public class Checker
{
    public static bool StrongPassword(string password)
    {
        if (password.Length < 6 || password.Length > 12)
        {
            return false;
        }

        if (!password.Any(c => char.IsDigit(c)))
        {
            return false;
        }

        if (!password.Any(c => char.IsUpper(c)))
        {
            return false;
        }

        if (!password.Any(c => char.IsLower(c)))
        {
            return false;
        }

        if (!password.Any(c => char.IsSymbol(c)))
        {
            return false;
        }

        var repeatedCounter = 0;
        var lastCharacter = '\0';

        foreach (var c in password)
        {
            if (c == repeatedCounter)
            {
                repeatedCounter++;
            }
            else
            {
                repeatedCounter = 0;
            }

            if (repeatedCounter == 2)
            {
                return false;
            }

            lastCharacter = c;
        }

        return true;
    }
}