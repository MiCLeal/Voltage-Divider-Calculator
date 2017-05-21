using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voltage.divisor.calculator
{
    public class Calc
    {
        private float vin;
        private float r1;
        private float r2;
        // Never used
        private float vout;

        public float Vin { get => vin; set => vin = value; }
        public float R1 { get => r1; set => r1 = value; }
        public float R2 { get => r2; set => r2 = value; }
        public float Vout { get => vout; set => vout = value; }

        public static float DivisionCalc(float vin, float r1, float r2)
        {
            float vout = 0;

            if (vin != 0 && r1 != 0 && r2 != 0)
                return vout = r2 / (r1 + r2) * vin;

            return vout;
        }
    }
}
