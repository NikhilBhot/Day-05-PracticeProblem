namespace GenericsPracriceProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WithOut Using Generics Method");
            DeleteArrayEleWithoutGenerics.WithoutGenericMethod();
            Console.WriteLine("____________________________");
            Console.WriteLine("Using Generics Mrthod");
            DeleteArrayEleWithGenerics.WithGenericMethod();
            Console.WriteLine("____________________________");
            Console.WriteLine("With Generic Class");
            DeleteArrayEleWithGenericClass.WithGenericClass();

            Console.WriteLine("____________________________");
            Console.WriteLine("Mimimum Finder Without Generics");
            MinimumFinder.FindMimimumMethod();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Minimum Finder Refactor With Generis");
           // MinimumFinderRefactor.MinimumFinderMethodRefactor();

            MinimumFinderRefactor.MinimumFinderMethodRefactor();
        }
    }
}