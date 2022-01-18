using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] orders;

            Console.WriteLine("Ingrese la operación con letras");
            string command = Console.ReadLine();
            Context context = new Context();
            orders = command.Split(' ');
            IExpression exp;
            foreach(string order in orders)
            {
                if (context.IsOperation(order))
                {
                    exp = new OperationExpression(order);
                }
                else
                {
                    exp = new NumericExpression(order);
                }
                exp.Interpret(context);
            }
            Console.WriteLine("El resultado es: " + context.GetResult());
            Console.ReadKey();
        }
    }
}
