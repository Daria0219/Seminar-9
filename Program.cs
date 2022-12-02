// 1. Программа, которая выведет все натуральные числа в промежутке от N до 1.

Console.WriteLine("Введите число N (N больше 0)");
int N =int.Parse(Console.ReadLine());
string Function(int n){
    if (n==1) return 1.ToString();
    else { 
    return (n+" "+Function(n-1));}}

Console.WriteLine(Function(N));