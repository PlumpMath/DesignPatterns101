using System.Collections;
using System.Collections.Generic;

namespace Rigel.Samples.DesignPatterns.Behavioral.ChainOfResponsability
{
    public interface ITechSupportEngineer
    {
        IEnumerable<ShawProblemFixingStep> FixClientProblems(IEnumerable<ShawTechnicalProblem> problems);
    }
}