using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAplicacion.Simulator
{
    class SimulationHistory
    {
        public int HistoricalInfectedAmount { get; set; }

        public List<int> InfectedPerIteration { get; set; } = new List<int>();

        public int AmountIterations { get; set; }
    }
}
