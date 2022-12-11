do
{
    Console.Write("Введите что - нибудь(например, Ваше имя!) : ");
    string enter = Console.ReadLine();
    string result = "";
    int chosenOrder = 0;
    Random random = new Random();


    Console.WriteLine("Выберете новый порядок букв во введённом слове:");
    Console.WriteLine("1 - обратный;\n2 - случайный;");
    int.TryParse(Console.ReadLine(), out chosenOrder);

    switch (chosenOrder)
    {
        case 1:
            for (int i = enter.Length - 1; i > -1; i--)
            {
                result += enter[i];
            }
            Console.WriteLine(result);
            // или короче
            /* string shortestResult = string.Join("", enter.ToCharArray().Reverse());
            ** Console.WriteLine(shortestResult);*/
            ; break;
        case 2:
            char temp;
            int indexOfChar = 0;
            int step = 0;
            char[] enterChars = enter.ToCharArray();
            while (step < enterChars.Length)
            {
                temp = enterChars[step];
                indexOfChar = random.Next(0, enterChars.Length);
                enterChars[step] = enterChars[indexOfChar];
                enterChars[indexOfChar] = temp;
                step++;
            }
            result = String.Concat(enterChars);
            Console.WriteLine(result);
            ; break;
        default:
            Console.WriteLine("Такой порядок ещё не придуман! Поэтому будем считать, что Вы выбрали первый вариант перестановки))");
            goto case 1;
    }
    Console.Beep();
    Console.WriteLine("Если хотите переставить буквы ещё в каком-нибудь слове - нажмите Enter; хотите закончить - Escape!");
} while (Console.ReadKey().Key != ConsoleKey.Escape);

