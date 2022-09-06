// на вход трёхзначное число, на выход вторую цифру этого числа

void SecondDigit()
{
    int num = new Random().Next(100, 1000);
    int num1 = num/10;
    int num2 = num1%10;
    Console.WriteLine($"{num}");
    Console.WriteLine($"Вторая цифра {num2} ");
}

SecondDigit();
