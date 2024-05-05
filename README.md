# Brown Bag 👜

What is a Brown Bag Session?
> An informal meeting or training session that generally occurs in the workplace around lunch time

# Projects 📋

## Space Bakes 🧁
Spacebakes is a ficticious bakery that serves all sorts of baked goods so delicious they are considered out of this world! 🌍

### Problem - Accessing collections in a multi-threaded environment
The standard collections found in `System.Collections.Generic` are thread-safe but only when accessed from the same thread. Once multiple threads are involved they can no longer be relied upon to behave in a predictable manner. For just this reason .NET provides several thread-safe collections.

#### Concurrent Collections
Thread-safe collections can be found in the [`System.Collections.Concurrent`](https://learn.microsoft.com/en-us/dotnet/api/system.collections.concurrent) namespace and provide thread safe implementations of their counterparts from the `System.Collections.Generic` namespace.

 - `BlockingCollection<T>`
 - `ConcurrentBag<T>`
 - `ConcurrentDictionary<TKey, TValue>`
 - `ConcurrentStack<T>`
 - `ConcurrentQueue<T>`
 - `IProducerConsumerCollection<T>`

#### Concurrency vs. Parallel vs. Async
##### Concurrency
> A condition that exists when at least two threads are __making progress__. A generalised form of parallelsim that can include time-slicing as a form of virtual parallelism.

##### Parallelism
> A condition that arises when at least two threads are __executing__ simultaneously.

##### Asynchrony
> A process that allows an application to execute additional instructions without blocking the main application flow.

### References & Further Reading
- [Thread Safety](https://en.wikipedia.org/wiki/Thread_safety)
- [Defining Multithreading Terms](https://docs.oracle.com/cd/E19455-01/806-5257/6je9h032b/index.html)
- [Threading in .NET](https://learn.microsoft.com/en-us/dotnet/standard/threading/managed-threading-basics)
- [Asynchronous Programming Patterns in .NET](https://learn.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/)
- [Parallel Programming in .NET](https://learn.microsoft.com/en-us/dotnet/standard/parallel-programming/)