Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "варя")
{
    Console.WriteLine("Это Варюша же!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}