using System;
class MainClass 
{
  static string[] Abeceda ={ "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
  static string[] RotorBETA = {"L","E","Y","J","V","C","N","I","X","W","P","B","Q","M","D","R","T","A","K","Z","G","F","U","H","O","S"};
  static string[] RotorGAMA = {"F","S","O","K","A","N","U","E","R","H","M","B","T","I","Y","C","W","L","Q","P","Z","X","V","G","J","D"};
  static string[] Reflektor1 = {"E","N","K","Q","A","U","Y","W","J","I","C","O","P","B","L","M","D","X","Z","V","F","T","H","R","G","S"};
  static string[] Reflektor2 = {"R","D","O","B","J","N","T","K","V","E","H","M","L","F","C","W","Z","A","X","G","Y","I","P","S","U","Q"};
  public static string[] Reflektori_unos(string [] Reflektori)
  {
    string[] a= new string[26];
    for(int i=0; i < 26; i++)
    {
      string s = Console.ReadLine();
      string [] niz = s.Split(" ");
      for (int j = 0; j < 26; j++)
        a[j]=niz[j];
    }
    return a;
  }
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
  static int Isti_element(string slovo)
  {
    int pozicija;
    for (int i=0; i<Abeceda.Length; i++)
    {
      if (Abeceda[i]==slovo) pozicija=i;
    }
    return pozicija;
  }
  public static void Main (string[] args)
  {       
    l1:
    Console.Write("Unesite rec: ");
    string rec = Console.ReadLine();
    rec = rec.ToUpper();
    
    string[] PrviRotor =  { "E","K","M","F","L","G","D","Q","V","Z","N","T","O","W","Y","H","X","U","S","P","A","I","B","R","C","J"};
    string[] DrugiRotor = { "A","J","D","K","S","I","R","U","X","B","L","H","W","T","M","C","Q","G","Z","N","P","Y","F","V","O","E"}; 
    string[] Reflektori = Reflektori_unos(Reflektori);
    Console.WriteLine("Odaberi sifrovanje ili dešifrovanje. Pritisnite 0 za šifrovanje ili 1 za dešifrovanje: ");
    while((!int.TryParse(Console.ReadLine(),out int odabir)) || odabir != 1 && odabir != 0)
    { 
      Console.WriteLine("Pogresan unos. Broj mora da bude 1 ili 0.");
    }
    if(odabir==0)
    {
      Console.WriteLine("da li zelite da promenite parametre? (DA/NE)");
      string promenaParametara = Console.ReadLine();
        if (promenaParametara == "DA")
        {
          
        }
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
    }
    string slovo;
    int pozicija, brojac=0;
    for(int i = 0; i<rec.Length; i++)
    {
      brojac++;
      slovo = Convert.ToString(rec[i]);
      pozicija = Isti_element(slovo);
      slovo = PrviRotor[pozicija];
      pozicija = Isti_element(slovo);
      slovo = DrugiRotor[pozicija];
      Pomeranje_niza(PrviRotor);
      if(brojac==26)
      {
        Pomeranje_niza(DrugiRotor);
        brojac=0;
      }
    }
    Console.WriteLine(rec);
    Console.WriteLine("Da li želite da završite sa programom? (DA/NE)");
    string exit = Console.ReadLine();
    if(exit == "NE")
    goto l1; 
  }
}
/*
{
            string[] Rotor1 = {L,E,Y,J,V,C,N,I,X,W,P,B,Q,M,D,R,T,A,K,Z,G,F,U,H,O,S,},

            string[] Rotor2 ={F,S,O,K,A,N,U,E,R,H,M,B,T,I,Y,C,W,L,Q,P,Z,X,V,G,J,D,},


            string[] Rotor2 ={E,N,K,Q,A,U,Y,W,J,I,C,O,P,B,L,M,D,X,Z,V,F,T,H,R,G,S,},
            
            string[] Rotor3 ={R,D,O,B,J,N,T,K,V,E,H,M,L,F,C,W,Z,A,X,G,Y,I,P,S,U,Q,},
};
*/