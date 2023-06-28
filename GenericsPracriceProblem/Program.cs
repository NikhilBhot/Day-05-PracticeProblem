namespace GenericsPracriceProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WithOut Using Generics");
            DeleteArrayEleWithoutGenerics.WithoutGenericMethod();
            Console.WriteLine("____________________________");
            Console.WriteLine("Using Generics");
            DeleteArrayEleWithGenerics.WithGenericMethod();
        }
    }
}