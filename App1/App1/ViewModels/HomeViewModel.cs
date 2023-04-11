using Xamarin.Forms;

namespace App1.ViewModels
{
    public class HomeViewModel: BaseViewModel
    {
        Color _oddCaseColor;
        Color _evenCaseColor;
        
        public HomeViewModel()
        {
            OddCaseColor = Color.FromHex("#000000");
            EvenCaseColor = Color.FromHex("#0000FF");
        }
        
        public Color OddCaseColor
        {
            get { return GetValue<Color>(); }
            set { SetValue(value); }
        }
        
        public Color EvenCaseColor
        {
            get { return GetValue<Color>(); }
            set { SetValue(value); }
        }
        
        
        public void InvertColor()
        {
            Color temp = OddCaseColor;
            OddCaseColor = EvenCaseColor;
            EvenCaseColor = temp;
        }
    }
}