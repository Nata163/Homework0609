// На вход принимает цифру, обозначающую день недели и проверяет, является ли это выходным днем

void Weekend ()
{
    int number = new Random().Next(1,8);
    Console.WriteLine($"Случайно сгенерированное число {number}");
    if (number == 6) Console.WriteLine("Да, сегодня суббота!");
    else if (number ==7) Console.WriteLine("Да, сегодня воскресенье!");
    else Console.WriteLine("Будний день");
}

Weekend();

