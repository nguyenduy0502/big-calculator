using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BigCaculator
{
    public class InputCheck
    {
        
        public InputCheck()
        {
          
        }

        public bool ChekString(string strInput)
        {
            for (int i = 0; i < strInput.Length - 1; i++)
            {
                if (strInput[i] == '*' && strInput[i + 1] == '/' || strInput[i]=='*' && strInput[i+1]=='*')
                {
                    return false;
                }
                else if (strInput[i]=='/' && strInput[i+1]=='*' || strInput[i]=='/' && strInput[i+1]=='/')
                {
                    return false;
                }
                else if (strInput[i] == '+' && strInput[i + 1] == '/' || strInput[i] == '+' && strInput[i + 1] == '*')
                {
                    return false;
                }
                else if (strInput[i] == '-' && strInput[i + 1] == '/' || strInput[i] == '-' && strInput[i + 1] == '*')
                {
                    return false;
                }
            }
             return true;
        }
                 
        public bool CheckInput(string input)
        {
            string strPatten = @"(cos|sin|tan|cot|\d)";
           
            Regex myRegex=new Regex(strPatten);
          
            if (myRegex.IsMatch(input)==true)
            {
                return true;
            }
           
            else
            {
                return false;
            }
        }

        public bool CheckBracket(string input)
        {
            int iCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    iCount++;
                }
                else if (input[i] ==')')
                {
                    iCount--;
                }
            }
            if (iCount == 0)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
    }
}
