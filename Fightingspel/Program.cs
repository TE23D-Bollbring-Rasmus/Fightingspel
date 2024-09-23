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
    Console.WriteLine("Ny runda");
    Console.WriteLine($"{Hjältename}: {HjälteHp} {Fiendename}: {FiendeHp}");
    int fiendedamage = Random.Shared.Next(1,21);
    HjälteHp = HjälteHp-fiendedamage;
    int hjältedamage = Random.Shared.Next(1,21);
    FiendeHp = FiendeHp-hjältedamage;
}
if (HjälteHp == 0 && FiendeHp == 0){
    Console.WriteLine("Lika");
}
else if (FiendeHp == 0){
    Console.WriteLine($"{Hjältename} vann!");
}
else{
    Console.WriteLine($"{Fiendename} vann!");
}






Console.ReadLine(); 