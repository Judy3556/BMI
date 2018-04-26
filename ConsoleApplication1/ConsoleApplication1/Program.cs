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
            //定義一個用來充當身高的數
            Console.WriteLine("請寫出您的身高/m：");
            string heigh = Console.ReadLine();

            //定義一個用來充當體重的數
            Console.WriteLine("請寫出您的體重/kg：");
            string weigh = Console.ReadLine();

            //定義兩個數用來計算BMI
            double hh = double.Parse(heigh) * double.Parse(heigh);
            double Ex = double.Parse(weigh) / hh;

            //定義雙精度函數取一位小數點
            double BMI = Math.Round(Ex, 1);

            //顯示計算所得BMI值
            Console.WriteLine("您的BMI為");
            Console.WriteLine(BMI);

            //顯示該BWI值所屬的體重區塊
            Console.WriteLine("您的體重區塊為");
            if (Ex < 18.5)
                Console.WriteLine("體重偏輕");
            else if (18.5 <= Ex && Ex < 23.9)
                Console.WriteLine("體重正常");
            else if (Ex <= 27 && 24 < Ex)
                Console.WriteLine("體重偏重");
            else if (Ex <= 32 && 28 < Ex)
                Console.WriteLine("肥胖");
            else if (Ex > 32)
                Console.WriteLine("过度肥胖");

            //顯示服兵役體位
            if (Ex < 16.5)
                Console.WriteLine("您處於免役體位");
            else if (Ex >= 16.5 && Ex < 17)
                Console.WriteLine("您處於替代役體位");
            else if (Ex >= 17 && Ex <= 31)
                Console.WriteLine("您處於常備役體位");
            else if (Ex > 31 && Ex <= 31.5)
                Console.WriteLine("您處於替代役體位");
            else if (Ex > 31.5)
                Console.WriteLine("您處於免役體位");

            //暫停
            Console.ReadLine();
        }
    }
}
