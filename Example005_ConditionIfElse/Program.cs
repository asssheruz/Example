Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
	Console.WriteLine("Ураб это же Маша!");
}
else
{
	Console.WriteLine("Привет, ");
	Console.WriteLine(username);
}
