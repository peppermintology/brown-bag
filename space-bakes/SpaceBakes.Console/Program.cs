using BrownBag.SpaceBakes.Console;


Console.WriteLine("############################################################");
Console.WriteLine("# Placing orders using Task.Run()");
Console.WriteLine("############################################################");

var taskSpaceBakes = new SpaceBakes();
var t1 = Task.Run(() => taskSpaceBakes.PlaceOrder(["Blueberry Muffin", "Latte", "Carrot Cake"]));
var t2 = Task.Run(() => taskSpaceBakes.PlaceOrder(["Espresso", "Lemon Drizzle Cake", "Almond Croissant"]));
Task.WaitAll(t1, t2);
taskSpaceBakes.RetrieveOrders().ForEach(e => e.ForEach(i => Console.WriteLine(i)));

Console.WriteLine("\r\n");
Console.WriteLine("############################################################");
Console.WriteLine("# Placing orders using Parallel.ForEach()");
Console.WriteLine("############################################################");

var paralellSpaceBakes = new SpaceBakes();
Parallel.ForEach(
    new List<List<string>>()
    {
        new() {"Blueberry Muffin", "Latte", "Carrot Cake"},
        new() {"Espresso", "Lemon Drizzle Cake", "Almond Croissant"},
    },
    order =>
    {
        paralellSpaceBakes.PlaceOrder(order);
    }
);
paralellSpaceBakes.RetrieveOrders().ForEach(e => e.ForEach(i => Console.WriteLine(i)));

Console.WriteLine("Done");