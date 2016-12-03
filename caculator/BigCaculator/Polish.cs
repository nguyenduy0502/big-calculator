using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BigCaculator
{
    public class Polish :InputCheck
       
    {

        private string StringPolish;

        public string GetStringPolish()
        {
            return StringPolish;
        }

        public void SetStringPolish(string StringPolish)
        {
            this.StringPolish = StringPolish;
        }

        public Polish()
        {
            StringPolish = "";
        }

        private struct PolishStruct
        {
            public string StringToken;
            public Type TypeToken;
        }

        private bool IsOperator(Type c)
        {

            bool Temp = true;
            switch (c)
            {
                case Type.Divide:
                case Type.Minus:
                case Type.Plus:
                case Type.Pow:
                case Type.Multiply:
                case Type.Factorial:
                case Type.UnaryMinus:
                    Temp = true;
                    break;
                default:
                    Temp = false;
                    break;
                    

            }
            return Temp;
        }

        private bool IsTrigonometric(Type c)
        {
            bool Temp = true;
            switch (c)
            {
                case  Type.Sin:
                case Type.Cos:
                case Type.Cot:
                case  Type.Tan:
                    Temp = true;
                    break;
                default:
                    Temp = false;
                    break;
                    
            }
            return Temp;


        }

        public void ConvertPolish()
        {
            Stack stack = new Stack();
            

        }
    }
}
