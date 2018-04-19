using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("写出你的身高/m");
            string heigh = Console.ReadLine();
            Console.WriteLine("写出你的体重/kg");
            string weigh = Console.ReadLine();
            double hh = double.Parse(heigh) * double.Parse(heigh);
            double Ex = double.Parse(weigh) / hh;
            Console.WriteLine("你的BMI为" + Ex);
            if (Ex < 18.5)
                Console.WriteLine("你的体重偏轻，你加油，有梦想终是好的/sorry, you are too light");
            else if (18.5 <= Ex && Ex < 23.9)
                Console.WriteLine("你的体重正常，我相信你可以当兵/good");
            else if (Ex <= 27 && 24 < Ex)
                Console.WriteLine("你的体重偏重，我不知道你能不能当兵不要问我/heavy");
            else if (Ex <= 32 && 28 < Ex)
                Console.WriteLine("你已经肥胖，我不知道你能不能当兵不要问我/too heavy");
            else if (Ex > 32)
                Console.WriteLine("你过度肥胖，我觉得你当不了兵/you are too heavy that the earth will broke");
            
            Console.ReadLine();
        }
    }
}
