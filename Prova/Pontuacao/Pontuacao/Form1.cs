using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace Pontuacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[11, 3];

            string entrada = " ";
            int media, jogadores, pontos;


            for (var i = 0; i < 11; i++)

            {
                for (var j = 0; j < 3; j++)
                {
                    entrada = Interaction.InputBox("Digite o numero jogador " + (i + 1), "Entrada dos pontos" + (j + 1));
                    if (!int.TryParse(entrada, out matriz[i, j]) || matriz[i, j] < 0)
                    {
                        MessageBox.Show("digite um valor inteiro não negativo");

                    }
                    media = matriz[i, j] / 3;
                    pontos = matriz[i, j];




                }
            }
            lbxsaida.Items.Add("Jogador 1: " + "Pontos e Nivel: " + "Pontos e Nivel" + "Pontos e Nivel" + "Media: ");
            lbxsaida.Items.Add("Jogador 2: " + "Pontos e Nivel: " + "Pontos e Nivel" + "Pontos e Nivel" + "Media: ");
            lbxsaida.Items.Add("Jogador 3: " + "Pontos e Nivel: " + "Pontos e Nivel" + "Pontos e Nivel" + "Media: ");
            lbxsaida.Items.Add("Jogador 4: " + "Pontos e Nivel: " + "Pontos e Nivel" + "Pontos e Nivel" + "Media: ");
            lbxsaida.Items.Add("Jogador 5: " + "Pontos e Nivel: " + "Pontos e Nivel" + "Pontos e Nivel" + "Media: ");
            lbxsaida.Items.Add("Jogador 6: " + "Pontos e Nivel: " + "Pontos e Nivel" + "Pontos e Nivel" + "Media: ");
            lbxsaida.Items.Add("Jogador 7: " + "Pontos e Nivel: " + "Pontos e Nivel" + "Pontos e Nivel" + "Media: ");



        }
    } }
