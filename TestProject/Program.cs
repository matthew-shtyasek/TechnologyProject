
using System.Text;

class Program {

    public static void Main() {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();
        string resultString;

        if (inputString.Length % 2 == 0) { 
            string leftSubstring = Program.Reverse(inputString.Substring(0, inputString.Length / 2));
            string rightSubstring = Program.Reverse(inputString.Substring(inputString.Length / 2));
            resultString = leftSubstring + rightSubstring;
        } else {
            resultString = Program.Reverse(inputString) + inputString;
        }

        Console.WriteLine($"Результат: {resultString}");
    }

    private static string Reverse(string inputString) {
        char[] reversedString = inputString.ToCharArray();
        Array.Reverse(reversedString);
        return new string(reversedString);
    }
}