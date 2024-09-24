namespace Knapsack;

public class KnapsackSolver
{

    public void SolveKnapsack(List<Tuple<string, int, int>> knapsack, int maxWeight) {
        List<Tuple<string, int, int>> auxKnapsack = [];
        knapsack.Sort((item1, item2) => item2.Item3 - item1.Item3);
        foreach (var item in knapsack) {
            var itemName = item.Item1;
            var itemWeight = item.Item2;
            var itemValue = item.Item3;
            int weightSum = 0;
            foreach (var auxKnapsackItem in auxKnapsack) weightSum += auxKnapsackItem.Item2;
            if (weightSum + item.Item2 > maxWeight) break;
            auxKnapsack.Add(item);
        }
    }

}
