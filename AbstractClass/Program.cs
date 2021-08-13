using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Andrew", 25000M); // 1 задание. Абастрактный класс Person с именем
            client.Display();
            Employee employee = new Employee("Vasya", "Director");
            employee.Display();
            Person person = new Client("Igor", 322M);
            person.Display();

            Rectangle rectangle = new Rectangle(); // 2 задание. Абастрактный класс Figure с абстрактными
                                                   // методами Area и Perimetr
            rectangle.Height = 20;
            rectangle.Width = 34.7;
            Console.WriteLine(rectangle.Area());
            Console.WriteLine(rectangle.Perimetr());

            Circle circle = new Circle();
            circle.Radius = 24.6;
            Console.WriteLine(circle.Area());
            Console.WriteLine(circle.Perimetr());
        }
    }
}
