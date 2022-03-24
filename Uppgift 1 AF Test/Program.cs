using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Uppgift_1_AF_Test
{

    public class Spelkarraktär
    {
        public string namn;
        public int hälsa;
        public int styrka;
        public int tur;        
    }

    class Program
    {
        private static int hämtaAnvändarVal(int menyVal)
        {

            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {

            //bool värdeValidering = false;
                       
            int menyVal = 1;
            int färgVal = 0;
            string filPlats = @"C:\Users\elias\OneDrive\Skrivbord\AF - Studier\textFil.txt";
            List<string> rader = new List<string>();

                       
            while (menyVal != 0)

            {

                Console.WriteLine("\n");

                if (menyVal == 1)
                {
                    Console.WriteLine("Var god mata in ett värde mellan 0-17 för att starta en av de följande uppgifterna");
                    Console.WriteLine("____________________________________________________________________________ \n");
                    Console.WriteLine(" 1. Huvudmeny\n 2. Hello world\n 3. Användar uppgifter\n 4. Byte av textfärg\n 5. Dagens datum \n 6. Hitta största värdet\n 7. Gissa värdet");
                    Console.WriteLine(" 8. Spara till fil\n 9. Läs från fil\n10. Routen ur \n11. Multiplikationstabell\n12. array stortering\n13. palindrom koll\n14. Kolla siffrorna mellan värde A & B");
                    Console.WriteLine("15. Udda eller jämnt?\n16. Addition av heltal\n17. Spelkarraktärer \n 0. Avsluta programmet");
                    Console.WriteLine("____________________________________________________________________________ \n");

                    bool valid = false;
                    int HMval = 0;
                    while (valid == false)
                    {
                        string huvudMenyVal = Console.ReadLine();

                        if (int.TryParse(huvudMenyVal, out HMval))
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("Oj du verkar inte ha matat in rätt värde, försökt igen och använd dig av heltal!");
                        }

                    }

                    menyVal = Convert.ToInt32(HMval);                                    

                }

                else if (menyVal == 2)
                {
                    Console.WriteLine("Meny val [2], Hello world");
                    Console.WriteLine("Hello World! \n");                    
                    menyVal = 1;
                    
                }

                else if (menyVal == 3)
                {
                    string förNamn = String.Empty;
                    string efterNamn = String.Empty;
                    string ålder = string.Empty;
                    int ålderInt = 0;                    
                    bool valid = false;

                    Console.WriteLine("Meny val [3], Använda uppgifter\n");
                    Console.WriteLine("Var god mata in ditt förnamn");
                    förNamn = Console.ReadLine();
                    Console.WriteLine("Var god mata in ditt efternamn");
                    efterNamn = Console.ReadLine();
                    Console.WriteLine("Var god mata in din ålder, OBS! ålder måste vara större än 0!");

                    while (valid == false)
                    {                        
                        ålder = Console.ReadLine();
                        if(int.TryParse(ålder,out ålderInt))
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("Oj du verkar inte ha matat in rätt värde, försökt igen och använd dig av heltal!");
                        }

                    }

                    Console.WriteLine("Välkomen "+förNamn+ " " + efterNamn+ " .Du matade in att du är "+ålderInt+" år gammal");

                    bool loop = true;
                    string isValid = string.Empty;

                    while (loop == true)
                    {
                        Console.WriteLine("Tryck [1] för att återgå till huvudmeny eller\nTryck [2] för att börja om på nytt");
                        string YorN = Console.ReadLine();

                        if (YorN == "1")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN == "2")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN != "1" && YorN != "2")
                        {
                            Console.WriteLine("Något blev fel, Var god mata in Y eller N");

                        }
                    }

                    if (isValid == "1")
                    {
                        menyVal = 1;
                    }
                    if (isValid == "2")
                    {
                        menyVal = 3;
                    }



                }

                else if (menyVal == 4) 
                {
                    Console.WriteLine("Meny val [4], byte av textfärg");
                    
                    färgVal ++;                                        
                    
                    if (färgVal % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                    }

                    menyVal = 1;
               
                }

                else if (menyVal == 5)
                {
                    Console.WriteLine("Meny val [5], Dagens datum");
                    DateTime dagensDatum = DateTime.Today; // vi sätter dagensDatum till "dagens datum"
                    Console.WriteLine("Dagens datum är: " + dagensDatum.ToString("d") + "\n"); // Hämtar dagens datum som vi tilldelar ovanför
                    menyVal = 1;
                   
                }

                else if (menyVal == 6)
                {
                    double värdeA = 0;
                    double värdeB = 0;

                    Console.WriteLine("Meny val [6], hitta största värdet!");

                    bool valid = false;
                    while (valid == false)
                    {
                        Console.WriteLine("Var god mata in ett värde för värde [A] bestående av ett heltal");
                        string förstVärdet = Console.ReadLine();

                        if (double.TryParse(förstVärdet, out värdeA))
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("Oj du verkar inte ha matat in rätt värde, försökt igen!");
                        }                                               

                    }

                    bool valid2 = false;
                    while (valid2 == false)
                    {
                        Console.WriteLine("Var god mata in ett värde för värde [B] bestående av ett heltal");
                        string andraVärdet = Console.ReadLine();

                        if (double.TryParse(andraVärdet, out värdeB))
                        {
                            valid2 = true;
                        }
                        else
                        {
                            Console.WriteLine("Oj du verkar inte ha matat in rätt värde, försökt igen!");
                        }
                    }


                    if (värdeA > värdeB)
                    {
                        Console.WriteLine("Värde A = ["+värdeA+"] är större än värde B = ["+värdeB+"]");
                    }

                    if (värdeA < värdeB)
                    {
                        Console.WriteLine("Värde B = [" + värdeB + "] är större än värde A = [" + värdeA + "]");
                    }

                    if (värdeA == värdeB)
                    {
                        Console.WriteLine("Du har matat in samma värde för värde A & B");
                    }

                    bool loop = true;
                    string isValid = string.Empty;

                    while (loop == true)
                    {
                        Console.WriteLine("Tryck [1] för att återgå till huvudmeny eller\nTryck [2] för att börja om på nytt");
                        string YorN = Console.ReadLine();

                        if (YorN == "1")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN == "2")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN != "1" && YorN != "2")
                        {
                            Console.WriteLine("Något blev fel, Var god mata in Y eller N");

                        }
                    }

                    if (isValid == "1")
                    {
                        menyVal = 1;
                    }
                    if (isValid == "2")
                    {
                        menyVal = 6;
                    }

                }

                else if (menyVal == 7)
                {

                    int användarGissning = 0;
                    int antalGissningar = 0;
                    int randomNummer;
                    int min = 1;
                    int max = 100;
                    bool spelaIgen = true; 
                    Random random = new Random();
                    randomNummer = random.Next(min, max);

                        Console.WriteLine("Meny val [7], gissa värdet");
                        Console.WriteLine("Var god & mata in ett nummer mellan 1 - 100!");

                        while (spelaIgen == true)
                        {

                        bool inpugIsValid = false;
                        while (inpugIsValid == false)
                        {                            
                            string AGtext = Console.ReadLine();

                            if (int.TryParse(AGtext, out användarGissning))
                            {
                                antalGissningar++;
                                inpugIsValid = true;
                            }
                            else
                            {
                                Console.WriteLine("Oj du verkar inte ha matat in rätt värde, försökt igen!");
                            }
                        }

                            if (användarGissning > randomNummer)
                            {
                            //antalGissningar++;
                            Console.WriteLine("Antal gissningar = ["+antalGissningar+ "]. Din gissning ["+ användarGissning +"] är större än siffran vi letar efter, gissa igen!");
                                

                            }

                            else if (användarGissning < randomNummer)
                            {
                            //antalGissningar++;
                            Console.WriteLine("Antal gissningar = [" + antalGissningar + "]. Din gissning [" + användarGissning + "] är mindre än siffran vi letar efter, gissa igen!");
                                


                            }

                            else if (användarGissning == randomNummer)
                            {
                            Console.WriteLine("Antal gissningar = ["+antalGissningar+ "]. Du gissade rätt! siffran som vi letade efter var[" + användarGissning + "]");
                            spelaIgen = false;                            
                            }

                            
                        }

                    bool loop = true;
                    string isValid = string.Empty;

                    while (loop == true)
                    {
                        Console.WriteLine("Tryck [1] för att återgå till huvudmeny eller\nTryck [2] för att börja om på nytt");
                        string YorN = Console.ReadLine();

                        if (YorN == "1")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN == "2")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN != "1" && YorN != "2")
                        {
                            Console.WriteLine("Något blev fel, Var god mata in Y eller N");

                        }
                    }

                    if (isValid == "1")
                    {
                        menyVal = 1;
                    }
                    if (isValid == "2")
                    {
                        menyVal = 7;
                    }

                }

                else if (menyVal == 8)
                {
                    
                    Console.WriteLine("Meny val [8], spara till fil\nHärifrån kan du fylla på txt fillen genom att skriva något.");
                    bool fortsätt = true;

                    if (fortsätt == true)
                    {
                        rader.Add(Console.ReadLine());
                        File.WriteAllLines(filPlats, rader);
                        
                        bool loop = true;
                        string isValid = string.Empty;

                        while (loop == true)
                        {
                            Console.WriteLine("Tryck [1] för att återgå till huvudmeny\nTryck [2] för att fylla i mer text\nTryck [3] för att läsa textfilenr");
                            string YorN = Console.ReadLine();

                            if (YorN == "1")
                            {
                                isValid = YorN;
                                loop = false;
                            }
                            if (YorN == "2")
                            {
                                isValid = YorN;
                                loop = false;
                            }
                            if (YorN == "3")
                            {
                                isValid = YorN;
                                loop = false;
                            }
                            if (YorN != "1" && YorN != "2" && YorN != "3")
                            {
                                Console.WriteLine("Något blev fel, Var god mata in Y eller N");

                            }
                        }

                        if (isValid == "1")
                        {
                            menyVal = 1;
                        }
                        if (isValid == "2")
                        {
                            menyVal = 8;
                        }
                        if (isValid == "3")
                        {
                            menyVal = 9;
                        }

                    }
                                       

                }

                else if (menyVal == 9)
                {
                  
                    Console.WriteLine("Meny val [9], läs från fil");
                    
                    rader = File.ReadAllLines(filPlats).ToList();

                    foreach (string rad in rader )
                    {
                        Console.WriteLine(rad);
                    }


                    bool loop = true;
                    string isValid = string.Empty;
                    
                    while (loop == true)
                    {
                        Console.WriteLine("Tryck [1] för att återgå till huvudmeny eller\nTryck [2] för att lägga till text i textfilen");
                        string YorN = Console.ReadLine();

                        if (YorN == "1")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN == "2")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN != "1" && YorN != "2")
                        {
                            Console.WriteLine("Något blev fel, Var god mata in Y eller N");

                        }                        
                    }

                    if (isValid == "1")
                    {
                        menyVal = 1;
                    }
                    if (isValid == "2")
                    {
                        menyVal = 8;
                    }

                }

                else if (menyVal == 10)
                {
                    
                    double användarVärde = 00.00;
                    double rotenUr = 0; 
                    double resultatTvå = 0;
                    double resultatTio = 0;
                    
                    

                    Console.WriteLine("Meny val [10], roten ur\nVar god mata in ett värde");
                    bool valid = false;
                    while(valid == false)
                    {
                        
                        string inmatatVärde = Console.ReadLine();

                        if (double.TryParse(inmatatVärde, out användarVärde))
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("Oj du verkar inte ha matat in rätt värde, försökt igen!");
                        }
                    }
                    
                    rotenUr = Math.Sqrt(användarVärde);
                    resultatTvå = (rotenUr * 2);
                    resultatTio = (resultatTvå * 10);
                    
                    Console.WriteLine("Du matade in följande värde = [" + användarVärde + "]\n. Roten ur detta värde * 2 * 10 är = [" + resultatTio +"]");

                    bool loop = true;
                    string isValid = string.Empty;

                    while (loop == true)
                    {
                        Console.WriteLine("Tryck [1] för att återgå till huvudmeny eller\nTryck [2] för att börja om");
                        string YorN = Console.ReadLine();

                        if (YorN == "1")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN == "2")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN != "1" && YorN != "2")
                        {
                            Console.WriteLine("Något blev fel, Var god mata in [1] eller [2]");

                        }
                    }

                    if (isValid == "1")
                    {
                        menyVal = 1;
                    }
                    if (isValid == "2")
                    {
                        menyVal = 10;
                    }

                }

                else if (menyVal == 11)
                {
                    int användarNummer = 0;
                    int multiplicerare;
                    Console.WriteLine("Meny val [11], Multiplikationstabell\nVar god mata in ett värde för multiplicering");

                    bool valid = false;
                    while (valid == false)
                    {

                        string inmatatVärde = Console.ReadLine();

                        if (int.TryParse(inmatatVärde, out användarNummer))
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("Oj du verkar inte ha matat in rätt värde, försökt igen!");
                        }
                    }

                    

                    for (multiplicerare = 1; multiplicerare <= 10; multiplicerare++)
                    {
                        
                        //Console.WriteLine("{0}\t*\t{1}\t=\t{2}", användarNummer, multiplicerare, (användarNummer * multiplicerare));
                        Console.WriteLine("{0} * {1} = {2}", användarNummer, multiplicerare, (användarNummer * multiplicerare));

                    }

                    bool loop = true;
                    string isValid = string.Empty;

                    while (loop == true)
                    {
                        Console.WriteLine("Tryck [1] för att återgå till huvudmeny eller\nTryck [2] för att börja om");
                        string YorN = Console.ReadLine();

                        if (YorN == "1")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN == "2")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN != "1" && YorN != "2")
                        {
                            Console.WriteLine("Något blev fel, Var god mata in [1] eller [2]");

                        }
                    }

                    if (isValid == "1")
                    {
                        menyVal = 1;
                    }
                    if (isValid == "2")
                    {
                        menyVal = 11;
                    }

                    

                }

                else if (menyVal == 12)
                {
                    // Skapa 2 arrayer (användaren eller systemet?), första fylls med x antal slumpmässiga tal, den anndra fylls med talen från den första i stigande ordning.
                    // får ej använda array.sort!!!!!!

                    
                    Console.WriteLine("Menyval [12], array stortering");
                    Console.WriteLine("Välj hur många värden du vill att arrayen skall bestå av, OBS får bara bestå av heltal");
                    
                    int storlek = 0;
                    bool valid = false;
                    while (valid == false)
                    {
                        string antalVärden = Console.ReadLine();
                        if (int.TryParse(antalVärden, out storlek))
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("Oj du verkar inte ha matat in rätt värde, försökt igen och använd dig av heltal!");
                        }

                    }

                    int[] arrayInput = new int[storlek];
                    int placeHolder = 0;
                    int j;
                    Console.WriteLine("Var god lägg till [" + storlek + "] heltal");
                        
                        for (int i = 0; i < storlek; i++)
                        {
                        try 
                            {
                            arrayInput[i] = Convert.ToInt32(Console.ReadLine());
                            }

                        catch(Exception)
                            {
                            Console.WriteLine("Oj något gick fel med din inmatning, försökt igen och använd dig av heltal!");
                            i--;
                            }

                        }         

                    for (int i = 0; i <= arrayInput.Length - 1; i++)
                    {
                        for(j = i + 1; j < arrayInput.Length; j++)
                        {
                            if (arrayInput[i] > arrayInput[j])
                            {
                                
                                placeHolder = arrayInput[i];
                                arrayInput[i] = arrayInput[j];
                                arrayInput[j] = placeHolder;

                            }
                        }
                    }

                    Console.WriteLine("Array sorterad i stigande order");
                    foreach(var item in arrayInput)
                    {
                        Console.WriteLine(item);
                    }

                    bool loop = true;
                    string isValid = string.Empty;

                    while (loop == true)
                    {
                        Console.WriteLine("Tryck [1] för att återgå till huvudmeny eller\nTryck [2] för att börja om");
                        string YorN = Console.ReadLine();

                        if (YorN == "1")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN == "2")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN != "1" && YorN != "2")
                        {
                            Console.WriteLine("Något blev fel, Var god mata in [1] eller [2]");

                        }
                    }

                    if (isValid == "1")
                    {
                        menyVal = 1;
                    }
                    if (isValid == "2")
                    {
                        menyVal = 12;
                    }

                }

                else if (menyVal == 13)
                {
                    string ord = string.Empty;
                    Console.WriteLine("Menyval [13], palindrom koll");
                    Console.WriteLine("Var god skriv in ett ord");
                    try {  ord = Console.ReadLine(); }
                    catch 
                    {
                        Console.WriteLine("Oj något gick fel med din inmatning, försökt igen och använd dig av heltal!");
                    }
                    {
                        Console.WriteLine("");
                    }
                    string rev = string.Empty;
                    int längd = ord.Length - 1;

                    while (längd >= 0)
                    {
                        rev = rev + ord[längd];
                        längd--;
                    }
                    if (ord == rev)
                    {
                        Console.WriteLine("["+ ord+"] är ett palindrom");
                    }

                    else
                    {
                        Console.WriteLine("[" + ord + "] är inte ett palindrom");
                        
                    }

                    bool loop = true;
                    string isValid = string.Empty;

                    while (loop == true)
                    {
                        Console.WriteLine("Tryck [1] för att återgå till huvudmeny eller\nTryck [2] för att börja om");
                        string YorN = Console.ReadLine();

                        if (YorN == "1")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN == "2")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN != "1" && YorN != "2")
                        {
                            Console.WriteLine("Något blev fel, Var god mata in [1] eller [2]");

                        }
                    }

                    if (isValid == "1")
                    {
                        menyVal = 1;
                    }
                    if (isValid == "2")
                    {
                        menyVal = 13;
                    }

                }

                else if (menyVal == 14)
                {
                    int värde1 = 0;
                    int värde2 = 0;
                    
                    
                    Console.WriteLine("Menyval [14], Kolla siffrorna mellan värde A & B");
                    Console.WriteLine("Var god fyll i ett heltal");                    
                    bool valid = false;
                    while (valid == false)
                    {
                        string värdeA = Console.ReadLine();
                        if (int.TryParse(värdeA, out värde1))
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("Oj du verkar inte ha matat in rätt värde, försökt igen och använd dig av heltal!");
                        }

                    }                   
                    Console.WriteLine("Var god fyll i yterligare ett heltal");

                    bool valid1 = false;
                    while (valid1 == false)
                    {
                        string värdeB = Console.ReadLine();
                        if (int.TryParse(värdeB, out värde2))
                        {
                            valid1 = true;
                        }
                        else
                        {
                            Console.WriteLine("Oj du verkar inte ha matat in rätt värde, försökt igen och använd dig av heltal!");
                        }

                    }

                    Console.WriteLine("Du har angivit A =["+värde1+"] B =["+värde2+"]\n");
                    
                    if (värde1 > värde2) // om värde 1 är större än 2 printa upp till värde 2 
                    {
                        for(int i = värde2 + 1; i <= värde1-1; i++)
                        {
                            Console.WriteLine(i);
                        }

                    }

                    if (värde2 > värde1) // som tidigare funktionen men åt andra hållet 2 -> 1
                    {
                        for (int i = värde1+1; i <= värde2-1; i++)
                        {
                            Console.WriteLine(i);
                        }
                    }

                    if (värde1 == värde2)
                    {
                        Console.WriteLine("Du har matat in samma värde för A & B");
                    }

                    bool loop = true;
                    string isValid = string.Empty;

                    while (loop == true)
                    {
                        Console.WriteLine("Tryck [1] för att återgå till huvudmeny eller\nTryck [2] för att börja om");
                        string YorN = Console.ReadLine();

                        if (YorN == "1")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN == "2")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN != "1" && YorN != "2")
                        {
                            Console.WriteLine("Något blev fel, Var god mata in [1] eller [2]");

                        }
                    }

                    if (isValid == "1")
                    {
                        menyVal = 1;
                    }
                    if (isValid == "2")
                    {
                        menyVal = 14;
                    }


                }

                else if (menyVal == 15)
                {
                    
                    string användarInput = string.Empty;
                    
                    Console.WriteLine("Menyval [15], Udda eller jämnt? \nVar god mata in minst 2 heltal på följande sätt 1,2,3 osv");                 
                    användarInput = Console.ReadLine();
                  
                    

                    int[] intArray = Array.ConvertAll(användarInput.Split(','), int.Parse);
                    int arrayLängd = intArray.Length;
                    int[] jämnaTal = new int[arrayLängd];
                    int[] uddaTal = new int [arrayLängd];
                    int i, jämnRäknare = 0, uddaRäknare = 0;
                    for(i = 0; i < arrayLängd; i++)
                    {
                        if(intArray[i] % 2 == 0)
                        {
                            jämnaTal[jämnRäknare] = intArray[i];
                            jämnRäknare++;
                        }
                        else if (intArray[i] % 2 == 1)
                        {
                            uddaTal[uddaRäknare] = intArray[i];
                            uddaRäknare++;
                        }

                    }
                    
                    Console.WriteLine("Följande jämna tal hittades");
                    for (i = 0; i < jämnRäknare; i++)
                    {
                        Console.WriteLine(jämnaTal[i]);
                    }
                    Console.WriteLine("Följande udda tal hittades");
                    for (i = 0; i < uddaRäknare; i++)
                    {
                        Console.WriteLine(uddaTal[i]);
                    }


                    bool loop = true;
                    string isValid = string.Empty;

                    while (loop == true)
                    {
                        Console.WriteLine("Tryck [1] för att återgå till huvudmeny eller\nTryck [2] för att börja om");
                        string YorN = Console.ReadLine();

                        if (YorN == "1")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN == "2")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN != "1" && YorN != "2")
                        {
                            Console.WriteLine("Något blev fel, Var god mata in [1] eller [2]");

                        }
                    }

                    if (isValid == "1")
                    {
                        menyVal = 1;
                    }
                    if (isValid == "2")
                    {
                        menyVal = 15;
                    }

                }

                else if (menyVal == 16)
                {

                    string användarInput = string.Empty;

                    Console.WriteLine("Menyval [16], Addition av heltal\nVar god mata in x antal heltal på följande vis 1,2,3,4,5 ");
                    användarInput = Console.ReadLine();

                    int[] intArray = Array.ConvertAll(användarInput.Split(','), int.Parse);
                    int addition = intArray.Sum();

                    Console.WriteLine("Värderna som du har matat in blir efter addition följande = [" + addition + "]");

                    bool loop = true;
                    string isValid = string.Empty;

                    while (loop == true)
                    {
                        Console.WriteLine("Tryck [1] för att återgå till huvudmeny eller\nTryck [2] för att börja om");
                        string YorN = Console.ReadLine();

                        if (YorN == "1")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN == "2")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN != "1" && YorN != "2")
                        {
                            Console.WriteLine("Något blev fel, Var god mata in [1] eller [2]");

                        }
                    }

                    if (isValid == "1")
                    {
                        menyVal = 1;
                    }
                    if (isValid == "2")
                    {
                        menyVal = 16;
                    }

                }

                else if (menyVal == 17)
                {
                    Spelkarraktär spelare1 = new Spelkarraktär();
                    Spelkarraktär spelare2 = new Spelkarraktär();
                    string Namn1 = string.Empty; string Namn2 = string.Empty;                    

                    Console.WriteLine("Menyval [17], Spelkarraktärer\nVar god mata in första spelarens namn!");
                    Namn1 = Console.ReadLine();

                    Console.WriteLine("Var god mata in motståndarens namn!");
                    Namn2 = Console.ReadLine();
                    Console.WriteLine("");

                    Random random = new Random();
                    spelare1.namn = Namn1;
                    spelare1.hälsa = random.Next(0, 1000);
                    spelare1.styrka = random.Next(0, 100);
                    spelare1.tur = random.Next(0, 100);

                    spelare2.namn = Namn2;
                    spelare2.hälsa = random.Next(0, 1000);
                    spelare2.styrka = random.Next(0, 100);
                    spelare2.tur = random.Next(0, 100);

                    Console.WriteLine($"Spelare 1\nNamn: {spelare1.namn}\nHälsa: {spelare1.hälsa}\nStyrka: {spelare1.styrka}\nTur: {spelare1.tur}\n");
                    Console.WriteLine($"Spelare 2\nNamn: {spelare2.namn}\nHälsa: {spelare2.hälsa}\nStyrka: {spelare2.styrka}\nTur: {spelare2.tur}\n");

                    bool loop = true;
                    string isValid = string.Empty;

                    while (loop == true)
                    {
                        Console.WriteLine("Tryck [1] för att återgå till huvudmeny eller\nTryck [2] för att börja om");
                        string YorN = Console.ReadLine();

                        if (YorN == "1")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN == "2")
                        {
                            isValid = YorN;
                            loop = false;
                        }

                        if (YorN != "1" && YorN != "2")
                        {
                            Console.WriteLine("Något blev fel, Var god mata in Y eller N");

                        }
                    }

                    if (isValid == "1")
                    {
                        menyVal = 1;
                    }
                    if (isValid == "2")
                    {
                        menyVal = 17;
                    }

                }                

            }

            Console.WriteLine("Programmet stänger nu ner!\nTryck valfri knapp för att avsluta programmet");
        }        
    }
}
