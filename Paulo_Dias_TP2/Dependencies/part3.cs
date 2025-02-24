using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Part3
    {
        public void ScholarGrade(double nota)
        {
            if (nota < 4)
            {
                Console.WriteLine("Performance Insuficiente");
            }
            else if (nota >= 4 && nota <= 5)
            {
                Console.WriteLine("Performance Regular");
            }
            else if (nota > 5 && nota <= 8.99)
            {
                Console.WriteLine("Performance Boa");
            }
            else
            {
                Console.WriteLine("Performance Exelente");
            }
        }

        public void WageDeductions(double wage)
        {

            // INSS Logic Site: https://www.contabilizei.com.br/contabilidade-online/desconto-inss/

            double INSS;

            if (wage <= 1518.00)
            {
                INSS = wage * 0.075;
            }
            else if (wage >= 1518.01 && wage <= 2793.88)
            {
                INSS = wage * 0.09 - 22.77;
            }
            else if (wage >= 2793.89 && wage <= 4190.84)
            {
                INSS = wage * 0.12 - 106.59;
            }
            else if (wage >= 4190.85 && wage <= 8157.41)
            {
                INSS = wage * 0.14 - 190.40;
            }
            else
            {
                INSS = 0.00;
            }


            // IRPF Logic Site: https://www.contabilizei.com.br/contabilidade-online/desconto-inss/

            double IRPF;

            if (wage <= 2259.20)
            {
                IRPF = 0.00;
            }
            else if (wage >= 2259.21 && wage <= 2826.65)
            {
                IRPF = wage * 0.075 - 169.44;
            }
            else if(wage >= 2826.66 && wage <= 3751.05)
            {
                IRPF = wage * 0.15 - 381.44;
            }
            else if (wage >= 3751.06 && wage <= 4664.68)
            {
                IRPF = wage * 0.225 - 662.77;
            }
            else
            {
                IRPF = wage * 0.275 - 896;
            }

            double liquidWage = wage - INSS - IRPF;

            Console.WriteLine($"Salário Bruto: R$ {wage:F2} \n" +
                              $"Desconto INSS: -R$ {INSS:F2} \n" +
                              $"DEsconto IRPF: -R$ {IRPF:F2} \n" +
                              $"Salário Líquido: R$ {liquidWage:F2} \n");

        }
    
    
    }
}
