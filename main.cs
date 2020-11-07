using System;
class MainClass 
{
  
  static string[] Pomeranje_niza(string [] niz)
  {
    niz = new string [26];
    string j = " ";
    string k = niz[0];
    for(int i = 1; i<niz.Length;i++)
    {
      if(i!=niz.Length-1)
      {
        j = niz[i];
        niz[i]=k;
        k = j;
      }
      else
      {
        niz[0]=niz[25];
        niz[25]=j;
      }
    }
    return niz;
  }
  
  public static void Main (string[] args)
  {
    l1:
    string[] Tastatura = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    string[] PrviRotor = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    string[] DrugiRotor = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    string[] Reflektori = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    Console.WriteLine("Odaberi sifrovanje ili dešifrovanje. Pritisnite 0 za šifrovanje ili 1 za dešifrovanje: ");;
    while((!int.TryParse(Console.ReadLine(),out int odabir)) ||odabir != 1 || odabir != 0)
    { 
      Console.WriteLine("Pogresan unos. Broj mora da bude 1 ili 0.");
    }
    if(odabir==0)
    {
      Console.WriteLine("da li zelite da promenite parametre? (DA/NE)");
      string promenaParametara = Console.ReadLine();
        if (promenaParametara == "DA")
        {
       PrviRotor = PromenaRedosleda();
          DrugiRotor = PromenaRedosleda();
        }
      // Sifrovanje();
    }
    else
    {
      Console.WriteLine("tokom desifrovanja neophodno je zameniti parametre: ");
      Console.WriteLine("Unesi elemente prvog rotora: ");
      PrviRotor = PromenaRedosleda();
      Console.WriteLine("Unesi elemente drugog rotora: ");
      DrugiRotor = PromenaRedosleda();
    Console.WriteLine("Unesi raspored reflektora: ");
      Reflektori = PromenaRedosleda();

    //  Desifrovanje();

    }
    Console.WriteLine("Da li želite da završite sa programom? (DA/NE)");
    string exit = Console.ReadLine();
    if(exit == "NE")
      goto l1; 
  }
}