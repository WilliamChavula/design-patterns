using System;

namespace Simple_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Simple Factory Pattern demo ***\n");
            IAnimal preferredType = null;
            SimpleFactory simpleFactory = new SimpleFactory();

            #region The code region that can cary based on users preferences
            /*
             * Since this part may vary, we're moving the
             * part to CreateAnimal() in SimpleFactory class.
            */
            preferredType = simpleFactory.CreateAnimal();
            #endregion

            #region The codes that do not change frequently.
            preferredType.AboutMe();
            #endregion

            Console.ReadKey();
        }
    }
}
