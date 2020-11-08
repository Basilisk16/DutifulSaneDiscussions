using System;
class MainClass 
{
  //nizovi--------------------------------------------------------------------------
  static string[] Abeceda ={ "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
  static string[] RotorBETA = {"L","E","Y","J","V","C","N","I","X","W","P","B","Q","M","D","R","T","A","K","Z","G","F","U","H","O","S"};
  static string[] RotorGAMA = {"F","S","O","K","A","N","U","E","R","H","M","B","T","I","Y","C","W","L","Q","P","Z","X","V","G","J","D"};
  //unos----------------------------------------------------------------------------
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
  //pomeranje rotora-----------------------------------------------------------------
  static string[] Pomeranje_niza(string [] niz)
  {
    string [] RotorAlfa = new string[26];
    RotorAlfa[0]=niz[25];
    for (int i = 25;i>0;i--)
    {
      RotorAlfa[i]=niz[i-1];
    } 
    return RotorAlfa;
  }
  //pronalazenje elemenata ka reflektoru----------------------------------------------
  static int Isti_element(string slovo)
  {
    int pozicija = 0;
    for (int i=0; i<Abeceda.Length; i++)
    {
      if (Abeceda[i]==slovo) pozicija=i;
    }
    return pozicija;
  }
  //pronalazenje elemenata od reflektora ka outputu-------------------------------------
  static int Isti_element_povratak(string slovo, string [] Rotor)
  {
    int pozicija = 0;
    for (int i=0; i<Rotor.Length; i++)
    {
      if (Rotor[i]==slovo) pozicija=i;
    }
    return pozicija;
  }
  //-------------------------------------------------------------------------------------
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
    //Unos reci---------------------------------------------------------------------------
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
    Console.WriteLine("");
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
    //elementi koji se preslikavaju (reflektor)--------------------------------------------------------
     Console.WriteLine("Unesite elemente preslikavanja u obliku (A B) ");
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
    else if (str == "NE"){goto skipper;}
    else {Console.WriteLine("Pogresan unos! Probaj Opet!"); goto l2;}
    skipper:
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
      //zamena rotora------------------------------------------------------------------------------
      Console.WriteLine("Da li zelite da promenite rotore? (upisite DA ako zelite)");
      string promenarotora = Console.ReadLine();
      promenarotora = promenarotora.ToUpper();
      if (promenarotora == "DA")
      {
        nastavi:
        Console.WriteLine("Koji rotor zelite da menjate? (PRVI/DRUGI)");
        string promenarotora2 = Console.ReadLine();
        
        promenarotora2 = promenarotora2.ToUpper();
        if (promenarotora2 == "PRVI")
        {
          Console.WriteLine("Sa kojim rotorom zelite da ga zamenite? (BETA/GAMA) ");
          string promenarotora3 = Console.ReadLine();
          if (promenarotora3 == "BETA")
          {
            for(int i = 0; i<26;i++)
            {
            PrviRotor[i]=RotorBETA[i];
            }
          }
          if (promenarotora3 == "DRUGI")
          {
            for(int i = 0; i<26;i++)
            {
            PrviRotor[i]=RotorGAMA[i];
            }
          }
        }
        else if (promenarotora2 == "DRUGI")
        {
          Console.WriteLine("Sa kojim rotorom zelite da ga zamenite? (BETA/GAMA) ");
          string promenarotora3 = Console.ReadLine();
          if (promenarotora3 == "BETA")
          {
            for(int i = 0; i<26;i++)
            {
            DrugiRotor[i]=RotorBETA[i];
            }
          }
          if (promenarotora3 == "DRUGI")
          {
            for(int i = 0; i<26;i++)
            {
            DrugiRotor[i]=RotorGAMA[i];
            }
          }
        }
        Console.WriteLine("Da li zelite da ponovo promenite neki rotor?");
        promenarotora = Console.ReadLine();
        promenarotora = promenarotora.ToUpper();
        if(promenarotora=="DA")
          goto nastavi;
      }
      Console.WriteLine("Na raspolaganju su rotori GAMA i BETA");
      Console.WriteLine("rotor GAMA je: ");
      for(int i = 0; i<26;i++)
      {
        Console.Write(RotorGAMA[i]+" ");
      }
      Console.WriteLine("rotor BETA je: ");
      for(int i = 0; i<26;i++)
      {
        Console.Write(RotorBETA[i] + " ");
      }
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
    //promena pocetka rotora-------------------------------------------------------------------
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
    //konverzija, sifrovanje/desifrovanje----------------------------------------------
    string slovo;
    int pozicija, brojac=1;
    int element_iz_reflektora;
    bool reflektor=true;
    for(int i = 0; i<rec.Length; i++)
    {
      PrviRotor=Pomeranje_niza(PrviRotor);
      brojac++;
      if(brojac==26)
      {
        DrugiRotor=Pomeranje_niza(DrugiRotor);
        brojac=0;
      }
      slovo = rec[i];
      pozicija = Isti_element(slovo);
      slovo = PrviRotor[pozicija];
      pozicija = Isti_element(slovo);
      slovo = DrugiRotor[pozicija];
      for (int j=0; j<reflektor_osnova.Length; j++)
      {
        if (slovo==reflektor_osnova[j]) 
        {
          pozicija = j;
          slovo = reflektor_preslikano[j];
          reflektor=false;
        }
      }
      if (reflektor)
      {
        for (int znj=0; znj<reflektor_preslikano.Length; znj++)
        {
          if (slovo==reflektor_preslikano[znj]) 
          {
            pozicija = znj;
            slovo = reflektor_osnova[znj];
          }
        }
      }
      reflektor=true;
      pozicija = Isti_element_povratak(slovo, DrugiRotor);
      slovo = Abeceda[pozicija];
      pozicija = Isti_element_povratak(slovo, PrviRotor);
      slovo = Abeceda[pozicija];
      Console.Write(slovo);
    }
    Console.WriteLine("Da li želite da završite sa programom? (DA/NE)");
    string exit = Console.ReadLine();
    exit = exit.ToUpper();   
    if(exit == "NE")
    goto l1; 
    Console.WriteLine("~~~~~~~~ Hvala na koriscenju DrimTimEnigma emulatora! ~~~~~~~~");
  }
}