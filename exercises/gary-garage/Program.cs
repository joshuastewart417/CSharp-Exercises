namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram junk = new Ram();

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();

            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();

            mx410.Drive();
            junk.Drive();
        }
    }
}
