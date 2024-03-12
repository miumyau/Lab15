namespace Lab15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            GeomProgression geomProgression = new GeomProgression();
            arithProgression.SetStart(5);
            arithProgression.SetStep(3);
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());
            arithProgression.Reset();
            Console.WriteLine(arithProgression.GetNext());
            geomProgression.SetStart(1);
            geomProgression.SetStep(2);
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            geomProgression.Reset();
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.ReadKey();





        }
    }
}
