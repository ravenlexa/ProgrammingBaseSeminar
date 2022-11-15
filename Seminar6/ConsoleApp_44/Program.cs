/*Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.*/
/*Console.WriteLine("До какого числа считать ряд Фибоначчи?");
int number = Convert.ToInt32(Console.ReadLine());

int perv = 0;
Console.Write("{0} ", perv);
int vtor = 1;
Console.Write("{0} ", vtor);
int sum = 0;
int i = 2;
while (number > i)
{
    
    sum = perv + vtor;
                
    Console.Write("{0} ", sum);
                    
    perv = vtor;
    vtor = sum; 
    i++;               
}*/
int n = 9;

int f1 = 0;
int f2 = 1;
int f3 = 0;
 
Console.Write("0 1 ");

for (int i = 2; i < n; i++)
{
  f3 = f1 + f2;
  Console.Write(f3 + " ");
  f1 = f2;
  f2 = f3;
}

