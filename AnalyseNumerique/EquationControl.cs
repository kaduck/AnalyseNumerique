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
                        result = alpha*Math.Log10(Math.Pow(Math.Abs(value),_exposant));
                        break;
                    case "ln":
                        result = alpha * Math.Log(Math.Pow(Math.Abs(value), _exposant));
                        break;
                    case "sin":
                        result = alpha * Math.Sin(Math.Pow(value, _exposant));
                        break;
                }
                return result;
            }
            else return 0;
        }
    }
}
