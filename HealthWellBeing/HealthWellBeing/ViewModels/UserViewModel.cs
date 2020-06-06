using HealthWellBeing.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace HealthWellBeing.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public IList<User> lstUsers { get; set; }
        public object SelectedItem { get; set; }
        public UserViewModel()
        {
            lstUsers = new List<User>();
            GenerateCardModel();
        }

        private void GenerateCardModel()
        {
            string[] arrNames = {
                "David", "John", "Paul", "Mark", "James",
                "Andrew", "Scott", "Steven", "Robert", "Stephen",
                "William", "Craig", "Michael", "Stuart", "Christopher",
                "Alan", "Colin", "Brian", "Kevin"
            };

            Random rnd = new Random();

            var user = new User()
            {
                Name = "Learn a new skill",
                ID = "skill",
                Age = "Retraining or upgrading your skills",
                LinkURL = "https://mentalwellbeing.initiatives.qld.gov.au/activities",
                HasVote = Color.Green,
            };


            lstUsers.Add(user);

            var user1 = new User()
            {
                Name = "Give yoga a go",
                ID = "yoga",
                Age = "Search 'Yoga' on YouTube",
                LinkURL = "https://www.youtube.com/results?search_query=yoga",
                HasVote = Color.Green,
            };


            lstUsers.Add(user1);


            var user2 = new User()
            {
                Name = "Create a consistent bedtime routine",
                Age = "10 steps to better sleep",
                LinkURL = "https://www.health.qld.gov.au/news-events/news/10-steps-to-better-sleep",
                HasVote = Color.Green,
            };


            lstUsers.Add(user2);

            var user3 = new User()
            {
                Name = "Take on a DIY project",
                Age = "YouTube",
                LinkURL = "https://www.youtube.com/",
                HasVote = Color.Green,
            };


            lstUsers.Add(user3);


            var user4 = new User()
            {
                Name = "Try progressive muscle relaxation",
                Age = "Beyond Blue's relaxation exercises",
                LinkURL = "https://www.beyondblue.org.au/get-support/staying-well/relaxation-exercises",
                HasVote = Color.Green,
            };


            lstUsers.Add(user4);

            var user5 = new User()
            {
                Name = "Get creative in the kitchen",
                Age = "Healthy recipes",
                LinkURL = "https://www.healthier.qld.gov.au/food/recipes/",
                HasVote = Color.Green,
            };

            lstUsers.Add(user5);

            var user6 = new User()
            {
                Name = "Listen to a podcast",
                Age = "My amazing body podcast",
                LinkURL = "https://www.health.qld.gov.au/news-events/podcast",
                HasVote = Color.Green,
            };


            lstUsers.Add(user6);

            var user7 = new User()
            {
                Name = "Try deep breathing",
                Age = "Xhalr website",
                LinkURL = "https://xhalr.com/",
                HasVote = Color.Green,
            };


            lstUsers.Add(user7);

            var user8 = new User()
            {
                Name = "Grow your own fruit and veg",
                Age = "Get started with gardening",
                LinkURL = "https://www.healthier.qld.gov.au/guide/get-started-with-gardening/",
                HasVote = Color.Green,
            };


            lstUsers.Add(user8);

            var user9 = new User()
            {
                Name = "Join a free exercise class",
                Age = "Exercises",
                LinkURL = "https://www.healthier.qld.gov.au/fitness/exercises/",
                HasVote = Color.Green,
            };
            lstUsers.Add(user9);

            var user10 = new User()
            {
                Name = "Read something different",
                Age = "State Library of Queensland's Ebooks",
                LinkURL = "https://www.slq.qld.gov.au/research-collections/information-collections/eresources/eBooks",
                HasVote = Color.Green,
            };

            lstUsers.Add(user10);

            var user11 = new User()
            {
                Name = "Drink 2 litres of water a day",
                Age = "5 ways to make water more colourful",
                LinkURL = "https://www.healthier.qld.gov.au/guide/5-ways-to-make-water-more-colourful/",
                HasVote = Color.Green,
            };

            lstUsers.Add(user11);


            for (var i = 0; i < arrNames.Length; i++)
            {
                //var age = rnd.Next(10, 30);
                //var user = new User()
                //{
                //    Name = arrNames[i],
                //    Age = age,
                //    HasVote = age % 2 == 0 ? Color.Green : Color.Red,
                //};
                //lstUsers.Add(user);
            }
        }

    }
}

