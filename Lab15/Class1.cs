using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    internal class ArithProgression : ISeries
    {
        int startvalue;
        int step;
        int currentvalue;
        public int Startvalue { get { return startvalue; } set {  startvalue = value; } }
        public int Step { get { return step; } set {  step = value; } }
        public int Currentvalue {  get { return currentvalue; } set {  currentvalue = value; } }
        public int GetNext()
        {
            Currentvalue += Step;
            return Currentvalue;
        }

        public void Reset()
        {
            Currentvalue=Startvalue;
        }

        public void SetStart(int x)
        {
            Startvalue=x;
            Currentvalue=Startvalue;
        }

        public void SetStep(int s)
        {
            Step = s;
        }
    }

}
