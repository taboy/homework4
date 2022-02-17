//Задача 26: Возведите число А в натуральную степень B, используя цикл.


Console.WriteLine("write a number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write a stepen");
int num2 = Convert.ToInt32(Console.ReadLine());
void stepen(int a,int b){
    int count=2;
    int c=a;
    while(count<=b){
        a=a*c;
        count++;
        
    }
Console.WriteLine(a);

}
stepen(num,num2);
