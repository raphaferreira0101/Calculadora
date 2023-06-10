using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        operacoes novo = new operacoes();

        private object calc;

        public Form1()
        {
            InitializeComponent();
        }

        // aqui 
        operacoes c = new operacoes();

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            novo.setValores(Convert.ToDouble(btn1.Text)); //revisar 
            txtResp.Text = txtResp.Text + btn1.Text;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            novo.setOperacao(1);
            txtResp.Text = txtResp.Text + btnSoma.Text; //revisar
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            novo.setOperacao(2);
            txtResp.Text = txtResp.Text + btnMenos.Text;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            novo.setOperacao(3);
            txtResp.Text = txtResp.Text + btnMult.Text;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            novo.setOperacao(4);
            txtResp.Text = txtResp.Text + btnDiv.Text;

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            txtResp.Text = c.exec_op();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResp.Text = txtResp.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResp.Text = txtResp.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResp.Text = txtResp.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResp.Text = txtResp.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResp.Text = txtResp.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResp.Text = txtResp.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResp.Text = txtResp.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResp.Text = txtResp.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResp.Text = txtResp.Text + btn0.Text;
        }

        private void txtResp_TextChanged(object sender, EventArgs e)
        {

        }



    }

}

