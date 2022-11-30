/*Задача 2
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/


Console.WriteLine("Введите первое число");
string numberSecondStr = Console.ReadLine()??"";

Console.WriteLine("Введите второе число");
string numberFirstStr = Console.ReadLine()??"";

int numberSecond = Convert.ToInt32(numberSecondStr);
int numberFirst = Convert.ToInt32(numberFirstStr);

if(numberSecond > numberFirst){
    Console.WriteLine($"наибольшее число {numberSecond}");
}else{
    Console.WriteLine($"наибольшее число {numberFirst}");
}