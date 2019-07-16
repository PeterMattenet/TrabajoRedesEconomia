using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAplicacion.Simulator
{
    public enum NodeStatus
    {
        Susceptible,
        Infected,
        Removed,
        Hospitalized
    }

    public enum NodeType
    {
        //Puede vacunarse sin problema
        Healthy,
        //Tiene condiciones de salud que no le permiten vacunarse
        AtRisk,
        //Esta vacunado
        Vaccinated
    }
}
