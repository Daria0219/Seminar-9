/* 1. Программа, которая выведет все натуральные числа в промежутке от N до 1.

Console.WriteLine("Введите число N (N больше 0)");
int N =int.Parse(Console.ReadLine());
string Function(int n){
    if (n==1) return 1.ToString();
    else { 
    return (n+" "+Function(n-1));}}

Console.WriteLine(Function(N));
*/

// Программа, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число N и M (N больше M)");
int N =int.Parse(Console.ReadLine());
int M =int.Parse(Console.ReadLine());

 int Function(int n, int m){
    if (n==m) return m;
    else { 
    return (m+Function(n, m+1));}}

Console.WriteLine(Function(N, M));