using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TheApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnCrashButtonClicked(object sender, EventArgs args)
        {
            throw new Exception("Hey! I am not handled by anyone!");
        }
    }
}
