Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Николя")
{
    Console.WriteLine("Дратути, Николя!");
}
else
    Console.WriteLine($"Привет, {username}!");