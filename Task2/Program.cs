// вывод 3ей цифры заданного числа или сообщает, что третьей цифры нет

void ThirdDigit(int number)
{
   if (number>99 & 999>number) Console.WriteLine($"Третья цифра {number%10}");
   else if  (number>999 & 9999>number) Console.WriteLine($"Третья цифра {number%100/10}");
   else if  (number>9999 & 99999>number) Console.WriteLine($"Третья цифра {number%1000/100}");
   else Console.WriteLine("Третьей цифры нет");
}

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
ThirdDigit(number);