Console.WriteLine("Введите ваше имя");
string name = Console.ReadLine()!;
if (name.ToLower() == "маша" )
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(name);
}