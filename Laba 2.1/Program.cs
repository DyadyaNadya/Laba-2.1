
using System;

public class Program
{
    public static void Main()
    {
        try
        {

            Console.Write("Введите номер игрока: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите набранное им количество очков: ");
            int points = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите набранное им количество подборов: ");
            int rebounds = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите набранное им количество передач: ");
            int assists = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите общее количество бросков: ");
            int fga = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество попаданий: ");
            int fgm = Convert.ToInt32(Console.ReadLine());


            //Класс Basketball
            Basketball gameStats = new Basketball(points, rebounds, assists);

            // Тестирование конструктора копирования
            Basketball copiedStats = new Basketball(gameStats);
            Console.WriteLine("Копия статистики с небольшим изменением:");
            Console.WriteLine(copiedStats.ToString());


            //Класс Player 
            Player player = new Player(number, points, rebounds, assists);
            Console.WriteLine($"Демонстрация работы метода DisplayInfo из класса Player: ");
            player.DisplayInfo();
            int tsp = player.CountTSPerc(fga, fgm);
            Console.WriteLine($"\nДемонстрация работы метода CountTSPerc: ");
            Console.WriteLine($"Процент попаданий: {tsp}% ");


           
        }

        catch
        {
            Console.WriteLine("Ошибка! Полученные данные некорректны");
        }



    }
}
