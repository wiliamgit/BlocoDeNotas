using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocoDeNotas
{
    public partial class FormBloco : Form
    {
        public FormBloco()
        {
            InitializeComponent();
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Rtf = String.Empty;
        }

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Rtf = String.Empty;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir Arquivo - Magiqueiro";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Arquivos TXT| *.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader leitor = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = leitor.ReadToEnd();
                leitor.Close();


            }

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar Arquivo";
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "Arquivos TXT | *.txt";

            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter
                    (saveFileDialog1.FileName);
                    sw.Write(richTextBox1.Text);
                    sw.Close(); 
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
