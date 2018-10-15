namespace Settelment
{
    internal class Program
    {
        public static void Main(string[] Args)
        {
            var Settelment = new Settelment();
            Generator.GeneratAll();
            Settelment.SetDefault();
            
            while (Settelment.IsPlaying) Settelment.Start();
        }
    }
}