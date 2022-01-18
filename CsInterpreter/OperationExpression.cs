using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsInterpreter
{
    public class OperationExpression:IExpression
    {
        string value;
        public OperationExpression(string exp)
        {
            value = exp;
        }

        public void Interpret(Context context)
        {
            context.SetOperation(value);
        }
    }
}
