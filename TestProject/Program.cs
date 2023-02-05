
using System.Text;
using System.Text.RegularExpressions;

class Program {

    public static void Main() {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();
        string resultString;

        Regex regex = new Regex(@"^[a-z]*$");

        if (!regex.Match(inputString).Success) {
            Console.WriteLine("Введены некорректные данные!\n" +
                "Программа принимает только буквы латинского алфавита в нижнем регистре (a-z).");
            return;
        }

        if (inputString.Length % 2 == 0) { 
            string leftSubstring = Program.Reverse(inputString.Substring(0, inputString.Length / 2));
            string rightSubstring = Program.Reverse(inputString.Substring(inputString.Length / 2));
            resultString = leftSubstring + rightSubstring;
        } else {
            resultString = Program.Reverse(inputString) + inputString;
        }

        Console.WriteLine($"Результат: {resultString}");

        Dictionary<char, int> symbolCounts = Program.SymbolCounts(resultString);
        Console.WriteLine("Соответствие символа и количества его повторений в результирующей строке:");
        foreach (KeyValuePair<char, int> kv in symbolCounts)
            Console.WriteLine($"{kv.Key} - {kv.Value}");
    }

    private static string Reverse(string inputString) {
        char[] reversedString = inputString.ToCharArray();
        Array.Reverse(reversedString);
        return new string(reversedString);
    }

    private static Dictionary<char, int> SymbolCounts(string inputString) {
        Dictionary<char, int> result = new Dictionary<char, int>();
        
        foreach (char c in inputString) {
            if (result.ContainsKey(c))
                result[c]++;
            else
                result[c] = 1;
        }

        return result;
    }
}