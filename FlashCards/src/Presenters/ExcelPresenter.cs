using src.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace src.Presenters
{
    class ExcelPresenter
    {
        private readonly IDeckService _deckService;

        public ExcelPresenter(IDeckService deckService)
        {
            _deckService = deckService;
        }


    }
}
