using System;
class MainClass 
{
  public static string[] PromenaRedosleda()
  {
    string[] a= new string[26];
    for(int i=0; i < 26; i++)
    {
      string s = Console.ReadLine();
      string [] niz = s.Split(" ");
      for (int j = 0; j < 26; j++)
      {
        a[j]=niz[j];
      }
    }
    return a;
  }
  static int[] Pomeranje_niza(int [] niz)
  {
    niz2 = new int [26]; 
    for(int i = 0; i<25;i++)
    {
      niz2[i] = niz[i+1];
    }
    niz2[25] = niz[0];
  }
  
  public static void Main (string[] args)
  {
    l1:
    string[] Tastatura = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    string[] PrviRotor = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    string[] DrugiRotor = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    string[] Reflektori = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    
    Console.WriteLine("Odaberi sifrovanje ili dešifrovanje. Pritisnite 0 za šifrovanje ili 1 za dešifrovanje: ");
    int odabir = Convert.ToInt32(Console.ReadLine());
    if(odabir==0)
      Console.WriteLine("da li zelite da promenite parametre? (DA/NE)");
      string promenaParametara = Console.ReadLine();
        if (promenaParametara == "DA")
        {
          PrviRotor = PromenaRedosleda();
          DrugiRotor = PromenaRedosleda();
        }
      Sifrovanje();
    else
    {
      PrviRotor = PromenaRedosleda();
      DrugiRotor = PromenaRedosleda();
      Reflektori = PromenaRedosleda();

      Desifrovanje();

    }
    Console.WriteLine("Da li želite da završite sa programom? (DA/NE)");
    string exit = Console.ReadLine();
    if(exit == "NE")
      goto l1; 
  }
}