//С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
int n=Convert.ToInt32(Console.ReadLine());
int f=0;
int f1=1;
int f2=1;
int i=0;
while (i<n-2)
{
   f=f1+f2;
   f1=f2;
   f2=f;
    i++;
}

System.Console.WriteLine(f);