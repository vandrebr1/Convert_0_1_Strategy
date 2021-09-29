using Convert_0_1_Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_0_1_Strategy.Model
{
    public class Zero : IBit
    {

        public string Valor => "0";

        public string Inverter()
        {
            return "1";
        }
    }
}
