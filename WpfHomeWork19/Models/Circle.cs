using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHomeWork19.Models
{
    public static class Circle
    {
        public const double PI = 3.1415926535897931;
        //метод возвращает значение длины окружности
        public static double Length(double radius) => Math.Round(2 * PI * radius, 2);
        //метод возвращает значение площади круга
        public static double Area(double radius) => Math.Round(Math.Pow(radius, 2) * PI, 2);
    }
}

