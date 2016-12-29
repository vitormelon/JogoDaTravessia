using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaTravessia
{
    public partial class Jogo : Form
    {
        Jogos jogoAtual;
        public Jogo()
        {
            InitializeComponent();
            inicializaJogoCodeITAirlines();
            atualizaListaDePessoas();
            atualizaBotaoTransporte();

        }
        public void inicializaJogoCodeITAirlines()
        {
            jogoAtual = new Jogos();

            jogoAtual.LocalAtual = Jogos.local.Origem;
            //Transporta duas pessoas por vez;
            jogoAtual.MaxTransporte = 2;

            //Tripulação Técnica
            var piloto = new Pessoa("Piloto", true);
            var oficial1 = new Pessoa("Oficial 1", false);
            var oficial2 = new Pessoa("Oficial 2", false);

            //Tripulação Cabine
            var chefeDeServiço = new Pessoa("Chefe de Serviço", true);
            var comissaria1 = new Pessoa("Comissária 1", false);
            var comissaria2 = new Pessoa("Comissária 2", false);

            //Passageiros
            var policial = new Pessoa("Policial", true);
            var presidiario = new Pessoa("Presidiário", false);

            //Restriçoes
            chefeDeServiço.NaoPodeFicarSozinhoCom.Add(oficial1);
            chefeDeServiço.NaoPodeFicarSozinhoCom.Add(oficial2);

            piloto.NaoPodeFicarSozinhoCom.Add(comissaria1);
            piloto.NaoPodeFicarSozinhoCom.Add(comissaria2);

            presidiario.DeveAcompanhar.Add(policial);

            //Cenário inicial
            jogoAtual.Origem.Add(piloto);
            jogoAtual.Origem.Add(oficial1);
            jogoAtual.Origem.Add(oficial2);
            jogoAtual.Origem.Add(chefeDeServiço);
            jogoAtual.Origem.Add(comissaria1);
            jogoAtual.Origem.Add(comissaria2);
            jogoAtual.Origem.Add(policial);
            jogoAtual.Origem.Add(presidiario);
        }

        public void atualizaListaDePessoas()
        {
            if (jogoAtual.Origem.Count == 0)
            {
                MessageBox.Show("Fim de Jogo");
                inicializaJogoCodeITAirlines();
            }
            listaDestino.Items.Clear();
            listaOrigem.Items.Clear();
            foreach (var pessoa in jogoAtual.Origem)
            {
                listaOrigem.Items.Add(pessoa);
            }

            foreach (var pessoa in jogoAtual.Destino)
            {
                listaDestino.Items.Add(pessoa);
            }
        }
        public void atualizaBotaoTransporte()
        {
            if(jogoAtual.LocalAtual == Jogos.local.Origem)
            {
                transportaParaDestino.Visible = true;
                transportaParaOrigem.Visible = false;
                listaDestino.SelectionMode = SelectionMode.None;
                listaOrigem.SelectionMode = SelectionMode.One;

            }
            else
            {
                transportaParaDestino.Visible = false;
                transportaParaOrigem.Visible = true;
                listaOrigem.SelectionMode = SelectionMode.None;
                listaDestino.SelectionMode = SelectionMode.One;
            }
        }

        private void transportaParaDestino_Click(object sender, EventArgs e)
        {
            var selecionados = new List<Pessoa>();
            foreach (Pessoa item in listaOrigem.CheckedItems)
            {
                selecionados.Add(item);
            }
            jogoAtual.transportarParaDestino(selecionados);
            atualizaListaDePessoas();
            atualizaBotaoTransporte();
        }

        private void transportaParaOrigem_Click(object sender, EventArgs e)
        {
            var selecionados = new List<Pessoa>();
            foreach (Pessoa item in listaDestino.CheckedItems)
            {
                selecionados.Add(item);
            }
            jogoAtual.transportarParaOrigem(selecionados);
            atualizaListaDePessoas();
            atualizaBotaoTransporte();
        }
    }

    
}
