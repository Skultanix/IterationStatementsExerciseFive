namespace IterationStatementsExerciseFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Please enter in a series of numbers each separated by a comma and a space ("", ""). ");
            var userSeries = Console.ReadLine();
            int[] seriesArray = userSeries.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            var maxVal = 0;

            foreach (var number in seriesArray)
            {
                if (number > maxVal)
                {
                    maxVal = number;
                }
            }

            Console.WriteLine(string.Format(@"The maximum value in the series is ""{0}"".", maxVal));
        }
    }
}