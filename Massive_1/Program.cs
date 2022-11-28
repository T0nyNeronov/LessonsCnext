// Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найти сумму отрицательных 
// и положительных элементов массива.
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] (12 элементоа int = [12])
// сумма положительных равна 29, отрицательных равна -20.
// new Random().Next(,) - это случайные числа

int [] array = new int[12];

int positivSum= 0;
int negativeSum = 0;

int [] GetArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i]= new Random().Next(-9,10);
if(array[i]>0)
{
positivSum += array[i];

}
if(array[i]<0)
{
negativeSum += array[i];

}
}
return array;

}
GetArray(array);

Console.WriteLine(String.Join(" ",array));

Console.WriteLine(positivSum);
Console.WriteLine(negativeSum);