namespace HM_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SostavnayaFigura sostavnayaFigura = new SostavnayaFigura();
            ISimpleNgon a1 = new Kvadrat(5);
            //try { 
            //    ISimpleNgon a2 = new Treugolnic(5, 3, 40);
            //    sostavnayaFigura.Add(a2);
            //}
            //catch (Exception e) { Console.WriteLine(e.Message); }
            ISimpleNgon a3 = new Pramougolnic(5, 3);
            ISimpleNgon a4 = new Romb(5, 3);
            //ISimpleNgon a5 = new Paralelogram(8, 3, 4, 6);
            //ISimpleNgon a6 = new Trapecia(8, 3, 4, 6, 5);
            //ISimpleNgon a7 = new Krug(8);
            sostavnayaFigura.Add(a1);
            sostavnayaFigura.Add(a3);
            sostavnayaFigura.Add(a4);
            //sostavnayaFigura.Add(a5);
            //sostavnayaFigura.Add(a6);
            //sostavnayaFigura.Add(a7);
            
            sostavnayaFigura.CalculateAArea();
            sostavnayaFigura.Print(ConsoleColor.Yellow);
        }
    }
}
