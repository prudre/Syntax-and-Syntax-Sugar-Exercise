namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //inferred typing, String Interpolation, and Ternary Operator

            var answer = 4;
            var response = (answer < 9)?$"{answer} is less than mine" : $"{answer} is greater than mine";
            Console.WriteLine(response);

        }
    }
}
