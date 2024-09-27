Console.WriteLine("Vad heter du?");
string Hjältename = Console.ReadLine();
string Fiendename = "Fiende";
int HjälteHp = 5;
int FiendeHp = 50;
Console.WriteLine("Du är Musse Pigg och din motståndare är hans addiction till ciggaretter");

string hjälteASCII = @"
            .-""\""-.
           /       \
           \       /
    .-""\""-.-`.-.-.<  _
   /      _,-\ ()()_/:)
   \     / ,  `     `|
    '-..-| \-.,___,  /
          \ `-.__/  /
        / `-.__.-`\\
        / /|    ___\
       ( ( |.-""`   `'\\
        \ \/    {}{}  |
         \|           /
          \        , /
          ( __`;-;'__`)
          `//'`   `||`
         _//       ||
 .-""\""-._,(__)     .(__).-""\""-.
/          \    /           \
\          /    \           /
 `'-------`      `--------'`
";


string fiendeascii = @"
 a,  8a
 `8, `8)                            ,adPPRg,
  8)  ]8                        ,ad888888888b
 ,8' ,8'                    ,gPPR888888888888
,8' ,8'                 ,ad8""""   `Y888888888P
8)  8)              ,ad8""""        (8888888""""
8,  8,          ,ad8""""            d888""""
`8, `8,     ,ad8""""            ,ad8""""
 `8, `"" ,ad8""""            ,ad8""""
    ,gPPR8b           ,ad8""""
   dP:::::Yb      ,ad8""""
   8):::::(8  ,ad8""""
   Yb:;;;:d888""""  Normand
    ""8ggg8P""      Veilleux
";


while (Hjältename.Length < 2 )
{
    Console.WriteLine("ditt namn");
    Hjältename = Console.ReadLine();
}
 


while (HjälteHp > 0 && FiendeHp > 0)
{
    Console.WriteLine("\n Ny runda");
    Console.WriteLine($"{Hjältename}: {HjälteHp} {Fiendename}: {FiendeHp}");
    Console.WriteLine(hjälteASCII);
    Console.WriteLine(fiendeascii);
    int hjältedamage = Random.Shared.Next(1,21);
    int fiendedamage = Random.Shared.Next(1,21);
    HjälteHp = HjälteHp-fiendedamage;
    Console.WriteLine($"{Hjältename} gör {hjältedamage} skada på {Fiendename}");
    FiendeHp = FiendeHp-hjältedamage;
    Console.WriteLine($"{Fiendename} gör {fiendedamage} skada på {Hjältename}");
    if (FiendeHp <= 0 && HjälteHp <= 0){
        Console.WriteLine("Lika");
    }
    else if (HjälteHp <= 0){
        Console.WriteLine($"{Fiendename} vann! Musse dog av hans röknings addiction");
    }
    else if (FiendeHp <= 0){
        Console.WriteLine($"{Hjältename} vann! Musse slutade röka och levde 1 år till");
    }
    Console.WriteLine("Tryck på en knapp för att fortsätta");
    Console.ReadKey();
}




Console.ReadLine(); 