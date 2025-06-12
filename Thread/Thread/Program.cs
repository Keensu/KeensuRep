//Разделить массив на M частей (где M — количество потоков).
//Каждый поток должен вычислять сумму своей части массива.
//Основной поток должен дождаться завершения всех потоков и вывести итоговую сумму.
//Сравнить время выполнения однопоточной и многопоточной версий.
//Убедиться, что нет состояния гонки (race condition) при обновлении общей суммы.

using System.Threading;

Random rnd = new Random();
int total = 10 ^ 8;
int counter = 0;
int[] arr = new int [total];
for (int i = 0; i < total; i++)
{
    arr.Append(rnd.Next(1, 1000));
}
Thread[] threads = new Thread[10000];

for (int i = 0; i < threads.Length; i++)
{
    int currentRange = total / 10000;
    threads[i] = new Thread(() => Summary(arr, i * currentRange, i * currentRange + currentRange));
    threads[i].Start();
}

foreach (var thread in threads)
{
    thread.Join();
}
Console.WriteLine(counter);

void Summary(int[] arr, int stInd, int enInd)
{
    var sum = 0;

    for (int i = stInd; i < enInd; i++)
    {
        sum += arr[i];
    }

    Interlocked.Add(ref counter, sum);
}
