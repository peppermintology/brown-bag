using System.Collections.Immutable;

namespace BrownBag.SpaceBakes.Console;

public class SpaceBakes
{
    public SpaceBakes()
    {
    }

    private Queue<List<string>> _orders = new();

    public void PlaceOrder(List<string> items)
    {
        Thread.Sleep(TimeSpan.FromSeconds(3));
        _orders.Enqueue(items);
    }

    public ImmutableList<List<string>> RetrieveOrders()
    {
        return [.. _orders];
    }
}