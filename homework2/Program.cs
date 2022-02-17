// Задача 28: Подсчитайте сумму цифр в числе.

Console.WriteLine("write a number "); 
int sum = Convert.ToInt32(Console.ReadLine()); 
            int a = 0; 
            while (sum > 0) 
            { 
  
                a = a + sum % 10; 
                sum =sum /10 ; 
  
            } 
 Console.WriteLine(a);