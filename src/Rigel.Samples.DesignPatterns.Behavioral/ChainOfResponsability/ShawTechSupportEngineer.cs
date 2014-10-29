using System.Collections.Generic;
using System.Linq;

namespace Rigel.Samples.DesignPatterns.Behavioral.ChainOfResponsability
{
    public class ShawTechSupportEngineer : ITechSupportEngineer
    {
        private ITechSupportEngineer _manager; 

        public ShawTechSupportEngineer(ITechSupportEngineer manager)
        {
            _manager = manager;
        }

        public IEnumerable<ShawProblemFixingStep> FixClientProblems(IEnumerable<ShawTechnicalProblem> problems)
        {
            // I only know how to reset the CableBox 
            var cableBoxProblems = problems.Where(p => p.Device == ShawDevice.CableBox).ToArray();

            if (cableBoxProblems.Any())
            {
                foreach (var problem in cableBoxProblems)
                {
                    problem.Solved = true;
                }
            }

            var otherProblems = problems.Except(cableBoxProblems);

            var solutions = _manager.FixClientProblems(otherProblems);

            yield return new ShawProblemFixingStep() { Number = 1, ActionDescription = "Powercycle your cable box" };

            foreach (var solution in solutions)
            {
                yield return solution;
            }
        }
    }
}