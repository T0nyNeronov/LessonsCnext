// Напишите программу, замена элементов массива,
// положительные элементы замените на отрицательные, и наоборот.

// [-4, -158, 8, 2] -> [4, 8, -8, -2]


int [] array = {-8,5,78,-11};

int [] array2 =new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    array2[i]=-array[i];
    array[i]=-array[i];
}
 Console.WriteLine(String.Join(" ",array2));