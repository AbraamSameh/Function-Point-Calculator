using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Point_Calculator
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


    //Function_Point_Calculator_Class contains Variables and Calculation Function
    class Function_Point_Calculator_Class
    {
        public double UFP;
        public int DI;
        public double TCF;
        public double FP;
        public double LOC;
        
        List<Parameter> FP_Parameters = new List<Parameter>();
        List<int> DI_Attributes = new List<int>();

        public bool Check_FP_Parameters_Empty()
        {
            return (FP_Parameters.Count == 0);
        }

        public void Add_FP_Parameter(double count,int weight)
        {
            FP_Parameters.Add(new Parameter(count, weight));
        }

        public double Calculate_UFP_Value()
        {
            UFP = 0;
            foreach(Parameter t in FP_Parameters)
            {
                UFP += t.Get_Parameter_Value();
            }
            return UFP;
        }

        public void Add_DI_Attribute(int value)
        {
            DI_Attributes.Add(value);
        }

        public void Calculate_DI_Value()
        {
            DI = 0;
            foreach (int t in DI_Attributes )
            {
                DI += t;
            }
        }

        public double Calculate_TCF_Value()
        {
            TCF = 0.65 + (0.01 * DI);
            return TCF;
        }

        public Double Calculate_FP_Value()
        {
            FP = UFP * TCF;
            return FP;
        }

        public Double Calculate_LOC_Value(int AVC)
        {
            LOC = AVC * FP;
            return LOC;
        }

    }
}
