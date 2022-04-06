// Задача 3: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(100, 1000);
    }
    return answer;
}

void PrintArray(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + ", ");
    }
    Console.WriteLine();
}

int[] arr = RandArray(5);
PrintArray(arr);
int max = 0;

for (int i = 0; i < arr.Length; i++)
{
    if(max < arr[i])
         max = arr[i];
         
}

Console.WriteLine($"Это максимальное число => {max}");

int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if(min > arr[i])
        min = arr[i];
}

Console.WriteLine($"Это минимальное число => {min}");

Console.WriteLine($"Это разница max и min => {max-min}");