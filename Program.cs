//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.//

/* int num = new Random().Next(100,1000);
int a = num / 10;
int b = num / 100 * 10;
int c = a - b;
Console.WriteLine(num + "=>" + c); */


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*Console.WriteLine("Введите число");
string number = Console.ReadLine();
int n = number.Length;
if (n > 2)
{
    Console.WriteLine(number + "->" + number[2]);
}
else
{
    Console.WriteLine(number + "-> третьей цифры нет");
}*/


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.//

Console.WriteLine("Напишите цифру, обозначающую день недели");
int n = int.Parse(Console.ReadLine());
while(n>7 || n<1)
{
    Console.WriteLine("Введите число от 1 до 7");
    n = int.Parse(Console.ReadLine());
}
if (n==1 || n==2 || n==3 || n==4 || n==5 )     
{
Console.WriteLine(n+"->нет");
}
else 
{
    Console.WriteLine(n+"->да");
}





