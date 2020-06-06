using System;
using System.Collections.Generic;
using System.Text;
using HealthWellBeing.Models;

namespace HealthWellBeing.ViewModels
{
   public class QuestionnaireViewModel:BaseViewModel
    { 
        public IList<Questionnaire> lstQuestions { get; set; }
    public object SelectedItem { get; set; }
    public QuestionnaireViewModel()
    {
        lstQuestions = new List<Questionnaire>();
        GenerateCardModel();
    }

    private void GenerateCardModel()
    {
        string[] arrNames = {
            "1. I do things slowly","2. I feel sad, blue, and unhappy","3. I feel fatigued","4. I feel nervous, anxious or on edge","5. Feeling bad about yourself",
            "6. Cannot focus on things"
            };

        Random rnd = new Random();

        for (var i = 0; i < arrNames.Length; i++)
        {
                var questions = new Questionnaire()
                {
                    Question = arrNames[i],
                    Qno = i + 1
                
            };
                lstQuestions.Add(questions);
        }
    }
}

}


