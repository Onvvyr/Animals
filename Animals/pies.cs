using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public interface IZwierze
    {
        void Pies();
    }
    public interface ISurface
    {
        void Pies();
    }
    public class SampleClass : IZwierze, ISurface
    {
        public void Pies()
        {
            Console.WriteLine("Cześć, jestem pies");
        }
    }
}
