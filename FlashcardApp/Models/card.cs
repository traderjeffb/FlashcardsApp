using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashcardApp.Models
{
    public class card
    {
        public int id { get; set; }
        public string front { get; set; }
        public string back { get; set; }
        public string webReference { get; set; }
        public string catagory { get; set; }

        public card()
        {

        }
    }
}

