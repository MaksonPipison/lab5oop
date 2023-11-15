using System;

public class Sphere
{
    private double radius;

    public double Radius
    {
        get { return radius; }
        set
        {
            if (value >= 0)
                radius = value;
        }
    }

    public double CalculateVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкта класу Sphere
        Sphere sphere = new Sphere();

        // Введення та перевірка значення радіусу кулі
        double radius;
        Console.Write("Введіть радіус кулі: ");

        while (!double.TryParse(Console.ReadLine(), out radius) || radius < 0)
        {
            Console.WriteLine("Введено некоректне значення. Введіть будь ласка додатнє число.");
            Console.Write("Введіть радіус кулі: ");
        }

        // Встановлення значення радіусу кулі
        sphere.Radius = radius;

        // Обчислення та виведення об'єму кулі
        Console.WriteLine($"Об'єм кулі з радіусом {sphere.Radius} дорівнює {sphere.CalculateVolume():F2}");
    }
}
