using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMEF
{
    [Export(typeof(IOperation))]
    [ExportMetadata("Operation", '+')]
    class Add : IOperation
    {
        public int operate(int left, int right)
        {
            return left + right;
        }
    }
}
