using System;
using System.Collections.Generic;
using System.Text;

namespace HealthWellBeing.Models
{
  public class Questionnaire
    {
        public string Question { get; set; }
        public int Qno { get; set; }


    }
    public class QuestionAnwer
    {
        public int QuestionId { get; set; }
        public int selectedOtion { get; set; }
    }
}
