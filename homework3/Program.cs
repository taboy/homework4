// Задача 30: Покажите кубы чисел, заканчивающихся на чётную цифру.

Console.WriteLine("write a number");
int num= Convert.ToInt16(Console.ReadLine());
void kub(int num2){

    int kub1 = num2;
    int first=2;
    int first1=1;
    while(first<=num2){     
        first1=first*first*first;
        first++;
        if (first1%2==0){
            Console.WriteLine(first1);
        }}}

kub(num);