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
    public partial class TextCellPage : ContentPage
    {
        public TextCellPage()
        {
            InitializeComponent();
            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() {Nome="José Ferreira", Cargo= "Diretor Executivo" });
            Lista.Add(new Funcionario() { Nome = "Maria Eloah", Cargo = "Gerente de vendas" });
            Lista.Add(new Funcionario() { Nome = "Felipe Henrique", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Nome = "Elaine Mendonça", Cargo = "Analista de Dados" });
            Lista.Add(new Funcionario() { Nome = "João dos santos", Cargo = "Engenheiro mde Software" });

            ListaFuncionario.ItemsSource = Lista;
        }
    }
}
