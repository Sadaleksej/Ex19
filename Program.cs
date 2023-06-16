// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
int M = N;
int I = 1;
int V = 1;
if (N<10)
 {
Console.WriteLine("Введено неверное значение N");
return;
}
while (M/10 >= 1)
{
M = M/10;
I++;
}
M = N;
int[] num = new int[I];
for (int k = 1; k<=I; k++)
{num[k-1] = M%10;
M = M/10;}
 
//for (int k = 1; k<=I; k++) Console.WriteLine(num[k-1]);//
 
for (int k = 1; k<=I; k++) if(num[k-1] != num[I-k]) V++;
 
if (V==1) Console.WriteLine("Бинго! Ваше число - полиндром!");
else Console.WriteLine("Сожалеем, Ваше число - не полиндром! Попробуйте еще!");
