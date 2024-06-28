class Program
{
    static void Main()
    {
        int hod = 0;
        int[] randomNumberArray = GenerateUniqueFourDigitNumberArray();
        Console.WriteLine("Добро пожаловать в игру Быки и Коровы!");
        Console.WriteLine("Я загадал случайное четырехзначное число с уникальными цифрами.");
        Console.WriteLine("Попробуйте угадать его.");
        // Console.WriteLine($"{randomNumberArray[0]}{randomNumberArray[1]}{randomNumberArray[2]}{randomNumberArray[3]}");
        while (true)
        {
            int cow = 0;
            int bull = 0;
            Console.Write("Введите ваше предположение: ");
            hod += 1;
            string choice = Console.ReadLine();

            for (int i = 0; i < choice.Count(); i++)
            {
                var letter = choice[i];
                var num = int.Parse(letter.ToString());
                for (int j = 0; j < randomNumberArray.Count(); j++)
                {
                    if (num == randomNumberArray[j])
                    {
                        if (i == j)
                        {
                            bull += 1;
                        }
                        else
                        {
                            cow += 1;
                        }
                        break;
                    }
                }
            }
            Console.WriteLine("Быков: " + bull + " коров: " + cow);
            if (bull == 4)
            {
                break;
            }
        }
        Console.WriteLine("Вы угадали за " + hod + " ходов, чисдом было: " + $"{randomNumberArray[0]}{randomNumberArray[1]}{randomNumberArray[2]}{randomNumberArray[3]}");
    }

    static int[] GenerateUniqueFourDigitNumberArray()
    {
        Random random = new Random();
        HashSet<int> digits = new HashSet<int>();

        while (digits.Count < 4)
        {
            int digit = random.Next(0, 10);
            digits.Add(digit);
        }

        int[] result = digits.ToArray();
        return result;
    }
}
