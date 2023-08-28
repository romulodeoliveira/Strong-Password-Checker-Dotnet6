using System;

namespace StrongPasswordChecker;

class Program
{
    static void Main(string[] args)
    {
        string password = Console.ReadLine();

        bool verify = Checker.StrongPassword(password);

        if (verify)
        {
            System.Console.WriteLine("Senha aprovada. Parabens.");
        }
        else
        {
            System.Console.WriteLine("Senha muito fraca. Tente novamente.");
        }
    }
}