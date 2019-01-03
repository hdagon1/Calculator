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

        bool separateButEqual = false;

        private void Button_Pressed(object sender, EventArgs e)
        {
            Button b = (sender as Button);

            int output;

            if (b.Text == "1") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "2") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "3") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "4") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "1") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "1") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "1") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "1") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "1") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "1") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "1") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "1") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "1") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "1") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "1") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "1") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
            if (b.Text == "1") { if (separateButEqual) { Input.Text = ""; } Input.Text += "1"; }
        }

        private void Operator_Pressed(object sender, EventArgs e)
        {
            Button u = (sender as Button);

        }
    }
}
