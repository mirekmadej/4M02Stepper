namespace _4M02Stepper
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void onStepperChanged(object sender, EventArgs e)
        {
            lblNapis.FontSize = stStepper1.Value;
            lblRozmiar.Text = $"Rozmiar czcionki: {stStepper1.Value}";
        }
    }

}
