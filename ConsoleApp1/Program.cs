namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            SomeFeature();
            AnotherFeature();
            OneMoreFeature();
        }

        private static void OneMoreFeature()
        {
            throw new System.NotImplementedException();
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
