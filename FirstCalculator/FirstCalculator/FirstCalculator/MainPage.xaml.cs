using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstCalculator
{
    public partial class MainPage : ContentPage
    {
        private double result = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            Button b = (sender as Button);
            //for num press, Multiply by 10, add num
            //for operator press, result = input, input = 0
            int input = 0;

            
        }

        private void Operator_Pressed(object sender, EventArgs e)
        {
            Button u = (sender as Button);

        }
    }
}
