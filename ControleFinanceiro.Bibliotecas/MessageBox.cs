using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Bibliotecas
{
    public enum MessageBoxTipo : int { Informativo = 1, PerguntaSimNao, PerguntaNaoSim, Alerta, Erro }

    public class MessageBox
    {
        public static System.Windows.Forms.DialogResult Show(string mensagem, MessageBoxTipo tipo)
        {
            string titulo;
            System.Windows.Forms.MessageBoxIcon icone;
            System.Windows.Forms.MessageBoxButtons botoes;
            System.Windows.Forms.MessageBoxDefaultButton botaoPadrao = System.Windows.Forms.MessageBoxDefaultButton.Button1; 

            switch (tipo)
            {
                case MessageBoxTipo.Erro:
                    icone = System.Windows.Forms.MessageBoxIcon.Error;
                    botoes = System.Windows.Forms.MessageBoxButtons.OK;
                    titulo = "Erro";
                    break;
                case MessageBoxTipo.Alerta:
                    icone = System.Windows.Forms.MessageBoxIcon.Warning;
                    botoes = System.Windows.Forms.MessageBoxButtons.OK;
                    titulo = "Alerta";
                    break;
                case MessageBoxTipo.PerguntaSimNao | MessageBoxTipo.PerguntaNaoSim:
                    icone = System.Windows.Forms.MessageBoxIcon.Question;
                    botoes = System.Windows.Forms.MessageBoxButtons.YesNo;
                    titulo = "Pergunta";
                    if (tipo != MessageBoxTipo.PerguntaSimNao)
                    {
                        botaoPadrao = System.Windows.Forms.MessageBoxDefaultButton.Button2;
                    }
                    break;
                default:
                    icone = System.Windows.Forms.MessageBoxIcon.Information;
                    botoes = System.Windows.Forms.MessageBoxButtons.OK;
                    titulo = "Informativo";
                    break;
            }

            return System.Windows.Forms.MessageBox.Show(
                mensagem,
                System.Windows.Forms.Application.ProductName + " - " + titulo,
                botoes,
                icone,
                botaoPadrao);
        }
    }
}
