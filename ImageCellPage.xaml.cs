using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Cell.Modelo;

namespace App1_Cell.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();
            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Foto= "José.png",Cargo = "Diretor Executivo",
                Nome = "José Ferreira Stainer"});
            Lista.Add(new Funcionario() { Foto = "Maria.png",Cargo = "Gerente de vendas",
                Nome = "Maria Eloah Borges" });
            Lista.Add(new Funcionario() { Foto = "Felipe.png",Cargo = "Gerente de Marketing",
                Nome = "Felipe Henrique dos santos" });
            Lista.Add(new Funcionario() { Foto = "Elaine.png",Cargo = "Analista de Dados",
                Nome = "Elaine Mendonza Gutierrez" });
            Lista.Add(new Funcionario() { Foto = "João.png",Cargo = "Engenheiro de Software",
                Nome = "João Pedro Fernadez" });

            ListaFuncionario.ItemsSource = Lista;
        }
    }
}
