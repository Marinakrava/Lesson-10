using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите значение градуса");
            int gradus_ = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение минут");
            int min_ = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение секунд");
            int sec_ = Convert.ToInt32(Console.ReadLine());

            Radians radians = new Radians(gradus_, min_, sec_);        

            Console.WriteLine("Переводим градусы в радианы" );
            double totalradians = radians.ToRadians();
            Console.WriteLine(totalradians);
            Console.ReadKey();
        }
       
    }
}
