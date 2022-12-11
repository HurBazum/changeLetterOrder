Console.Write("Введите что - нибудь(например, Ваше имя!) : ");
string enter = Console.ReadLine();
string result = "";
for(int i = enter.Length - 1;i > -1; i--)
{
    result += enter[i];
}
Console.WriteLine(result);
// или короче
string shortestResult = string.Join("", enter.ToCharArray().Reverse());
Console.WriteLine(shortestResult);
