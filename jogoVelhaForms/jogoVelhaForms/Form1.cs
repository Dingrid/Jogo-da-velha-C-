using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoVelhaForms
{
    public partial class Form1 : Form
    {
        int xpts = 0, opts = 0, empatepts = 0, rodadas = 0;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            rodadas = 0;
        }

        bool turno = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Text==" ")
            {
                if(turno)
                {
                    btn.Text = "X";
                    rodadas++;
                    if (verificar() == 1)
                    {
                        xpts++;
                        xpontos.Text = xpts.ToString();
                        rodadas = 0;
                        Desativa();
                    }
                    turno = !turno;
                }
                else
                {
                    btn.Text = "O";
                    rodadas++;
                    if (verificar() == 1)
                    {
                        opts++;
                        ypontos.Text = opts.ToString();
                        rodadas = 0;
                        Desativa();
                    }
                    turno = !turno;
                }

                if(rodadas==9 && verificar()==0)
                {
                    MessageBox.Show("Droga! Deu velha :/");
                    Desativa();
                    empatepts++;
                    epts.Text = empatepts.ToString();
                }
            }
        }

        private void Desativa()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private int verificar()
        { 
            //HORIZONTAL
            if ((button1.Text !=" ") && (button1.Text== button2.Text) && (button2.Text== button3.Text))
            {
                MessageBox.Show("Parabéns! Deu match na horizontal!");
                return 1;
            }
            if ((button6.Text != " ") && (button6.Text == button5.Text) && (button5.Text == button4.Text))
            {
                MessageBox.Show("Parabéns! Deu match na horizontal!");
                return 1;
            }
            if ((button7.Text != " ") && (button7.Text == button8.Text) && (button8.Text == button9.Text))
            {
                MessageBox.Show("Parabéns! Deu match na horizontal!");
                return 1;
            }

            //VERTICAL
            if ((button1.Text != " ") && (button1.Text == button6.Text) && (button6.Text == button9.Text))
            {
                MessageBox.Show("Parabéns! Deu match na vertical!");
                return 1;
            }
            if ((button2.Text != " ") && (button2.Text == button5.Text) && (button5.Text == button8.Text))
            {
                MessageBox.Show("Parabéns! Deu match na vertical!");
                return 1;
            }
            if ((button3.Text != " ") && (button3.Text == button4.Text) && (button4.Text == button7.Text))
            {
                MessageBox.Show("Parabéns! Deu match na vertical!");
                return 1;
            }

            //DIAGONAL
            if ((button1.Text != " ") && (button1.Text == button5.Text) && (button5.Text == button7.Text))
            {
                MessageBox.Show("Parabéns! Deu match na diagonal!");
                return 1;
            }
            if ((button3.Text != " ") && (button3.Text == button5.Text) && (button5.Text == button9.Text))
            {
                MessageBox.Show("Parabéns! Deu match na diagonal!");
                return 1;
            }

            //NENUM
            else
            {
                return 0;
            }
        }
        }
}