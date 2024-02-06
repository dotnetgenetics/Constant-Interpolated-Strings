namespace ConstantInterpolatedStrings
{
    internal class Program
    {
        private const string FirstName = "John";
        private const string MiddleName = "Hope";
        private const string LastName = "Doe";
        private const string FullName = $"Full Name: {FirstName} {MiddleName} {LastName}";

        static void Main(string[] args)
        {
            Console.WriteLine(FullName);
            Console.ReadLine();
        }
    }
}
