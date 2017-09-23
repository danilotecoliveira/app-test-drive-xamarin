﻿using System;

namespace TestDrive.Models
{
    public class Agendamento
    {
        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }

        public Veiculo Veiculo { get; set; }

        DateTime dataAgendamento = DateTime.Today;

        public DateTime DataAgendamento
        {
            get
            {
                return dataAgendamento;
            }
            set
            {
                dataAgendamento = value;
            }
        }

        public TimeSpan HoraAgendamento { get; set; }
    }
}
