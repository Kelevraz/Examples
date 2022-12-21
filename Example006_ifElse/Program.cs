Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "катя")
{
    Console.WriteLine("Ты охуенна!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}