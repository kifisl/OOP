using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_16
{
    class Program
    {
        public static void ErSieve(int n)
        {
            System.Threading.Thread.Sleep(100);
            Stopwatch sw = new Stopwatch();
            sw.Start();

            bool[] flags = new bool[n];

            for (int i = 0; i < flags.Length; i++)
                flags[i] = true;

            flags[1] = false;
            for (int i = 2, j = 0; i < n;)
            {
                if (flags[i])
                {
                    j = i * 2;
                    while (j < n)
                    {
                        flags[j] = false;
                        j += i;
                    }
                }
                i++;
            }

            Console.WriteLine($"Все простые числа до {n}:  ");
            for (int i = 2; i < flags.Length; i++)
            {
                if (flags[i])
                {
                    Console.Write($" {i} ");
                }
            }
            Console.WriteLine();
            sw.Stop();
            Console.WriteLine($"Алгоритм занял {sw.ElapsedMilliseconds} мсек");
        }
        public static CancellationTokenSource tokenSource = new CancellationTokenSource();
        public static void EratosSieve2(int n)
        {
            System.Threading.Thread.Sleep(100);
            Stopwatch sw = new Stopwatch();
            sw.Start();

            bool[] flags = new bool[n];

            for (int i = 0; i < flags.Length; i++)
                flags[i] = true;

            flags[1] = false;
            for (int i = 2, j = 0; i < n;)
            {
                Console.WriteLine($"Выполняется задача №{Task.CurrentId}.");
                System.Threading.Thread.Sleep(200);
                if (flags[i])
                {
                    j = i * 2;
                    while (j < n)
                    {
                        flags[j] = false;
                        j += i;
                    }
                }
                i++;

                if (tokenSource.IsCancellationRequested)
                {
                    Console.WriteLine("\n Процесс преждевременно остановлен.");
                    return;
                }
            }
            Console.WriteLine($"Все простые числа до {n}:  ");
            for (int i = 2; i < flags.Length; i++)
            {
                if (flags[i])
                {
                    Console.Write($" {i} ");
                }
            }
            Console.WriteLine();
            sw.Stop();
            Console.WriteLine($"Алгоритм занял {sw.ElapsedMilliseconds} мсек");
        }
        static void Main(string[] args)
        {
            #region Task 1
            Task task = new Task(() => ErSieve(1000));
            Console.WriteLine($"Task #{task.Id} статус - {task.Status}");
            task.Start();
            while (true)
            {
                System.Threading.Thread.Sleep(10);
                Console.WriteLine($"Task #{task.Id} статус - {task.Status}");
                if (task.Status == TaskStatus.RanToCompletion)
                    break;
                else
                    Console.WriteLine($"Task #{task.Id} статус - {task.Status}");
            }

            Console.WriteLine($"Task #{task.Id} статус - {task.Status}");
            #endregion
            #region Task 2
            Console.Write("Введите n:");
            int n2;
            n2 = Convert.ToInt32(Console.ReadLine());

            Task task2 = new Task(() => EratosSieve2(n2));
            Console.WriteLine($"Task #{task2.Id}  статус - {task2.Status}");
            task2.Start();

            Console.WriteLine("\nЧтобы остановить задачу нажмите 0:");
            string s = Console.ReadLine();
            if (s == "0")
                tokenSource.Cancel();

            Console.WriteLine($"Task #{task2.Id} статус - выполнено");
            #endregion
        }
    }
}