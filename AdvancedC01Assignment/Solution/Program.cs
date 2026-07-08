using System.Runtime.CompilerServices;
using Solution;

Console.WriteLine("Advanced C# S01");
/* 
Q1: What is a generic class? 
    - A generic class uses type parameters that are replaced with actual types when you create an instance. 
    The type parameter T acts as a placeholder.
Why use generics?
    - Type Safty, Perfomance, Code Reuse, IntelliSense. 

Q2: Write a generic class Container<T> with Add and Get methods.
    - Container.cs

Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
    - Generic classes can have multiple type parameters. Common examples: Dictionary<TKey, TValue>, Tuple<T1, T2>

Q4: What is a generic method? 
    - A generic method declares its own type parameter(s). It can exist in both generic and non-generic classes. 
    - The compiler often infers the type argument.
Write Swap<T> method.
    - Utility.cs

Q5: Write a generic method FindMax<T> that finds maximum value
    - Utility.cs

Q6: What is a generic interface? 
    - Generic interfaces define contracts with type parameters. 
    - Classes implementing them specify the actual types. 
Write IRepository<T>.
    - IRepository.cs

Q7: What is the 'struct' constraint? 
    - it means that T Must be a value type.
Write an example.
    - public class Calculator<T> where T: struct

Q8: What is the 'class' constraint?
    - it means that T Must be a reference type.
Write an example.
    - public class ProductRepo<T> where T: Product

Q9: What is the 'new()' constraint? 
    - T must have a public parameterless constructor (public T())
Write an example.
    - public class Factory<T> where T : new()
        {
            public T Create() => new T();
        }

Q10:  What is the interface constraint? 
    - T must implement interface
Write an example.
    - public class IRepo <T> where T: IInterface

Q11: What is the base class constraint? 
    - T must inherit from BaseClass
Write an example.
    - public class IRepo <T> where T: BaseClass

Q12: How do you apply multiple constraints? 
    - You can combine multiple constraints for a single type parameter, 
    - and have different constraints for different type parameters
Write an example. 
    - public class EntityManager<T> where T : class, IEntity, new()

Q13: What does the 'default' keyword do in generics?
    - null => reference type && 0/false for value type

Q14: Write a SafeList<T> that returns default when the index is invalid.
    - Constrains.cs

Q15: What is covariance? Explain the 'out' keyword.
    - Covariance allows you to use a more derived type than originally specified. 
    - Marked with out keyword. T can only appear in output positions.

Q16: What is contravariance? Explain the 'in' keyword.
    - Contravariance allows you to use a less derived type than originally specified. Marked with in keyword. 
    - T can only appear in input positions.

Q17: What is the difference between covariance and contravariance?
    - Direction	    Derived → Base	        Base → Derived
    - T Position	Output only (return)	Input only (parameter)
    - Example       IEnumerable<out T>      Action<in T>
    - Think of as	Producer of T	        Consumer of T

Q18: How do static members work in generic types?
    - Each closed generic type has its own copy of static fields. List<int> and List<string> have separate static data!

Q19: How can you inherit from a generic class?
    - Generic classes can inherit from other generic or non-generic classes. Several patterns are possible.

*/

// Q20: Complete Exercise -Create a generic Cache<TKey, TValue>with Add, Get, Remove, Contains, and expiration support. 
//     - Cashe.cs

Cache<int, string> cache = new();
cache.Add(1, "Ahmed",TimeSpan.FromSeconds(10));
cache.Add(2, "Ali", TimeSpan.FromSeconds(30));
Console.WriteLine(cache.Contains(1));
Console.WriteLine(cache.Get(1));
cache.Remove(2);
Console.WriteLine(cache.Contains(2));