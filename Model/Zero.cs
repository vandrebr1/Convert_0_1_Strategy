using Convert_0_1_Strategy.Interface;

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
