using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тест2
{
    public class DemoExam
    {
        static void Main(string[] args)
        {
            Exam(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
        }
        public static int Exam(string a, string b, string c)
        {
            int task1MaxPoints = 22;
            int task2MaxPoints = 38;
            int task3MaxPoints = 20;

            int pointsTask1 = -1;
            int pointsTask2 = -1;
            int pointsTask3 = -1;

            while (pointsTask1 < 0)
            {
                Console.WriteLine("Количество баллов за задание 1:");
                try
                {
                    pointsTask1 = int.Parse(a);
                }
                catch (Exception)
                {
                }

                if (!IsCorrect(pointsTask1, task1MaxPoints))
                {
                    Console.WriteLine("В программу ввели некорректные значения. Посмотрите систему оценивания и введите корректные данные");
                    pointsTask1 = -1;
                }
            }

            while (pointsTask2 < 0)
            {
                Console.WriteLine("Количество баллов за задание 2:");
                try
                {
                    pointsTask2 = int.Parse(b);
                }
                catch (Exception)
                {
                }

                if (!IsCorrect(pointsTask2, task2MaxPoints))
                {
                    Console.WriteLine("В программу ввели некорректные значения. Посмотрите систему оценивания и введите корректные данные");
                    pointsTask2 = -1;
                    
                }

            }

            while (pointsTask3 < 0)
            {
                Console.WriteLine("Количество баллов за задание 3:");
                try
                {
                    pointsTask3 = int.Parse(c);
                }
                catch (Exception)
                {
                }

                if (!IsCorrect(pointsTask3, task3MaxPoints))
                {
                    Console.WriteLine("В программу ввели некорректные значения. Посмотрите систему оценивания и введите корректные данные");
                    pointsTask3 = -1;
                }
            }

            int totalPoints = pointsTask1 + pointsTask2 + pointsTask3;

            Console.WriteLine($"Общая сумма баллов ученика/ученицы за : {totalPoints}");

            if (totalPoints >= 56 && totalPoints <= 80)
            {
                Console.WriteLine("Оценка: 5 (отлично)");
            }
            else if (totalPoints >= 32 && totalPoints <= 55)
            {
                Console.WriteLine("Оценка: 4 (хорошо)");
            }
            else if (totalPoints >= 16 && totalPoints <= 31)
            {
                Console.WriteLine("Оценка: 3 (удовлетворительно)");
            }
            else
            {
                Console.WriteLine("Оценка: 2 (неудовлетворительно)");
            }

            return totalPoints;
        }

        static bool IsCorrect(int points, int maxPoints)
        {
            return points >= 0 && points <= maxPoints;
        }
    }
}

