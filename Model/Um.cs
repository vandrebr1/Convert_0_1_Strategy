using Convert_0_1_Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_0_1_Strategy.Model
{
    public class Um : IBit
    {
        public string Valor => "1";

        public string Inverter()
        {
            return "0";
        }
    }
}
