namespace ContatosApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    //Método executado no evento Clicked do botão
    private async void BtnIniciarAplicacao_Clicked(object sender, EventArgs e)
    {
        //Exibindo mensagem de confirmação para o usuário
        var result = await DisplayAlert(
        "Seja bem vindo!",
        "Deseja inicializar o seu aplicativo?",
        "OK", "CANCELAR");

        //verificando se o usuário confirmou a mensagem (OK)
        if (result) BtnIniciarAplicacao.IsVisible = false;
    }
}