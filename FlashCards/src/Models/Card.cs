using System;
using System.Collections.Generic;
using System.Text;

namespace src.Models
{
    /// <summary>
    ///     Represents a FlashCard with a Question and Answer string.
    /// </summary>
    public class Card
    {
        /// <summary>
        ///     Question string. This is first seen by the User.
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        ///     Answer string. This is revealed after User first sees the Question.
        /// </summary>
        public string Answer { get; set; }
    }
}
