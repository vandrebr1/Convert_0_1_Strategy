using Convert_0_1_Strategy.Interface;
using Convert_0_1_Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_0_1_Strategy.Factory
{
    public static class BitFactory
    {
       public static IBit Of(char Valor)
        {
            if (Valor.Equals('0'))
            {
                return new Zero();
            }

            if (Valor.Equals('1'))
            {
                return new Um();
            }

            return null;
        }
    }
}
