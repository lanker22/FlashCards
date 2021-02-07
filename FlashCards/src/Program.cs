using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using src.Models;
using src.Services;
using src.Services.Repos;
using src.Views;
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
            // Configure dependency injection
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IDeckRepo, DeckRepo>();
                    services.AddTransient<ICardRepo, CardRepo>();
                    services.AddTransient<IRepoHelper, RepoHelper>();
                    services.AddTransient<ICardService, CardService>();
                    services.AddTransient<IEventAggregator, EventAggregator>();
                    //services.AddTransient<IHomePageView, HomePageView>();
                    //services.AddTransient<IAddDeckView, AddDeckView>();
                    //services.AddTransient<IFlashCardGameView, FlashCardGameView>();
                })
                .Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
