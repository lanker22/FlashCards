using src.Models;
using src.Services.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var testCardRepo = new CardRepo();
            var testDeckRepo = new DeckRepo();

            //testDeckRepo.AddNewDeckToDatabase("TestDeck2");
            //var testCard1 = new Card
            //{
            //    Question = "test1",
            //    Answer = "test1"
            //};
            //var testCard2 = new Card
            //{
            //    Question = "test2",
            //    Answer = "test2"
            //};
            //var testCard3 = new Card
            //{
            //    Question = "test3",
            //    Answer = "test3"
            //};
            //var testCard4 = new Card
            //{
            //    Question = "test4",
            //    Answer = "test4"
            //};
            //var testCard5 = new Card
            //{
            //    Question = "test5",
            //    Answer = "test5"
            //};

            //var testCardList1 = new List<Card>()
            //{
            //    testCard1,
            //    testCard2,
            //};

            //var testCardList2 = new List<Card>()
            //{
            //    testCard3,
            //    testCard4,
            //    testCard5
            //};



            //testCardRepo.AddCardsToDatabase(testCardList1, 1);

            //testCardRepo.AddCardsToDatabase(testCardList2, 2);

            var deck = testDeckRepo.GetDeck(2);


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
