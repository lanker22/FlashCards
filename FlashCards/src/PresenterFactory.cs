using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using src.Presenters;
using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public static class PresenterFactory
    {
        private static IHost host;
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
