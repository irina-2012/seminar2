// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int a = int.Parse(Console.ReadLine());
while (a > 1 && a < 7){
    if(a < 6) {
        Console.WriteLine($"{a} -> рабочий день");
    } else Console.WriteLine($"{a} -> выходной день"); 
    return;
}  Console.WriteLine("Введите корректное число...");
