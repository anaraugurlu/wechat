using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wechat
{
    class AnswersAndQuestiond
    {
      public  static string Answers(string answer)
        {
            if (answer == "salam")
            {
                return "salam";
            }
            else if (answer=="necesen?"|| answer == "necesen")
            {
                return "yaxshi sen?";
            }
            else if(answer=="ne var ne yox?"|| answer == "ne var ne yox")
            {
                return "salamatchiliqdi";
            }
            else if(answer == "sagol")
            {
                return "sagol";
            }
            return " ";
        }
    }
}
