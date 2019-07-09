using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kuh20
{
    public partial class FormKuh : Form
    {
        Ziege[] _ziegen = new Ziege[3];

        Kuh[] _kuehe = new Kuh[3];
        Kuh _ausgewaehlteKuh;
        
        public FormKuh()
        {
            InitializeComponent();
        }

        private void FormKuh_Load(object sender, EventArgs e)
        {
            Ziege Ziege1 = new Ziege();
            Ziege1.Name = "Giesela";
            Ziege1.Alter = 2;
            Ziege1.Gewicht = 12;
         

           // _ziegen[1] = new Ziege("Giesela");



            //Beim Laden des Formulars werden die Kühe "erzeugt"...

            _kuehe[0] = new Kuh("Elsa",3,450,12);  //wo erstelle ich Objekte? Objekte werden im Array gespeichert. Beim Schließen des Programm werden Kühe auch wieder gelöscht
            _kuehe[1] = new Kuh("Emma",4,500,4);
            _kuehe[2] = new Kuh("Gisa",8,400,5);

            //...und die Anzeige der aktiven Kuh gesetzt.
            panelGreen2.BackColor = this.BackColor;
            panelGreen3.BackColor = this.BackColor;

            _ausgewaehlteKuh = _kuehe[0];

            //Methode aufrufen
            EigenschaftenSetzen();
        }

        private void picBKuh1_Click(object sender, EventArgs e)
        {
            panelGreen1.BackColor = Color.Green;
            panelGreen2.BackColor = this.BackColor ;
            panelGreen3.BackColor = this.BackColor;

            _ausgewaehlteKuh = _kuehe[0];

            //Methode aufrufen
            EigenschaftenSetzen();

            //Kuhnamen ändern
            _kuehe[0].Name = "Tom"; //Sette den Namen

        }

        private void picBKuh2_Click(object sender, EventArgs e)
        {
            panelGreen1.BackColor = this.BackColor;
            panelGreen2.BackColor = Color.Green;
            panelGreen3.BackColor = this.BackColor;

            _ausgewaehlteKuh = _kuehe[1];

            //Methode aufrufen
            EigenschaftenSetzen();
        }

        private void picBKuh3_Click(object sender, EventArgs e)
        {
            panelGreen1.BackColor = this.BackColor;
            panelGreen2.BackColor = this.BackColor;
            panelGreen3.BackColor = Color.Green;

            _ausgewaehlteKuh = _kuehe[2];

            //Methode aufrufen
            EigenschaftenSetzen();
        }

        //Methode, um die Eigenschaften zusetzen.
        private void EigenschaftenSetzen()
        {
            lblAlter.Text = _ausgewaehlteKuh.Alter.ToString();
            lblGewicht.Text = _ausgewaehlteKuh.Gewicht.ToString();
            lblInhalt.Text = Convert.ToString(_ausgewaehlteKuh.Milchvorrat);
            //lblInhalt.Text = _ausgewaehlteKuh.Milchvorrat.ToString();
            lblName.Text = _ausgewaehlteKuh.Name;
        }

        private void btnFuettern_Click(object sender, EventArgs e)
        {
            _ausgewaehlteKuh.Nahrungsaufnahme(Convert.ToDouble(txtHeumenge.Text));

        }

        private void btnMelken_Click(object sender, EventArgs e)
        {
            lblMilchMenge.Text = Convert.ToString(_ausgewaehlteKuh.Melken());
            
            //Erneut die geänderten Werte ausgeben.
            EigenschaftenSetzen();
        }


        
    }
}
