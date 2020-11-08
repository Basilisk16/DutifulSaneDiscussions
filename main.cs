using System;
class MainClass 
{
  // odabir pocetka rotora
  // odabir rotora
  static string[] Abeceda ={ "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
  static string[] RotorBETA = {"L","E","Y","J","V","C","N","I","X","W","P","B","Q","M","D","R","T","A","K","Z","G","F","U","H","O","S"};
  static string[] RotorGAMA = {"F","S","O","K","A","N","U","E","R","H","M","B","T","I","Y","C","W","L","Q","P","Z","X","V","G","J","D"};
  //static string[] Reflektor1 = {"E","N","K","Q","A","U","Y","W","J","I","C","O","P","B","L","M","D","X","Z","V","F","T","H","R","G","S"};
  //static string[] Reflektor2 = {"R","D","O","B","J","N","T","K","V","E","H","M","L","F","C","W","Z","A","X","G","Y","I","P","S","U","Q"};
  public static string[] Unos(string [] Reflektori)
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
    int pozicija = 0;
    for (int i=0; i<Abeceda.Length; i++)
    {
      if (Abeceda[i]==slovo) pozicija=i;
    }
    return pozicija;
  }
  public static void Main (string[] args)
  {       
    l1:
    string[] PrviRotor =  { "E","K","M","F","L","G","D","Q","V","Z","N","T","O","W","Y","H","X","U","S","P","A","I","B","R","C","J"};
    string[] DrugiRotor = { "A","J","D","K","S","I","R","U","X","B","L","H","W","T","M","C","Q","G","Z","N","P","Y","F","V","O","E"}; 
    string[] reflektor_osnova = {"A","B","C","D","E","F","G","H","I","J","K","L","M"};
    string[] reflektor_preslikano = {"N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    string [] reci = new string[2];
    string UnoseElemenataReflektora;
    goto l4;
    l3:
    Console.WriteLine("Pogresan unos probajte ponovo!");
    l4:
    //Unos reci
    Console.Write("Unesite rec: ");
    string x = Console.ReadLine();
    x = x.ToUpper();
    x = x.Replace(" ", String.Empty);
    char[] k = x.ToCharArray();  
    string[] rec = new string [k.Length];
    for(int m=0;m<k.Length;m++)
    {
       string a = k[m].ToString();
        rec[m]=a;
    }
    for (int i = 0; i < rec.Length; i++)
    {
      if ((rec[i] != "A")&&(rec[i] != "B")&&(rec[i] != "C")&&(rec[i] != "D")&&(rec[i] != "E")&&(rec[i] != "F")&&(rec[i] != "G")&&(rec[i] != "H")&&(rec[i] != "I")&&(rec[i] != "J")&&(rec[i] != "K")&&(rec[i] != "L")&&(rec[i] != "M")&&(rec[i] != "N")&&(rec[i] != "O")&&(rec[i] != "P")&&(rec[i] != "Q")&&(rec[i] != "R")&&(rec[i] != "S")&&(rec[i] != "T")&&(rec[i] != "U")&&(rec[i] != "V")&&(rec[i] != "W")&&(rec[i] != "X")&&(rec[i] != "Y")&&(rec[i] != "Z"))
      {
        goto l3;
      }
    }
    goto l2;
    reset:
    Console.WriteLine("Pogresili ste tokom unosa. Molim vas krenite od pocetka! ");
    l2:
    
    Console.WriteLine("Da li zelite da podesite reflektor?  (DA/NE) ");
    string str = Console.ReadLine();
    str = str.ToUpper();
    if (str == "DA")
    {
      for (int i = 0; i<13; i++)
    {
      reflektor_osnova[i] = "";
      reflektor_preslikano[i] = "";
    }
     Console.WriteLine("Unesite elemente preslikavanja u obliku (A B), a se prelikava u b. ");
     for (int z = 0; z<13;z++)
     {
       UnoseElemenataReflektora = Console.ReadLine();
       UnoseElemenataReflektora = UnoseElemenataReflektora.ToUpper();
       reci = UnoseElemenataReflektora.Split(" ");
       for (int t = 0; t<2;t++)
       {
         if ((reci[t] != "A")&&(reci[t] != "B")&&(reci[t] != "C")&&(reci[t] != "D")&&(reci[t] != "E")&&(reci[t] != "F")&&(reci[t] != "G")&&(reci[t] != "H")&&(reci[t] != "I")&&(reci[t] != "J")&&(reci[t] != "K")&&(reci[t] != "L")&&(reci[t] != "M")&&(reci[t] != "N")&&(reci[t] != "O")&&(reci[t] != "P")&&(reci[t] != "Q")&&(reci[t] != "R")&&(reci[t] != "S")&&(reci[t] != "T")&&(reci[t] != "U")&&(reci[t] != "V")&&(reci[t] != "W")&&(reci[t] != "X")&&(reci[t] != "Y")&&(reci[t] != "Z"))
         {
           goto reset;
         }
         if(reci[0]==reci[1])
         {goto reset;}
          for (int i = 0; i<t;i++)
          {
             if ((reci[0] == reflektor_osnova[i]) || (reci[0] == reflektor_preslikano[i]) || (reci[1] == reflektor_osnova[i]) || (reci[1] == reflektor_preslikano[i]))
             {
               goto reset;
             }
          }
       }
       reflektor_osnova[z] = reci[0];
       reflektor_preslikano[z] = reci[1];
     }
    }
    else if (str == "NE"){}
    else {Console.WriteLine("Pogresan unos! Probaj Opet!"); goto l2;}
    Console.WriteLine("Trenutna podesavnja reflektora: ");
      for (int i = 0; i<15;i++)
      {Console.Write("*");}
      Console.WriteLine("");
      for (int j = 0; j < 13;j++)
      {
        Console.Write("*  ");
        Console.Write(reflektor_osnova[j]);
        Console.Write("  -->  ");
        Console.Write(reflektor_preslikano[j]);
        Console.Write("  *");
        Console.WriteLine("");
      }
      for (int i = 0; i<15;i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
      Console.WriteLine("Osnovne pozicije rotora su: ");
      Console.Write("Rotor broj jedan: ");
      for (int i = 0; i<26; i++)
      {
        Console.Write(PrviRotor[i]+" ");
      }
      Console.WriteLine("");
      Console.Write("Rotor broj dva: ");
      for (int i = 0; i<26; i++)
      {
        Console.Write(DrugiRotor[i]+" ");
      }
      Console.WriteLine("");
    
//    string[] Reflektori = Unos(Reflektori);
    /*
    Console.WriteLine("Da li zelite da sifrujete. (DA/NE)");
    string odabir = Console.ReadLine();
    odabir = odabir.ToUpper();

    if(odabir=="DA")
    {
      Console.WriteLine("da li zelite da promenite parametre? (DA/NE)");
      string promenaParametara = Console.ReadLine();
        if (promenaParametara == "DA")
        {
          
        }
    }
    else if (odabir=="NE")
    {
       Console.WriteLine("tokom desifrovanja neophodno je zameniti parametre: ");
        Console.WriteLine("Unesi elemente prvog rotora: ");
      PrviRotor = Unos(PrviRotor);
        Console.WriteLine("Unesi elemente drugog rotora: ");
      DrugiRotor = Unos(DrugiRotor);
        Console.WriteLine("Unesi raspored reflektora: ");
     // Reflektor = Unos(Reflektor);
    }
    */
    Console.WriteLine("Da li zelite da promenite pocetak rotora? (DA/NE)");
    string pocetak = Console.ReadLine();
    pocetak = pocetak.ToUpper();
    if(pocetak=="DA")
    {
      Console.WriteLine("Za koliko mesta zelite da pomerite pocetak prvog rotora?");
      int h = 0;
      while(!int.TryParse(Console.ReadLine(),out h) || h>25)
      {
        Console.WriteLine("Pogresan Unos");
      }
      for(int i = 0; i<h;i++)
        Pomeranje_niza(PrviRotor);
      h = 0;
      Console.WriteLine("A za koliko drugog?");
      while(!int.TryParse(Console.ReadLine(),out h) || h>25)
      {
        Console.WriteLine("Pogresan Unos");
      }
      for(int i = 0; i<h;i++)
        Pomeranje_niza(DrugiRotor);
    }
    string slovo;
    int pozicija, brojac=1;
    for(int i = 0; i<rec.Length; i++)
    {
      Pomeranje_niza(PrviRotor);
      if(brojac==26)
      {
        Pomeranje_niza(DrugiRotor);
        brojac=0;
      }
      brojac++;
      slovo = rec[i];
      pozicija = Isti_element(slovo);
      slovo = PrviRotor[pozicija];
      pozicija = Isti_element(slovo);
      slovo = DrugiRotor[pozicija];
      
      Console.WriteLine(slovo);
    }
    Console.WriteLine("Da li želite da završite sa programom? (DA/NE)");
    string exit = Console.ReadLine();
    exit = exit.ToUpper();   
    if(exit == "NE")
    goto l1; 
    Console.WriteLine("~~~~~ Hvala na koriscenju DrimTimEnigma emulatora! ~~~~~~~~~~~");
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