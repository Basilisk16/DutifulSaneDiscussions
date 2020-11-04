using System;
class MainClass 
{
  public static char[] Promena_rotora()
  {
    char[] a= new char[26];
    for(int i=0; i < 26; i++)
    {
      while(!Char.TryParse(Console.ReadLine(), out a[i]))
      {
        Console.WriteLine("Greska! probaj opet!");
      }
    }
    return a;
  }
  static [] int Pomeranje_niza(int [] niz)
  {
    niz2 = new int [26]; 
    for(int i = 0; i<25;i++)
    {
      niz2[i] = niz[i+1];
    }
    niz2[25] = niz[0];
  public static void Main (string[] args)
  {
    l1:
    char[] PrviRotor = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
    char[] DrugiRotor = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
    Console.WriteLine("Odaberi sifrovanje ili dešifrovanje. Pritisnite 0 za šifrovanje ili 1 za dešifrovanje: ");
    DrugiRotor = Promena_rotora();
    int h = Convert.ToInt32(Console.ReadLine());
    if(h==0)
      Sifrovanje();
    else
      Desifrovanje();
    Console.WriteLine("Da li želite da završite sa programom? (DA/NE)");
    string exit = Console.ReadLine();
    if(exit == "NE")
      goto l1; 
  }
}