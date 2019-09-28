using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro.Exceptions
{
    class TabulerioException : Exception
    {
        public TabulerioException(string msg) : base(msg) { }
    }
}
