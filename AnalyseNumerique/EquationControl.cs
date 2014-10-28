using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalyseNumerique
{
    public partial class EquationControl : UserControl
    {
        private int _exposant=0;
        [Description("Le degré de l'équation"),Category("Données")]
        public int Degree
        {
            set
            {
                if (value == 0)
                {
                    lbInconnu.Text = "";
                    cbFonction.Visible = false;
                }
                else if(value == 1)
                {
                    lbInconnu.Text = "X";
                }
                else
                {
                    lbInconnu.Text = "X^" + value;
                }
                _exposant = value;
            }
        }
        public EquationControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Fonction permettant le calcul de la partie de l'équation concerné par l'UC
        /// </summary>
        /// <param name="value"> Valeur d'entrée de x</param>
        /// <returns>Résultat</returns>
        public double CalculEquation(double value)
        {
            double result = 0;
            double alpha;
            if (double.TryParse(tbAlpha.Text, out alpha))
            {
                if (_exposant == 0)
                    return alpha;

                switch (cbFonction.Text)
                {
                    case "log":
                        if (value > 0)
                            result = alpha * Math.Log10(Math.Pow(value, _exposant));
                        else
                            result = 0;
                        break;
                    case "ln":
                        if (value > 0)
                            result = alpha * Math.Log(Math.Pow(value, _exposant));
                        else
                            result = 0;
                        break;
                    case "sin":
                        result = alpha * Math.Sin(Math.Pow(value, _exposant));
                        break;
                    case "cos":
                        result = alpha * Math.Cos(Math.Pow(value, _exposant));
                        break;
                    case "*" :
                        result = alpha * Math.Pow(value, _exposant);
                        break;
                }
                return result;
            }
            else return 0;
        }

        internal double CalculDerive(double a)
        {

            double result = 0;
            double alpha;
            if (double.TryParse(tbAlpha.Text, out alpha))
            {
                if (_exposant == 0)
                    return alpha;

                switch (cbFonction.Text)
                {
                    case "log":
                        result = alpha * _exposant/(a*Math.Log10(1));
                        break;
                    case "ln":
                        result = alpha * _exposant/a;
                        break;
                    case "sin":
                        result = alpha * _exposant*Math.Pow(a,_exposant-1)*Math.Cos(Math.Pow(a,_exposant));
                        break;
                    case "cos":
                        result = -alpha * _exposant*Math.Pow(a,_exposant-1)*Math.Sin(Math.Pow(a, _exposant));
                        break;
                    case "*":
                        result = alpha * Math.Pow(a,_exposant-1);
                        break;
                }
                return result;
            }
            else return 0;
        }
    }
}
