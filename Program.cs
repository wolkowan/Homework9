System.Console.WriteLine("Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
System.Console.WriteLine(PrintInterval(1,5)); 
System.Console.WriteLine();
System.Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
System.Console.WriteLine(Summ(1,15)); 
System.Console.WriteLine();
System.Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
// m = 2, n = 3 -> A(m,n) = 29
System.Console.WriteLine(A(3,2));
string PrintInterval(int M , int N)
{return (N==M ? Convert.ToString(M) : PrintInterval(M,(N-1)) + N);}
 
int Summ(int min, int max)
{
return(min == max?min:(max+Summ(min, max-1)));
}

int A(int m, int n)
{
    if(m==0)
    return n+1;
    else
    if((m!=0)&&(n==0))
    return A(m-1,1);
    else
    return A(m-1, A(m,n-1));    
}

