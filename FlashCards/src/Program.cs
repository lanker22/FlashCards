using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Prism.Events;
using src.Factories;
using src.Models;
using src.Presenters;
using src.Services;
using src.Services.Repos;
using src.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            
            // Configure dependency injection
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IDeckRepo, DeckRepo>();
                    services.AddTransient<ICardRepo, CardRepo>();
                    services.AddTransient<IRepoHelper, RepoHelper>();
                    services.AddTransient<ICardService, CardService>();
                    services.AddSingleton<IMainFormView, MainFormView>();
                    services.AddTransient<IPresenter<MainFormView>, MainFormPresenter<MainFormView>>();
                    services.AddTransient<IPresenter<FlashCardGameView>, FlashCardGamePresenter<FlashCardGameView>>();
                    services.AddTransient<IPresenter<AddDeckView>, AddDeckPresenter<AddDeckView>>();
                    services.AddTransient<IPresenter<EditDeckView>, EditDeckPresenter<EditDeckView>>();
                    services.AddTransient<IPresenter<ExportDecksView>, ExportDecksPresenter<ExportDecksView>>();
                    services.AddTransient<IDeckService, DeckService>();
                    services.AddTransient<ICardService, CardService>();
                    services.AddSingleton<IFormOpener, FormOpener>();
                    services.AddSingleton<IEventAggregator, EventAggregator>();
                    services.AddTransient<IExcelService, ExcelService>();
                    services.AddTransient<IDbFactory>(s => new SqlFactory(ConfigurationManager.ConnectionStrings["FlashCardsDatabaseProduction"].ConnectionString));
                })
                .Build();

            PresenterFactory.SetHost(host);
            var app = ActivatorUtilities.GetServiceOrCreateInstance<IMainFormView>(host.Services);

            Application.Run((Form)app);
        }
    }
}
