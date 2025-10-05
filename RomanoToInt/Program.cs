namespace RomanoToInt;

public class Program
{
  static void Main(string[] args)
  {
    var result = RomanoToInt("IV");
    Console.WriteLine(result);
  }

  static int RomanoToInt(string value)
  {
    var dict = new Dictionary<char, int>()
    {
      {'I', 1},
      {'V', 5},
      {'X', 10},
      {'L', 50},
      {'C', 100},
      {'D', 500},
      {'M', 1000}
    };

    int valorFinal = 0;

    for (int i = 0; i < value.Length; i++)
    {
      int currentValue = dict[value[i]];

      if (i + 1 < value.Length && currentValue < dict[value[i + 1]])
        valorFinal -= dict[value[i]];
      else
        valorFinal += dict[value[i]];
    }
    return valorFinal;
  }
}