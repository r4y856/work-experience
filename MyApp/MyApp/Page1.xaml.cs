using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        void Entry_Completed1(object sender, System.EventArgs e)
        {
            var label = new Label { Text = (sender).ToString() };
            var text = ((Entry)sender).Text;
            Name.Text += (text);
        }
        void Entry_Completed2(object sender, System.EventArgs e)
        {
            var label = new Label { Text = (sender).ToString() };
            var text = ((Entry)sender).Text;
            Grade.Text += (text);
        }
    }
}