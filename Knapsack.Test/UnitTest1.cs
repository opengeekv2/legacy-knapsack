namespace Knapsack.Test;
using NUnit;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var knapsack = new List<Tuple<string, int, int>> {
            { new Tuple<string, int, int>("Pants", 1, 10) },
            { new Tuple<string, int, int>("Underpants", 10, 1) },
        };
        var knapsackSolver = new KnapsackSolver();
        knapsackSolver.SolveKnapsack(knapsack, 10);
        
    }
}