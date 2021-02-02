using System;
using System.Collections.Generic;
using System.Text;

namespace src.Models
{
    public class Deck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
    }
}
