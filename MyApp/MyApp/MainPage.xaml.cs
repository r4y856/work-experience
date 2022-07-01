using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyApp
{
   
    
    public partial class MainPage : ContentPage
    {
    
        public MainPage()
        {
            InitializeComponent();
        }


        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            var newPage = new Page1();
            await Navigation.PushAsync(newPage);
        }
        
     



        int count = 0;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }
        void Entry_Completed(object sender, System.EventArgs e)
        {
            var label = new Label { Text = (sender).ToString() };
            var text = ((Entry)sender).Text;
            TeacherNameLabel.Text = ("Welcome, " + text);    
        }
    }
}
