using System.Collections.Generic;

namespace Rigel.Samples.DesignPatterns.Behavioral.ChainOfResponsability
{
    public interface IShawClientSupportLine
    {
        IEnumerable<ShawProblemFixingStep> FixMyDamnProblem(IEnumerable<ShawTechnicalProblem> problems);
    }
}