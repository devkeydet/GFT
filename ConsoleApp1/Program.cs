namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            SomeFeature();
            AnotherFeature();
        }

        private static void AnotherFeature()
        {
            var x = "";
            throw new System.NotImplementedException();
        }

        private static void SomeFeature()
        {
            throw new System.NotImplementedException();
        }
    }
}
