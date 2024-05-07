using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Simulador
    {
        public int Quantity { get; }
        public int From { get; }
        public int To { get; }
        public double PacienteAsistido { get; }
        public double Asistio { get; }
        public double NuncaAsistio { get; }
        public double PacienteAsistidoSolicitoAsesor { get; }
        public double PacienteAsistidoNoSolicitoAsesor { get; }
        public double AsistioSolicitoAsesor { get; }
        public double AsistioNoSolicitoAsesor { get; }
        public double NuncaAsistioSolicitoAsesor { get; }
        public double NuncaAsistioNoSolicitoAsesor { get; }


        public Simulador(int quantity, int from, int to,
            double pacienteAsistido = 0.60,
            double asistio = 0.25,
            double nuncaAsistio = 0.15,
            double pacienteAsistidoSolicitoAsesor = 0.50,
            double pacienteAsistidoNoSolicitoAsesor = 0.50,
            double asistioSolicitoAsesor = 0.40,
            double asistioNoSolicitoAsesor = 0.60,
            double nuncaAsistioSolicitoAsesor = 0.15,
            double nuncaAsistioNoSolicitoAsesor = 0.85)
        {
            Quantity = quantity;
            From = from;
            To = to;
            PacienteAsistido = pacienteAsistido;
            Asistio = asistio;
            NuncaAsistio = nuncaAsistio;
            PacienteAsistidoSolicitoAsesor = pacienteAsistidoSolicitoAsesor;
            PacienteAsistidoNoSolicitoAsesor = pacienteAsistidoNoSolicitoAsesor;
            AsistioSolicitoAsesor = asistioSolicitoAsesor;
            AsistioNoSolicitoAsesor = asistioNoSolicitoAsesor;
            NuncaAsistioSolicitoAsesor = nuncaAsistioSolicitoAsesor;
            NuncaAsistioNoSolicitoAsesor = nuncaAsistioNoSolicitoAsesor;
        }
        public IList<StateRow> simulate()
        {

            Random random = new Random();
            String tipoPaciente;
            int acumSolicitoAsesor = 0;
            int acumNoSolicitoAsesor = 0;
            int solicitoAsesor = 0;



            IList<StateRow> stateRows = new List<StateRow>();



            for (int i = 0; i < Quantity; i++)
            {
                double rndNumber = random.NextDouble();
                double rndNumber2 = random.NextDouble();

                tipoPaciente = this.getTipoPaciente(rndNumber);

                switch (tipoPaciente)
                {
                    case "Paciente Asistido Último Año":
                        if (rndNumber2 < PacienteAsistidoSolicitoAsesor)
                        {
                            acumSolicitoAsesor++;
                            solicitoAsesor = 1;
                        }
                        else
                        {
                            acumNoSolicitoAsesor++;
                        }

                        break;

                    case "Paciente No Asistido Último Año":
                        if (rndNumber2 < AsistioSolicitoAsesor)
                        {
                            acumSolicitoAsesor++;
                            solicitoAsesor = 1;
                        }
                        else
                        {
                            acumNoSolicitoAsesor++;
                        }

                        break;

                    case "Nunca Asistió":
                        if (rndNumber2 < NuncaAsistioSolicitoAsesor)
                        {
                            acumSolicitoAsesor++;
                            solicitoAsesor = 1;
                        }
                        else
                        {
                            acumNoSolicitoAsesor++;
                        }

                        break;

                }

                StateRow row = new StateRow
                {
                    iterationNum = i + 1,
                    rndNumber = Math.Truncate(rndNumber * 10000) / 10000,
                    tipoPaciente = tipoPaciente,
                    rndNumber2 = Math.Truncate(rndNumber2 * 10000) / 10000,
                    solicitoAsesor = solicitoAsesor,
                    acumSolicitoAsesor = acumSolicitoAsesor
                };

                solicitoAsesor = 0;

                // Agregar la fila a `stateRows` si cumple las condiciones de `from` y `to`
                if ((i >= From - 1 && i <= From + To) || i == (Quantity - 1))
                {
                    stateRows.Add(row);
                }
            }

            return stateRows;
        }

        private string getTipoPaciente(double rnd)
        {

            if (rnd < PacienteAsistido) return "Paciente Asistido Último Año";

            if (rnd < (PacienteAsistido + Asistio)) return "Paciente No Asistido Último Año";

            return "Nunca Asistió";


        }
    }
}
