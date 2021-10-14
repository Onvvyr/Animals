using System;

namespace Animals
{
    class Program
    {
        interface IZwierze
        {
            void SampleMethod();
        }

        class ImplementationClass : IZwierze
        {
            void IZwierze.SampleMethod()
            {
            }

            static void Main()
            {
                IZwierze obj = new ImplementationClass();

                obj.SampleMethod();
            }
        }
    }
}
