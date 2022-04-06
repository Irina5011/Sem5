// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


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

int[] arr = RandArray(3);
PrintArray(arr);
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 == 0)
        sum = sum + arr[i];
}
Console.WriteLine($"Сумма элементов на нечетных позициях => {sum}");