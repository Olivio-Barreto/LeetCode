using System.Text;

namespace LeetCode.Palindromo;

public class Program
{
  static void Main(string[] args)
  {
    var result = IsPalindromo(101);
    Console.WriteLine(result);
  }

  static bool IsPalindromo(int x)
  {
    string value = x.ToString();
    StringBuilder palindromo = new();
    for (int i = value.Length - 1; i >= 0; i--)
    {
      palindromo.Append(value[i].ToString());
    }
    return palindromo.Equals(value);
  }
}