/* 1. Программа, которая выведет все натуральные числа в промежутке от N до 1.

Console.WriteLine("Введите число N (N больше 0)");
int N =int.Parse(Console.ReadLine());
string Function(int n){
    if (n==1) return 1.ToString();
    else { 
    return (n+" "+Function(n-1));}}

Console.WriteLine(Function(N));
*/

/* 2. Программа, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число N и M (N больше M)");
int N =int.Parse(Console.ReadLine());
int M =int.Parse(Console.ReadLine());

 int Function(int n, int m){
    if (n==m) return m;
    else { 
    return (m+Function(n, m+1));}}

Console.WriteLine(Function(N, M));
*/
// 3. Программа вычисления функции Аккермана с помощью рекурсии.

Console.WriteLine("Введите два неотрицатльных числа N и M (N больше M)");
int N =int.Parse(Console.ReadLine());
int M =int.Parse(Console.ReadLine());
int Akkerman (int m,int n){
    if (m==0) return n+1;
    if (n==0) return Akkerman(m-1,1);
    if (m>0 && n>0) return Akkerman(m-1,Akkerman(m,n-1));
    else Console.WriteLine("ошибка, числа N и M должны быть положительными");
    }
Console.WriteLine(Akkerman(M,N));