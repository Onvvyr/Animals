using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public interface IZwierze
    {
        void Kot();
    }
    public interface ISurface
    {
        void Kot();
    }
    public class SampleClass : IZwierze, ISurface
    {
        public void Kot()
        {
            Console.WriteLine("Cześć, jestem pies");
        }
    }
}
