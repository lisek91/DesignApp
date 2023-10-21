string Name = "Ewa";
string Sex = "kobieta";
var Age = 23;

if (Sex == "kobieta" && Age < 30) 
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (Name == "Ewa" && Age == 33 && Sex == "kobieta")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (Sex == "mężczyzna" && Age < 18) 
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Niepoprawne dane");   
}