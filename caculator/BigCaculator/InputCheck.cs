using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BigCaculator
{
    public class InputCheck
    {
        private string InputString = "";
        public InputCheck()
        {
            InputString = string.Empty;

        }

        public string GetInputString()
        {
            return InputString;
        }

        public void SetInputString(string InputString)
        {
            this.InputString = InputString;
        }
     
        public InputCheck(String Input)
        {

            this.InputString = Input;
        }

        public bool CheckBracket(string StringInput)
        {
            int Count = 0;

            for (int i = 0; i < StringInput.Length; i++)
            {
                if (StringInput[i] == '(')
                {
                    Count++;
                }
                else if(StringInput[i]==')')
                {
                    Count--;
                }
            }
            if (Count == 0)
            {
                return true;

            }
            else
            {
                return false;
            }


        }
        public bool CheckString(string StringInput)
        {

            bool test = false;
            string PattenString = @"^pi|cot|tan|cos|sin|sqrt";
            string PattenChar = @"(?<char>[+\-*/^!()])";
            string PattenNumber = @"(?<number>\d+(\.\d+)?)";       
            Regex myRegexString=new Regex(PattenString);
            Regex mRegexChar=new Regex(PattenChar);
            Regex myRegexNumber=new Regex(PattenNumber);

            if (myRegexString.IsMatch(StringInput) == true)
            {
                test = true;
            }
            else if (mRegexChar.IsMatch(StringInput) == true)
            {
                test = true;
            }
            else if (myRegexNumber.IsMatch(StringInput) == true)
            {

                test = true;
            }
            return test;

        }

        public void NoNormalString(string StringInput)
        {

            for (int i = 0; i < StringInput.Length; i++)
            {

                if (StringInput[i] == '-' && StringInput[i + 1] == '+')
                {
                    StringInput = StringInput.Remove(i + 1, 1);

                }
                else if (StringInput[i] == '+' && StringInput[i + 1] == '-')
                {
                    StringInput = StringInput.Remove(i , 1);


                }
                else if (StringInput[i] == '-' && StringInput[i + 1] == '-')
                {
                    StringInput = StringInput.Remove(i, 2);
                    StringInput = StringInput.Insert(i, "+");

                }
                else if (StringInput[i] == '(' && StringInput[i + 1] == '-')
                {
                    StringInput = StringInput.Remove(i + 1, 1);
                    StringInput = StringInput.Insert(i + 1, "~");
                }
                else if (StringInput[i] == '*' && StringInput[i + 1] == '-')
                {
                    StringInput = StringInput.Remove(i + 1, 1);
                    StringInput = StringInput.Insert(i + 1, "~");
                }
                else if (StringInput[i] == '/' && StringInput[i + 1] == '-')
                {
                    StringInput = StringInput.Remove(i + 1, 1);
                    StringInput = StringInput.Insert(i + 1, "~");
                }
                else if (StringInput[i] == '^' && StringInput[i + 1] == '-')
                {
                    StringInput = StringInput.Remove(i + 1, 1);
                    StringInput = StringInput.Insert(i + 1, "~");
                }
                else if (StringInput[0] == '-')
                {
                    StringInput = StringInput.Remove(0, 1);
                    StringInput = StringInput.Insert(0, "~");
                }


                this.SetInputString(StringInput);



            }
        }



    }
}





