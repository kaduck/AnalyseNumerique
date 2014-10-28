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

        /// <summary>
        /// Test    
        /// </summary>
        /// <param name="a">test</param>
        /// <param name="b"></param>
        /// <param name="precision"></param>
        /// <param name="value">zdgyzgzquygduyq</param>
        private void CalculDichotomique(double a, double b,double precision, double value)
        {
            value = CalculFonction(a) * CalculFonction(b);
            if (CalculFonction(a) * CalculFonction(b)>0)
            {
                errorProvider1.SetError(tbBorneSuperieure, "Les bornes définies n'encadre pas la solution");
                return;
            }
            value = CalculFonction(a);
            if (value > -precision && value < precision)
            {
                EcrireLog("La solution de cette equation est x = "+a);
                return;
            }
            value = CalculFonction(b);
            if (value > -precision && value < precision)
            {
                EcrireLog("La solution de cette equation est x = "+b);
                return;
            }
            int iteration = 0;
            do
            {
                value = 0;
                double equidistant = (a + b) / 2.0;
                value = CalculFonction(equidistant);
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
                if (iteration > 20000)
                {
                    EcrireLog("Trop grand nombre d'itération | Arrét du calcul");
                    return;
                }
            }
            while (value < - precision || value > precision);
            EcrireLog("La solution de cette equation est x = " + (a + b) / 2.0);
        }

        private double CalculFonction(double a)
        {
            double value = 0;
            foreach (EquationControl equa in flpEquation.Controls)
            {
                value += equa.CalculEquation(a);
            }
            return value;
        }

        private double CalculDerive(double a)
        {
            double value = 0;
            foreach (EquationControl equa in flpEquation.Controls)
            {
                value += equa.CalculDerive(a);
            }
            return value;
        }

        private void CalculNewton(double a,double b,double precision,double value)
        {
            double pointFixe = 0;
            double x = 0;
            if (CalculFonction(a) * CalculFonction(b) > 0)
            {
                errorProvider1.SetError(tbBorneSuperieure, "Les bornes définies n'encadre pas la solution");
                return;
            }
            value = CalculFonction(a);
            if (value > -precision && value < precision)
            {
                EcrireLog("La solution de cette equation est x = " + a);
                tbResultat.Text = a.ToString();
                return;
            }
            value = CalculFonction(b);
            if (value > -precision && value < precision)
            {
                EcrireLog("La solution de cette equation est x = " + b);
                tbResultat.Text = a.ToString();
                return;
            }
            do
            {
                x = a;
                value = CalculFonction(a);
                pointFixe = 1/CalculDerive(a);
                a = a - pointFixe * value;
                if (CalculFonction(a) < precision && CalculFonction(a) > -precision)
                {
                    EcrireLog("La solution de cette equation est x = " + a);
                    tbResultat.Text = a.ToString();
                    return;
                }
            }
            while (Math.Abs(a-x)>precision);
            x = a;
            EcrireLog("La solution de cette equation est x = " + a);
            tbResultat.Text = a.ToString();
        }

        private void CalculSecante(double a, double b, double precision, double value)
        {
            double c=0;
            double d=0;
            double pente=0;
            if (CalculFonction(a) * CalculFonction(b) > 0)
            {
                errorProvider1.SetError(tbBorneSuperieure, "Les bornes définies n'encadre pas la solution");
                return;
            }
            value = CalculFonction(a);
            if (value > -precision && value < precision)
            {
                EcrireLog("La solution de cette equation est x = " + a);
                tbResultat.Text = a.ToString();
                return;
            }
            value = CalculFonction(b);
            if (value > -precision && value < precision)
            {
                EcrireLog("La solution de cette equation est x = " + b);
                tbResultat.Text = a.ToString();
                return;
            }
            do
            {
                c = CalculFonction(a);
                d = CalculFonction(b);
                pente = (a - b) / (c - d);
                a = b;
                b = b - pente * d;
                if (CalculFonction(b) < precision && CalculFonction(b) > -precision)
                {
                    EcrireLog("La solution de cette equation est x = " + b);
                    tbResultat.Text = b.ToString();
                    return;
                }
            }while (Math.Abs(a - b) > precision);
            EcrireLog("La solution de cette equation est x = " + b);
            tbResultat.Text = b.ToString();
        }

        private void EcrireLog(string p)
        {
            tbConsole.Text += p + "\n";
        }

        #region Evenement

        private void btCalculer_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double value = 0;
            double precision = 0;
            if (!double.TryParse(tbBorneInferieure.Text, out a) || !double.TryParse(tbBorneSuperieure.Text, out b) || !double.TryParse(tbPrecision.Text, out precision))
                return;
            switch (_typeMethode)
            {
                case typeMethode.Dichotomique:
                    CalculDichotomique(a, b, precision, value);
                    break;
                case typeMethode.Newton:
                    CalculNewton(a, b, precision, value);
                    break;
                case typeMethode.Secante:
                    CalculSecante(a, b, precision, value);
                    break;
                default:
                    break;
            }
        }

        private void cbMethode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).Text)
            {
                case "Dichotomie":
                    tbPrecision.Visible = true;
                    lbPrecision.Visible = true;
                    _typeMethode = typeMethode.Dichotomique;
                    break;
                case "Newton":
                    tbPrecision.Visible = true;
                    lbPrecision.Visible = true;
                    _typeMethode = typeMethode.Newton;
                    break;
                case "Secante":
                    tbPrecision.Visible = true;
                    lbPrecision.Visible = true;
                    _typeMethode = typeMethode.Secante;
                    break;
                default:
                    errorProvider1.SetError(cbMethode, "Le type de méthode n'est pas reconnu");
                    break;
            }
        }

        private void tbBorneInferieure_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            double value;
            string chaine = ((TextBox)sender).Text;
            chaine = chaine.Replace('.', ',');
            if (!double.TryParse(((TextBox)sender).Text,out value))
            {
                errorProvider1.SetError((Control)sender, "La valeur entrée est erronée");
            }
        }

        #endregion

    }

    enum typeMethode
    {
        Dichotomique,
        Newton,
        Secante
    }
}
