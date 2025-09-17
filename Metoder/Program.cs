class Fuck_csharp()
{
  static void Main()
  {
    Console.WriteLine(Metoder.Arbiträr(2, 5));
    Console.WriteLine(Metoder.Arbiträr("Isabella", "Idun", "Lisa", "Jakobson"));
    Console.WriteLine(Metoder.Arbiträr(true, false));
  }
}

class Metoder()
{
  public static int Arbiträr(int nummer1, int nummer2) //adderar två nummer
  {
    return nummer1 + nummer2;
  }
  public static string Arbiträr(params string[] namn)
  {
    var firstAndLastName = $"{namn[0]} {namn[namn.Length - 1]}"; //tar första och sista argumentet och sätter dem som för och efternamn
    return firstAndLastName;
  }
  public static bool Arbiträr(bool värde1, bool värde2) //tar två bools och kollar om de båda är true
  {
    return (värde1 && värde2);
  }
} 
