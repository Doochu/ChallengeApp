// liczby równe ==
// liczba mniejsza >
// liczba większa <
// liczba mniejsza lub równa  >=
// liczba większa lub równa <=
// liczba różna !=

var name = "Artur";
var sex = "mężczyzna";
var age = 17;

if (sex != "mężczyzna" && age < 30)
{
    Console.WriteLine("KOBIETA PONIŻEJ 30 LAT");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("EWA, LAT 30");
}
else if (sex == "mężczyzna" && age < 18)
{
    Console.WriteLine("MĘŻCZYZNA NIEPEŁNOLETNI");
}
