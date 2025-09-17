class Fuck_csharp()
{
  static void Main()
  {
    Console.WriteLine(Metoder.Arbiträr(2, 5));
    Console.WriteLine(Metoder.Arbiträr("Isabella", "Idun", "Lisa", "Jakobson"));
  }
}

class Metoder()
{
  public static int Arbiträr(int nummer1, int nummer2)
  {
    return nummer1 + nummer2;
  }
  public static string Arbiträr(params string[] namn)
  {
    var firstAndLastName = $"{namn[0]} {namn[namn.Length - 1]}";
    return firstAndLastName;
  }
} 
