using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public interface IZwierze
    {
        void Ptak();
    }
    public interface ISurface
    {
        void Ptak();
    }
    public class SampleClass : IZwierze, ISurface
    {
        public void Ptak()
        {
            Console.WriteLine("Cześć, jestem pies");
        }
    }
}
