Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "кира")
{
    Console.WriteLine("Привет");
}
else
{
    Console.Write("Привет, ");
    Console.WtiteLine(username);
}