using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using src.Presenters;
using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    /// <summary>
    ///     Instantiates an instance of a Presenter class. Dependency Injection determines which Presenter
    ///     to provide, given a particular View.
    /// </summary>
    public static class PresenterFactory
    {
        private static IHost host;

        /// <summary>
        ///     Instantiates an instance of a Presenter class. Dependency Injection determines which Presenter
        ///     to provide, given a particular View.
        /// </summary>
        /// <typeparam name="TView">The View.</typeparam>
        /// <param name="view">View instance which called the function.</param>
        /// <returns>A Presenter object associated with the View.</returns>
        public static IPresenter<TView> CreateForView<TView>(TView view)
        {
            var presenter = ActivatorUtilities.GetServiceOrCreateInstance<IPresenter<TView>>(host.Services);
            presenter.View = view;
            return presenter;
        }

        public static void SetHost(IHost host)
        {
            PresenterFactory.host = host;
        }
    }
}
