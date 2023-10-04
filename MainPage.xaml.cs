namespace Tarea1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Sumar_Clicked(object sender, EventArgs e)
        {

            FlyoutPageItem item = new FlyoutPageItem()
            {
                num1 = 5,
                num2 = 6

            };

            await Navigation.PushAsync(new Resultado()
            {
                BindingContext = item
            });
        }

        private void Restar_Clicked(object sender, EventArgs e)
        {

        }

        private void Dividir_Clicked(object sender, EventArgs e)
        {

        }

        private void Multiplicar_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}