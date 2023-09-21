internal class Program
{
    static void MyThreadChicken()
    {
        for (int i = 0; i < 100; i++) //Запускаем цикл, который будет выводить слово Курица 100 раз
            Console.WriteLine("Курица");
    }

    static void MyThreadAnswer(Thread chicken)
    {
        Thread.Sleep(10); //Приостановим выполнение текущего потока на 10 миллисекунд
        bool ans = chicken.IsAlive; // Проверяем, жив ли поток с курицей
        Console.WriteLine(ans ? "Спор Окончен. Победила Курица." : "Спор окончен. Победило Яйцо."); //Выводим сообщение, в зависимости от результата проверки
    }
    private static void Main(string[] args)
    {
        Thread chicken = new(MyThreadChicken); // Создаём новый поток с методом MyThreadChicken
        chicken.Start(); //Запускаем поток

        for (int i = 0; i < 100; i++) //Запускаем цикл, который будет выводить слово Яйцо 100 раз
            Console.WriteLine("Яйцо");

        MyThreadAnswer(chicken); //Вызываем метод MyThreadChicken, передавая ему поток с курицей
    }
}