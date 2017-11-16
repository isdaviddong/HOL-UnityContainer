using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用薪資計算器 SalaryCalculator，引用基本公式 SalaryFormula
            SalaryCalculator SC = new SalaryCalculator(new SalaryFormula());
            //工時 , 時薪,  請假天數
            float amount = SC.Calculate(8 * 19, 200, 8);
            Console.Write("amount:" + amount);
            Console.ReadKey();
        }
    }
}
