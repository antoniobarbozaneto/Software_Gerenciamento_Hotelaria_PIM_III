using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Pim_3_Semestre
{
    class Reserva
    {

        // DateTime dt_Checkin = DateTime.Parse("20/05/2021");
        // DateTime dt_Checkout = DateTime.Parse("25/05/2021");
        public DateTime dt_Checkin { get; set; }
        public DateTime dt_Checkout { get; set; }
        public int Qtd_Hospede { get; set; }
        public double QtDias { get; set; }
        public double Res { get; set; }
        public double ResFinal { get; set; }

        Quarto quarto;
        public Reserva()
        {
            quarto = new Quarto(); 
        }

        public double CalcValorReserva(DateTime dt_Checkin, DateTime dt_Checkout, int Qtd_Hospede)
        {
            this.dt_Checkin = dt_Checkin;
            this.dt_Checkout = dt_Checkout;
            this.Qtd_Hospede = Qtd_Hospede;
            this.Res = Qtd_Hospede * quarto.tipoQuarto.Valor_Diaria;
            TimeSpan final = dt_Checkout.Subtract(dt_Checkin);
            this.QtDias = final.TotalDays;
            Console.WriteLine("Valor diaria por pessoa: " + quarto.tipoQuarto.Valor_Diaria + " Quantidade de pessoas: " + Qtd_Hospede + " Valor total: " + Res);
            this.ResFinal = QtDias * Res;
            Console.Write("Valor da reserva ficou no total de : " + ResFinal);
            return ResFinal;
        }
    }
}
