using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frazioni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!Fraction.TryParse(txtAdd.Text, out var f))
            {
                MessageBox.Show("Frazione errata");
            }
            else
            {
                lst.Items.Add(txtAdd.Text);
                txtAdd.Clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lst.SelectedIndex == -1)
            {
                MessageBox.Show("Nessun elemento è stato selezionato");
            }
            else
            {
                lst.Items.RemoveAt(lst.SelectedIndex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lst.Items.Count == 0)
            {
                MessageBox.Show("Nessun elemento è presente nella lista");
            }
            else
            {
                lst.Items.Clear();
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (lst.Items.Count == 0)
            {
                MessageBox.Show("Nessun elemento è presente nella lista");
            }
            else
            {
                Fraction somma = new Fraction(0, 1);
                foreach (var item in lst.Items)
                {
                    somma = somma.Somma((Fraction)item);
                }
                lblSum.Text = somma.ToString();
            }
        }
    }
}
