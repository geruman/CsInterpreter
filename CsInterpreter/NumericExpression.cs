using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsInterpreter
{
    public class NumericExpression:IExpression
    {
        string value;
        public NumericExpression(string exp)
        {
            value = exp;
        }

        public void Interpret(Context context)
        {
            context.SetNumber(context.GetInteger(value));
            context.Calculate();
        }
    }
}
