using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Point_Calculator.Classes
{

    // Function Point Parameter Class contains the weight of the given type and the count
    class Parameter
    {
        public double count;
        public int weight;

        public Parameter(double count, int weight)
        {
            this.count = count;
            this.weight = weight;
        }

        public double Get_Parameter_Value()
        {
            return count * weight;
        }
    }
}
