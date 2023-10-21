string name = "Ewa";
string sex = "kobieta";
var age = 23;

if (sex == "kobieta" && age < 30) 
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33 && sex == "kobieta")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == "mężczyzna" && age < 18) 
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Niepoprawne dane");   
}