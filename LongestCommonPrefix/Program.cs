using System.Text;

namespace LongestCommonPrefix;

public class Solution
{
  static void Main(string[] args)
  {
    string[] palavras = ["flow", "flower", "flopado"];
    string result = LongCommonPrefix(palavras);
    Console.WriteLine(result);
  }

  static string LongCommonPrefix(string[] strs)
  {
    if (strs == null || strs.Length == 0)
      return string.Empty;

    // Usa a primeira string como referência
    string prefixo = strs[0];

    // Para cada string no array
    for (int i = 1; i < strs.Length; i++)
    {
      // Enquanto a string atual não começar com o prefixo atual
      while (!strs[i].StartsWith(prefixo))
      {
        // Remove o último caractere do prefixo
        prefixo = prefixo.Substring(0, prefixo.Length - 1);

        // Se o prefixo ficou vazio, não há prefixo comum
        if (string.IsNullOrEmpty(prefixo))
          return string.Empty;
      }
    }

    return prefixo;
  }
}