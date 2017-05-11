using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMEF
{
    [Export(typeof(ICalculate))]
    class SimpleCalculator : ICalculate
    {
        [ImportMany]
        IEnumerable<Lazy<IOperation, IOperationMetaData>> operations;
        //Lazy initialisation - Initialisiert erst wenn es gebraucht wird


        public string Calculate(string s)
        {
            int left;
            int right;
            int functionpos = FindOperator(s);

            if (functionpos == -1)
            {
                return "Invalid expression";
            }
            else
            {
                left = int.Parse(s.Substring(0, functionpos));
                right = int.Parse(s.Substring(functionpos+1));
            }

            foreach (var item in operations)
            {
                if (item.Metadata.Operation.Equals(s[functionpos])) {
                    return item.Value.operate(left, right).ToString();
                }
            }
            return "Unknown operation";
        }

        private int FindOperator(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    return i;
                }

            }
            return -1;
        }
    }
}
