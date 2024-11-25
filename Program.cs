namespace LinqDeferredExecution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 2, 3, 4, 50 };

            var subset = numbers.Where(c => c < 10).Where(c => c > 2);//3,4


            // LINQ statement evaluated here!

            foreach (var i in subset)
                Console.Write($"{i} - ");


            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            numbers[0] = 1;

            //Evaluated again!
            foreach (var j in subset)
                Console.Write($"{j} - ");



            //Exceptions
            /*ToList, ToArray, ToDictionary, ToHashSet, ToLookup, Count, LongCount,
             Sum, Min, Max, Average, Aggregate,
             First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault,
             ElementAt, ElementAtOrDefault, Any, All, Contains
            */

        }
    }
}
