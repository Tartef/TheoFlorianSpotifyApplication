using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        async void click(object sender, EventArgs args)
        {
            var ListeCases = new List<BoxView> { FirstCase, SecondCase, ThirdCase, FourthCase, FifthCase, SixthCase, SeventhCase, EighthCase, NinthCase, TenthCase, EleventhCase, TwelfthCase, ThirteenthCase, FourteenthCase, FifteenthCase, SixteenthCase, SeventeenthCase, EightteenthCase, NineteenthCase, TwentythCase };
            for (int i = 0; i < ListeCases.Count; i++)
            {
                if (ListeCases[i].Color == Color.Blue)
                {
                    ListeCases[i].Color = Color.Black;
                }
                else
                {
                    ListeCases[i].Color = Color.Blue;
                }
            }
        }
    }
}