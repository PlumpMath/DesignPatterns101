using System.Collections.Generic;
using System.Linq;

namespace Rigel.Samples.DesignPatterns.Behavioral.ChainOfResponsability
{
    public class JuniorTechSupport : ITechSupportEngineer
    {
        private readonly ITechSupportEngineer _manager;

        public JuniorTechSupport(ITechSupportEngineer manager)
        {
            _manager = manager;
        }

        public IEnumerable<ShawProblemFixingStep> FixClientProblems(IEnumerable<ShawTechnicalProblem> problems)
        {
            // I dont even know my full name 

            return _manager.FixClientProblems(problems);
        }
    }
}