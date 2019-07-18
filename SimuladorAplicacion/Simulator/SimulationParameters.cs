using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAplicacion.Simulator
{
    public class SimulatorParameters
    {
        public double VaccineEfficiencyRatio;

        public double VaccinatedRatio;

        public double AtRiskRatio;

        public int ChiSquaredDistributionDegreesOfFreedom;

        public int ChiSquaredRecoveryDistributionDegreesOfFreedom;

        public double InfectionChiSquaredFactor;

        public double RecoveryChiSquaredFactor;

        public List<double> InfectionProbabilities;

        public List<double> RecoveryProbabilities;

        public int DaysOfImmunity;
    }
}
