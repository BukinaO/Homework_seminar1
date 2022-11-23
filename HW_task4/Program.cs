// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите первое число:  ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());

if(numberOne>numberTwo && numberOne>numberThree)
{
    Console.WriteLine(" -> " + numberOne);
}
if(numberTwo>numberOne && numberTwo>numberThree)
{
    Console.WriteLine(" -> " + numberTwo);
}
if(numberThree>numberTwo && numberThree>numberOne)
{
    Console.WriteLine(" -> " + numberThree);
}

