using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void PrintInfo(object sender, EventArgs e)
        {
            info1.Text = fname.Text;
            info2.Text = lname.Text;
            info3.Text = pnumber.Text;
            info4.Text = email.Text;
            info5.Text = address.Text;
        }
    }
}
