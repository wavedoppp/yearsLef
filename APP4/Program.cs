

namespace LifeCountdown
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите Имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите Фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());

            
            int yearsLeft = 40 - age;

            
            string outputText = $"Привет, {firstName} {surname}! Тебе осталось {yearsLeft} лет до сорока лет!";

            
            Console.WriteLine(outputText);
            Console.ReadLine();
            return;
        }
    }
}