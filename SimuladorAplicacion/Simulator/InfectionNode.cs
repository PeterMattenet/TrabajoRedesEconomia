using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAplicacion.Simulator
{
    public class InfectionNode
    {
        public InfectionNode(InfectionNode originalNode)
        {
            NodeStatus = originalNode.NodeStatus;
            NodeType = originalNode.NodeType;
            DayOfInfection = originalNode.DayOfInfection;
            DaysUntilSuceptible = originalNode.DaysUntilSuceptible;
        }

        public InfectionNode() { }

        public NodeStatus NodeStatus { get; set; }

        public NodeType NodeType { get; set; }

        public int DayOfInfection { get; set; }

        public int DaysUntilSuceptible { get; set; }
    }
}
