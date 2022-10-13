Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "кира")
{
    Console.Write("Привет, Кира!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}