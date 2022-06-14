using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pferramentas
{
    public partial class Form1 : Form
    {
        public static SqlConnection conexao; 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroDeFerramentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmForramenta"];

            if (fc != null)
                fc.Close();

            FrnFerramenta frm1 = new FrnFerramenta();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trabalho desenvolvido por Guilherme Sandroni Dias, na instituição Fatec Sorocaba sob as observações e orientações da professora Denilce");
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
 {
// aqui a conexão vai depende da sua máquina da escola ou particular
     conexao = new SqlConnection("Data Source=APOLO;Initial Catalog=LP2;User ID=BD2121040;Password=Fatecsandroni01");
 conexao.Open();
 }
 catch (SqlException ex)
 {
 MessageBox.Show("Erro de banco de dados =/" + ex.Message);
 }
 catch (Exception ex)
 {
 MessageBox.Show("Outros Erros =/" + ex.Message);
 } 
        }
    }
}
