using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Frection
{
    class Drob
    {
        private double num;
        private double denom;
        private double result;

        public double Num { get => num; private set => num = value; }
        public double Denom { get => denom; private set => denom = value; }


        public Drob(double num, double denum)
        {
            Num = num;
            Denom = denum;
            result = Math.Round(num / denum,2);
        }

        public void Exponentiation(double num)
        {
            num = Math.Pow(num, num);
            Denom = Math.Pow(Denom, num);
        }

        public static bool operator ==(Drob temp1, Drob temp2)
        {
            return temp1.result.Equals(temp2.result);
        }

        public static bool operator !=(Drob temp1, Drob temp2)
        {
            return !temp1.result.Equals(temp2.result);
        }

        public static bool operator >(Drob temp1, Drob temp2)
        {
            return temp1.result > temp2.result;
        }

        public static bool operator <(Drob temp1, Drob temp2)
        {
            return temp1.result < temp2.result;
        }

        public static bool operator >=(Drob temp1, Drob temp2)
        {
            return temp1.result >= temp2.result;
        }

        public static bool operator <=(Drob temp1, Drob temp2)
        {
            return temp1.result <= temp2.result;
        }

        public static Drob operator +(Drob temp1, Drob temp2)
        {
            return new Drob(temp1.num * temp2.Denom + temp1.Denom * temp2.num, temp1.Denom * temp2.Denom);
        }

        public static Drob operator -(Drob temp1, Drob temp2)
        {
            return new Drob(temp1.num * temp2.Denom - temp1.Denom * temp2.num, temp1.Denom * temp2.Denom);
        }

        public static Drob operator *(Drob temp1, Drob temp2)
        {
            return new Drob(temp1.num * temp2.num, temp1.Denom * temp2.Denom);
        }

        public static Drob operator /(Drob temp1, Drob temp2)
        {
            return new Drob(temp1.num * temp2.Denom, temp1.Denom * temp2.num);
        }

        public static Drob operator ^(Drob temp1, double x)
        {
            return new Drob(Math.Pow(temp1.num, x), Math.Pow(temp1.Denom, x));
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", num, Denom);
        }

        public override bool Equals(object obj)
        {
            return obj is Drob Drob &&
                   num == Drob.num &&
                   Denom == Drob.Denom &&
                   result == Drob.result;
        }

        public override int GetHashCode()
        {
            int hashCode = 471222432;
            hashCode = hashCode * -1521134295 + num.GetHashCode();
            hashCode = hashCode * -1521134295 + Denom.GetHashCode();
            hashCode = hashCode * -1521134295 + result.GetHashCode();

            return hashCode;
        }

        public static Drob Down(Drob drob)
        {
            for (int j = 0; j < 20; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (drob.Num % i == 0 && drob.Denom % i == 0)
                    {
                        drob.Num /= i;
                        drob.Denom /= i;
                    }
                }
            }
            
            return drob;
        } 
    }
}
