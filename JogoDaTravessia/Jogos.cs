using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaTravessia
{
    class Jogos
    {
        public enum local
        {
            Origem,
            Destino
        }

        public int MaxTransporte;
        public List<Pessoa> Origem;
        public List<Pessoa> Destino;
        public local LocalAtual;

        public Jogos()
        {
            Origem = new List<Pessoa>();
            Destino = new List<Pessoa>();
        }

        public void transportarParaDestino(List<Pessoa> lista)
        {

            if (!validarTransporte(lista))
                return;

            List<Pessoa> OrigemAux = new List<Pessoa>(Origem);
            List<Pessoa> DestinoAux = new List<Pessoa>(Destino);

            //realiza o transporte
            foreach (var pessoa in lista)
            {
                OrigemAux.Remove(pessoa);
                DestinoAux.Add(pessoa);
            }
            //valida se as restrições estão sendo obedecidas apos o transporte;
            if(validarRestricoes(OrigemAux, DestinoAux))
            {
                Origem = OrigemAux;
                Destino = DestinoAux;
                LocalAtual = local.Destino;
            }else
            {
                MessageBox.Show("Movimento não permitido");
            }

        }

        public void transportarParaOrigem(List<Pessoa> lista)
        {

            if (!validarTransporte(lista))
                return;

            List<Pessoa> OrigemAux = new List<Pessoa>(Origem);
            List<Pessoa> DestinoAux = new List<Pessoa>(Destino);

            //realiza o transporte
            foreach (var pessoa in lista)
            {
                OrigemAux.Add(pessoa);
                DestinoAux.Remove(pessoa);
            }
            //valida se as restrições estão sendo obedecidas apos o transporte;
            if (validarRestricoes(OrigemAux, DestinoAux))
            {
                Origem = OrigemAux;
                Destino = DestinoAux;
                LocalAtual = local.Origem;
            }
            else
            {
                MessageBox.Show("Movimento não permitido");
            }

        }

        public bool validarTransporte(List<Pessoa> lista)
        {
            //verifica se foi tem mais pessoas no transporte que o permitido
            if (lista.Count > MaxTransporte)
            {
                MessageBox.Show("Movimento não permitido \n Excedeu a lotação do transporte");
                return false;
            }
            //verifica se existe ao meno uma pessoa no transporte
            if (lista.Count <= 0)
            {
                MessageBox.Show("Movimento não permitido \n Deve haver ao menos uma pessoa no transporte");
                return false;
            }
            //verifica se existe um motorista
            if (lista.Where(pessoa => pessoa.PodeDirigir).ToList().Count <= 0)
            {
                MessageBox.Show("Movimento não permitido \n Deve haver ao menos um motorista no transporte");
                return false;
            }
            if (!NaoPodeFicarSozinhoCom(lista))
            {
                MessageBox.Show("Movimento não permitido");
                return false;
            }
            return true;
        }
        public bool validarRestricoes(List<Pessoa> origem, List<Pessoa> destino)
        {
            if (!NaoPodeFicarSozinhoCom(origem))
                return false;

            if (!NaoPodeFicarSozinhoCom(destino))
                return false;

            if (!AcompanhanteObrigatotio(origem))
                return false;

            if (!AcompanhanteObrigatotio(destino))
                return false;

            return true;
        }

        public bool AcompanhanteObrigatotio(List<Pessoa> lista)
        {
            foreach (var pessoa in lista)
            {
                if (pessoa.DeveAcompanhar.Count > 0)
                {
                    if (!lista.Any(pessoa.DeveAcompanhar.Contains))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool NaoPodeFicarSozinhoCom(List<Pessoa> lista)
        {
            if (lista.Count == 2)
            {
                var pessoa1 = lista[0];
                var pessoa2 = lista[1];
                if (pessoa1.NaoPodeFicarSozinhoCom.Contains(pessoa2))
                    return false;

                if (pessoa2.NaoPodeFicarSozinhoCom.Contains(pessoa1))
                    return false;
            }
            return true;
        }

    }
}
