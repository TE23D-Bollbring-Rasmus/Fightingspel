Console.WriteLine("Vad heter du?");
string Hjältename = Console.ReadLine();
string Fiendename = "Fiende";
int HjälteHp = 100;
int FiendeHp = 100;
while (Hjältename.Length < 2 )
{
    Console.WriteLine("ditt namn");
    Hjältename = Console.ReadLine();
}
 


while (HjälteHp > 0 && FiendeHp > 0)
{
    Console.WriteLine("\n Ny runda");
    Console.WriteLine($"{Hjältename}: {HjälteHp} {Fiendename}: {FiendeHp}");
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
        Console.WriteLine($"{Fiendename} vann!");
    }
    else if (FiendeHp <= 0){
        Console.WriteLine($"{Hjältename} vann!");
    }
    Console.WriteLine("Tryck på en knapp för att fortsätta");
    Console.ReadKey();
}




Console.ReadLine(); 