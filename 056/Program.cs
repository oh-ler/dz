//Написать программу копирования массива

int n=Convert.ToInt32(Console.ReadLine());
int [] a=new int[n];
int [] b=new int[n];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(-100,100);
    
    for(int i=0;i<a.Length;i++)
System.Console.WriteLine($"{a[i]}");

for(int i=0;i<b.Length;i++)
    b[i]=a[i];
    
    for(int i=0;i<b.Length;i++)
System.Console.WriteLine($"{b[i]}");