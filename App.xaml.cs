using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        { 
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é o nome dado ao estadoda água em forma de gelo"
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
