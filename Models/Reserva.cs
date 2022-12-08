using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Sistema_Hospedagem_Hotel.Models
{
    public class Reserva
    {
        Suite Suite = new Suite();
        List<Pessoa> Hospedes = new List<Pessoa>();
        public int DiasReservados { get; set; }

        public Reserva (int diasReservados)
        {
            this.DiasReservados = diasReservados;
        }

        public void CadastrarHospedes (List<Pessoa> hospedes)
        {

            for (int i = 0 ; i < hospedes.Count ; i++)
            {
                Hospedes.Add(hospedes[i]);
            }

        }
        

        public void CadastrarSuite(Suite suite)
        {

            Suite.TipoSuite = suite.TipoSuite ;

            Suite.Capacidade = suite.Capacidade ;

            Suite.ValorDiaria = suite.ValorDiaria ;

        }

        public int ObterQuantidadeHospedes()
        {

            int quantidadeHospedes = Hospedes.Count;

            return quantidadeHospedes;

        }


        //O método checa 
        public decimal CalcularValorDiaria()
        {

            decimal valorDiaria = 0;

            valorDiaria = DiasReservados * Suite.ValorDiaria;
            
            if(DiasReservados >= 10) // Aplica desconto para reservas acima de 10 dias.
            {
                return (valorDiaria * 0.90M);
            }
            else
            {
                return valorDiaria;
            }
        }
    }
}