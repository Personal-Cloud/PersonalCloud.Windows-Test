﻿using System;

using NSPersonalCloud.WindowsContract;

namespace NSPersonalCloud.WindowsConfigurator.IPC
{
    internal class PopupPresenter : IPopupPresenter
    {
        public void ShowAlert(string title, string message)
        {
        }

        public bool ShowAlert(string title, string message, string positiveAction, string neutralAction, bool switchPositions = false)
        {
            throw new NotImplementedException();
        }

        public void ShowFatalAlert(string title, string message)
        {
            throw new NotImplementedException();
        }
    }
}
