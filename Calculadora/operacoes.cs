using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class operacoes
    {
        // atributos
        int operacao;
        double val1, val2;

        // metodo construtor
        public operacoes()
        {
            val1 = 0;
            val2 = 0;
            operacao = 0;
        }
        public void setValores(double pval)
        {
            if (val1 == 0)
            {
                val1 = pval;
            } else {
                val2 = pval;
            } //if 
        } //setValores

        public void setOperacao(int a)
        {
            this.operacao = a;
        }

        public string soma()
        {
            double res;
            res = val1 + val2;
            val1 = 0;
            val2 = 0;
            return res.ToString();
        }
        public string subtracao()
        {
            double res;
            res = val1 - val2;
            val1 = 0;
            val2 = 0;
            return res.ToString();
        }
        public string multiplicacao()
        {
            double res;
            res = val1 * val2;
            val1 = 0;
            val2 = 0;
            return res.ToString();
        }
        public string divisao()
        {
            double res;
            res = val1 / val2;
            val1 = 0;
            val2 = 0;
            return res.ToString();
        }
        public string exec_op()
        {
            switch (operacao)
            {
                case 1: return soma();
                case 2: return subtracao();
                case 3: return multiplicacao();
                case 4: return divisao();

            }
            return "";

        }


    }
}