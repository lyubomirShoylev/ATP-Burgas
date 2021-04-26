using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ATPCalc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "1";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "2";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "3";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "6";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "9";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "0";
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "+";
        }

        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "-";
        }

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "*";
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "/";
        }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "(";
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += ")";
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            string func = TextBox.Text;
            CalculateInBrackets(func);
        }

        private double CalculateInBrackets(string func)
        {
            int OpenBracket = func.LastIndexOf("(");
            string Buff;
            for(int i = OpenBracket; i<=func.Length;i++)
            {
                Buff[i-OpenBracket]
            }
            int CloseBracket = func.IndexOf(")");

            string CurrentCalculation = func.Substring(OpenBracket+1,CloseBracket-OpenBracket);

            double Result = 0;
            List<string> OMG = new List<string>();

            int start=0, end=0;
            bool flag = false;
            for(int i=0; i < CurrentCalculation.Length; i++)
            {
                if (CurrentCalculation[i] == '+' || CurrentCalculation[i] == '-')
                {
                    if(!flag)
                    {
                        start = CurrentCalculation[i];
                    }
                    else
                    {
                        end = CurrentCalculation[i];
                        break;
                    }
                }
            }

            return 0;
        }
    }
}
