using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusRechner
{
    public partial class Form1 : Form
    {
        private string Zahl1 = "";
        private string Zahl2 = "";
        private string Operator;
        private string Ergebnis;

        public Form1()
        {
            InitializeComponent();
            TB_Ausgabe.Text = "";
        }

        private void Refresh_Ausgabe()
        {
            TB_Ausgabe.Text = Zahl1 + " " + Operator + " "+ Zahl2;
        }

        private void Clear()
        {
            Zahl1 = "";
            Zahl2 = "";
            Operator = null;
            Ergebnis = null;
            TB_Ausgabe.Text = null;
            EnableButtons(true);
        }

        private void EnableButtons(bool State)
        {
            B_Zahl1.Enabled = State;
            B_Zahl2.Enabled = State;
            B_Zahl3.Enabled = State;
            B_Zahl4.Enabled = State;
            B_Zahl5.Enabled = State;
            B_Zahl6.Enabled = State;
            B_Zahl7.Enabled = State;
            B_Zahl8.Enabled = State;
            B_Zahl9.Enabled = State;
            B_Zahl0.Enabled = State;
           
            B_Plus.Enabled = State;
            B_Minus.Enabled = State;
            B_Mal.Enabled = State;
            B_Geteilt.Enabled = State;

            B_Komma.Enabled = State;
            B_Gleich.Enabled = State;



        }


        #region InsertNumber
        private void InsertNumber(string Zahl)
        {
            if (Operator == null)
            { Zahl1 += Zahl; }
            else
            { Zahl2 += Zahl; }

            Refresh_Ausgabe();
        }

        private void B_Zahl1_Click(object sender, EventArgs e)
        {
            InsertNumber("1");
        }

        private void B_Zahl2_Click(object sender, EventArgs e)
        {
            InsertNumber("2");
        }

        private void B_Zahl3_Click(object sender, EventArgs e)
        {
            InsertNumber("3");
        }

        private void B_Zahl4_Click(object sender, EventArgs e)
        {
            InsertNumber("4");
        }

        private void B_Zahl5_Click(object sender, EventArgs e)
        {
            InsertNumber("5");
        }

        private void B_Zahl6_Click(object sender, EventArgs e)
        {
            InsertNumber("6");
        }

        private void B_Zahl7_Click(object sender, EventArgs e)
        {
            InsertNumber("7");
        }

        private void B_Zahl8_Click(object sender, EventArgs e)
        {
            InsertNumber("8");
        }

        private void B_Zahl9_Click(object sender, EventArgs e)
        {
            InsertNumber("9");
        }

        private void B_Zahl0_Click(object sender, EventArgs e)
        {
            InsertNumber("0");
        }

        private void B_Komma_Click(object sender, EventArgs e)
        {
            InsertNumber(",");
        }

        #endregion

        #region Operanten
        private void B_Plus_Click(object sender, EventArgs e)
        {
            Operator = "+";
            Refresh_Ausgabe();
        }

        private void B_Minus_Click(object sender, EventArgs e)
        {
            Operator = "-";
            Refresh_Ausgabe();
        }

        private void B_Mal_Click(object sender, EventArgs e)
        {
            Operator = "*";
            Refresh_Ausgabe();
        }

        private void B_Geteilt_Click(object sender, EventArgs e)
        {
            Operator = "/";
            Refresh_Ausgabe();
        }
        #endregion

        private void B_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void B_Gleich_Click(object sender, EventArgs e)
        {
            Rechner MyRechner = new Rechner(Convert.ToDouble(Zahl1) , Convert.ToDouble(Zahl2) );

            switch (Operator)
            {
                case "+": Ergebnis = Convert.ToString( MyRechner.Addieren() ); break;
                case "-": Ergebnis = Convert.ToString(MyRechner.Subtrahieren() ); break;
                case "*": Ergebnis = Convert.ToString(MyRechner.Multiplizieren() ); break;
                case "/": Ergebnis = Convert.ToString(MyRechner.Dividieren() ); break;
            }

            TB_Ausgabe.Text += " = " + Ergebnis;

            EnableButtons(false);
        }

        private void L_Info_Click(object sender, EventArgs e)
        {
            Info MyInfoForm = new Info();
            MyInfoForm.Show();
        }
    }
}
