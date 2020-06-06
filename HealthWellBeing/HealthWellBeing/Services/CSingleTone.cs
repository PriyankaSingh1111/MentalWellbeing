using System;
using System.Collections.Generic;
using System.Text;

namespace HealthWellBeing.Services
{
    public sealed class CSingleTone
    {
        private static CSingleTone instance;
        public static List<string> SelectedPart { get; set; }

        public static CSingleTone Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CSingleTone();
                    SelectedPart = new List<string>();
                }
                return instance;
            }
        }
        private CSingleTone()
        {
        }


        public void addwellIdeas(string cart, bool res)
        {
            if (res)
            {
                SelectedPart.Add(cart);
            }
            else
            {
                SelectedPart.Remove(cart);
            }
        }

        public List<string> GetwellIdeas()
        {
            return SelectedPart;
        }
    }

}
