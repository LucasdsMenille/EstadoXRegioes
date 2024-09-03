using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadoXRegioes
{
    public partial class Form1 : Form
    {
        List<string> Norte = new List<string> { "AC", "AP", "AM", "PA", "RO", "RR", "TO" };
        List<string> Nordeste = new List<string> { "AL", "BA", "CE", "MA", "PB", "PE", "PI", "RN", "SE" };
        List<string> Sudeste = new List<string> { "ES", "MG", "SP", "RJ" };
        List<string> CentroOeste = new List<string> { "DF", "GO", "MS", "MT" };
        List<string> Sul = new List<string> { "PR", "SC", "RS" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void removeFromAll_Click(object sender, EventArgs e)
        {
            string estadoText = cbxTodos.SelectedItem.ToString();

            if(Norte.Contains(estadoText))
            {
                cbxNorte.Items.Add(estadoText);
                cbxTodos.Items.Remove(estadoText);
            }

            if (Nordeste.Contains(estadoText))
            {
                cbxNordeste.Items.Add(estadoText);
                cbxTodos.Items.Remove(estadoText);
            }

            if (Sudeste.Contains(estadoText))
            {
                cbxSudeste.Items.Add(estadoText);
                cbxTodos.Items.Remove(estadoText);
            }

            if (CentroOeste.Contains(estadoText))
            {
                cbxCentroOeste.Items.Add(estadoText);
                cbxTodos.Items.Remove(estadoText);
            }

            if (Sul.Contains(estadoText))
            {
                cbxSul.Items.Add(estadoText);
                cbxTodos.Items.Remove(estadoText);
            }
        }

        private void removeFromNorte_Click(object sender, EventArgs e)
        {
            string estadoText = cbxNorte.SelectedItem.ToString();

            cbxNorte.Items.Remove(estadoText);
            cbxTodos.Items.Add(estadoText);
        }

        private void removeFromNordeste_Click(object sender, EventArgs e)
        {
            string estadoText = cbxNordeste.SelectedItem.ToString();

            cbxNordeste.Items.Remove(estadoText);
            cbxTodos.Items.Add(estadoText);
        }

        private void removeFromSudeste_Click(object sender, EventArgs e)
        {
            string estadoText = cbxSudeste.SelectedItem.ToString();

            cbxSudeste.Items.Remove(estadoText);
            cbxTodos.Items.Add(estadoText);
        }

        private void removeFromCentroOeste_Click(object sender, EventArgs e)
        {
            string estadoText = cbxCentroOeste.SelectedItem.ToString();

            cbxCentroOeste.Items.Remove(estadoText);
            cbxTodos.Items.Add(estadoText);
        }

        private void removeFromSul_Click(object sender, EventArgs e)
        {
            string estadoText = cbxSul.SelectedItem.ToString();

            cbxSul.Items.Remove(estadoText);
            cbxTodos.Items.Add(estadoText);
        }
    }
}
