using System.Collections;
using System.Collections.Generic;

namespace Rigel.Samples.DesignPatterns.Behavioral.ChainOfResponsability
{
    public class ShawClientSupportLine : IShawClientSupportLine
    {
        private readonly ITechSupportEngineer _supportEngineer;

        public ShawClientSupportLine()
        {
            _supportEngineer = new JuniorTechSupport(new ShawTechSupportEngineer(new ShawTechExpert()));
        }

        public IEnumerable<ShawProblemFixingStep> FixMyDamnProblem(IEnumerable<ShawTechnicalProblem> problems)
        {
            return _supportEngineer.FixClientProblems(problems);
        }
    }
}