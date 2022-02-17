//Задача 32: Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран

int[]massiv = new int[8];
void fillArray(int[] filled){
    int lenght=filled.Length;
    int index = 0;
    while(index<lenght){
        filled[index]= new  Random().Next(0,2);
        index++;
    }
}
void printArray(int[] printed){
    int lenght= printed.Length;
    int index=0;
    while(index<lenght){
        Console.WriteLine(printed[index]);
        index++;
    }
}
fillArray(massiv);
printArray(massiv);