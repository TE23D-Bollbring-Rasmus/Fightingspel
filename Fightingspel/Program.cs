Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();
int Hp = 100;

int damage = Random.Shared.Next(1,21);
Hp= Hp-damage;

while (name == "")
{
    Console.WriteLine("ditt namn");
    name = Console.ReadLine();
}


Console.ReadLine(); 