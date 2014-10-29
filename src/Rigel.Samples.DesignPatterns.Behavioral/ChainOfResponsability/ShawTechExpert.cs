using System.Collections.Generic;
using System.Linq;

namespace Rigel.Samples.DesignPatterns.Behavioral.ChainOfResponsability
{
    public class ShawTechExpert : ITechSupportEngineer
    {
        public IEnumerable<ShawProblemFixingStep> FixClientProblems(IEnumerable<ShawTechnicalProblem> problems)
        {
            return Enumerable.Empty<ShawProblemFixingStep>();
        }
    }
}