using System;
using System.Collections.Generic;
using System.Text;

namespace src.Models
{
    /// <summary>
    ///     A Deck containing a list of Card objects.
    /// </summary>
    public class Deck
    {
        /// <summary>
        ///     Primary key of the Deck in database.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Name of particular Deck. Does not have to be unique.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     List of Card objects associated with the given Deck. 
        /// </summary>
        public List<Card> Cards { get; set; }
    }
}
