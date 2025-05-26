namespace MauiApp1jogodavelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
   

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;
            btn.Text = vez;

            /*identificar vitória imediatamente */
            if (btn10.Text == vez && btn11.Text == vez && btn12.Text == vez) 
            {
                DisplayAlert("Parabéns!", $"Vitoria do {vez}!", "OK");
                Zerar();
                return; 
            }
            if (btn10.Text == vez && btn20.Text == vez && btn30.Text == vez) 
            {
                DisplayAlert("Parabéns!", $"Vitoria do {vez}!", "OK");
                Zerar();
                return;
            }
            if (btn10.Text == vez && btn21.Text == vez && btn32.Text == vez) 
            {
                DisplayAlert("Parabéns!", $"Vitoria do {vez}!", "OK");
                Zerar();
                return;
            }
            if (btn12.Text == vez && btn21.Text == vez && btn30.Text == vez) 
            {
                DisplayAlert("Parabéns!", $"Vitoria do {vez}!", "OK");
                Zerar();
                return;
            }
            if (btn20.Text == vez && btn21.Text == vez && btn22.Text == vez) 
            {
                DisplayAlert("Parabéns!", $"Vitoria do {vez}!", "OK");
                Zerar();
                return;
            }
            if (btn30.Text == vez && btn31.Text == vez && btn32.Text == vez) 
            {
                DisplayAlert("Parabéns!", $"Vitoria do {vez}!", "OK");
                Zerar();
                return;
            }
            if (btn11.Text == vez && btn21.Text == vez && btn31.Text == vez) 
            {
                DisplayAlert("Parabéns!", $"Vitoria do {vez}!", "OK");
                Zerar();
                return;
            }
            if (btn12.Text == vez && btn22.Text == vez && btn32.Text == vez) 
            {
                DisplayAlert("Parabéns!", $"Vitoria do {vez}!", "OK");
                Zerar();
                return;
            }


            /*Verificar empate*/
            if (btn10.IsEnabled == false && btn11.IsEnabled == false && btn12.IsEnabled == false &&
                btn20.IsEnabled == false && btn21.IsEnabled == false && btn22.IsEnabled == false &&
                btn30.IsEnabled == false && btn31.IsEnabled == false && btn32.IsEnabled == false
               )
            {
                DisplayAlert("Empate", "Ninguém ganhou!, Jogue Novamente", "OK");
                Zerar();
                return;
            }

            /* Alternar vez somente se ninguém venceu*/
            vez = vez == "X" ? "O" : "X";
                        
        } // Fecha método
             
        void Zerar() 
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";


            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            vez = "X"; /* Reiniciar vez do jogador*/
        }
        
    } // /Fecha classe

} // Fecha o Namespace
