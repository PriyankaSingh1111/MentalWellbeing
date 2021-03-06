﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace HealthWellBeing.Models
{
    public class User
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Age { get; set; }

        public string LinkURL { get; set; }

        // I assume if color is   
        // Green, then user has vote  
        // Red, then user is below 18  
        public Color HasVote { get; set; }
    }
}
