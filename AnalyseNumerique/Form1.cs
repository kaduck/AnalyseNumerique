using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalyseNumerique
{
    public partial class Form1 : Form
    {
        private typeMethode _typeMethode;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDegree_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            int num;
            if (!(sender is TextBox) || !int.TryParse(((TextBox)sender).Text, out num))
            {
                errorProvider1.SetError((Control)sender, "La valeur spécifiée est incorrecte");
                e.Cancel = true;
            }
        }

        private void tbDegree_Validated(object sender, EventArgs e)
        {
            flpEquation.Controls.Clear();
            int num = 0;
            if (sender is TextBox && int.TryParse(((TextBox)sender).Text, out num))
            {
                for(int i=0;i<num+1;i++)
                {
                    EquationControl equa = new EquationControl();
                    equa.Degree = i;
                    flpEquation.Controls.Add(equa);
                }
            }
        }

        private void btCalculer_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double value;
            double precision = 0;
            if (!double.TryParse(tbBorneInferieure.Text, out a) || !double.TryParse(tbBorneSuperieure.Text, out b) || !double.TryParse(tbPrecision.Text,out precision))
                return;
            switch (_typeMethode)
            {
                case typeMethode.Dichotomique:
                    CalculDichotomique(a, b, precision,out value);
                    break;
                case typeMethode.Newton:
                    break;
                case typeMethode.Secante:
                    break;
                default:
                    break;
            }
        }

        private void CalculDichotomique(double a, double b,double precision, out double value)
        {
            int iteration = 0;
            do
            {
                value = 0;
                double equidistant = (a + b) / 2.0;
                foreach (EquationControl equa in flpEquation.Controls)
                {
                    value += equa.CalculEquation(equidistant);
                }
                EcrireLog("Itération : " + iteration + " | La valeur de l'équation pour \"x = " + (a + b) / 2.0 + "\" est de " + value);
                if (value > 0)
                {
                    EcrireLog("Itération : " + iteration + " | La borne supérieure passe de " + b + " à " + equidistant);
                    b = equidistant;
                }
                else
                {
                    EcrireLog("Itération : " + iteration + " | La borne inférieure passe de " + a + " à " + equidistant);
                    a = equidistant;
                }
                iteration++;
                if (iteration > 20)
                {
                    EcrireLog("Trop grand nombre d'itération | Arrét du calcul");
                    return;
                }
            }
            while (value < - precision || value > precision);
            EcrireLog("La solution de cette equation est x = " + (a + b) / 2.0);
            EcrireLog("Nombre d'itération : " + iteration);
        }

        private void EcrireLog(string p)
        {
            tbConsole.Text += p + "\n";
        }

        private void cbMethode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).Text)
            {
                case "Dichotomie":
                    tbHauteurPas.Visible = false;
                    tbNombrePas.Visible = false;
                    lbHauteurPas.Visible = false;
                    lbNombrePas.Visible = false;
                    tbPrecision.Visible = true;
                    lbPrecision.Visible = true;
                    _typeMethode = typeMethode.Dichotomique;
                    break;
                case "Newton":
                    tbHauteurPas.Visible = true;
                    tbNombrePas.Visible = true;
                    lbHauteurPas.Visible = true;
                    lbNombrePas.Visible = true;
                    tbPrecision.Visible = false;
                    lbPrecision.Visible = false;
                    _typeMethode = typeMethode.Newton;
                    break;
                case "Secante":
                    tbHauteurPas.Visible = true;
                    tbNombrePas.Visible = true;
                    lbHauteurPas.Visible = true;
                    lbNombrePas.Visible = true;
                    tbPrecision.Visible = false;
                    lbPrecision.Visible = false;
                    _typeMethode = typeMethode.Secante;
                    break;
                default:
                    errorProvider1.SetError(cbMethode, "Le type de méthode n'est pas reconnu");
                    break;
            }
        }
    }

    enum typeMethode
    {
        Dichotomique,
        Newton,
        Secante
    }
}
