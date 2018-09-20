using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;
using GalaSoft.MvvmLight.Command;

namespace SimpleCPUMiner.ViewModel
{
    class AboutViewModel : ViewModelBase
    {
        public RelayCommand<Window> CloseWindowCommand { get; private set; }
        public string Header { get; set; }
        public string Version { get; set; }
        public string AboutText { get; set; }
        public string Contact { get; set; }

        public AboutViewModel()
        {
            Header = "Tu Simple Miner";
            Version = $"Version: {Consts.VersionNumber}";
            AboutText = "Nuestra aplicación es una GUI para xmrig (www.xmrig.com) para ayudar a los usuarios en el uso del minero (TodosUnidos.Com)";
            Contact = $"Contactanos {Consts.AboutContact}";
            CloseWindowCommand = new RelayCommand<Window>(CloseWindow);
        }

        private void CloseWindow(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }
    }
}
