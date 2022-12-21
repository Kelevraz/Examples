Console.WriteLine("Привет!");
Console.WriteLine("Что я должен сделать?");
string username = Console.ReadLine();

if(username.ToLower() == "ты знаешь")
{
    Console.WriteLine("Понял ;) подтверди отправку");
    string ans = Console.ReadLine();
    if(ans.ToLower() == "yes")
    {
    Console.WriteLine("КАТЯ!");
    Console.WriteLine("ТЫ ОХУЕННА!");
    }
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}