using System;
using System.Linq;


namespace Rigel.Samples.DesignPatterns.Behavioral.ChainOfResponsability
{
    public class Client
    {
        public void CallShawTechSupport()
        {
            var support = new ShawClientSupportLine();

            support.FixMyDamnProblem(Enumerable.Range(1, 200)
                   .Select(i => new ShawTechnicalProblem()
                   {
                       Id = i, 
                       Device = GetDeviceFor(i), 
                       Description = "What do I know, just fix my problem", 
                       Solved = false // of course is not
                   }));
        }

        private ShawDevice GetDeviceFor(int value)
        {
           return (ShawDevice)(value % 3);
        }
    }
}