1.  What is an interface as the term is used in object-oriented programming?
	A way to require your classes to have a certain behavior. A contract.
2.  How do you define an interface?
	As public, recommended to use I as a prefix to identify an interface
3.  Can an interface have variables, fields or properties?
	No, because interface does not support functionality.
4.  How do you define a method in an interface?
	Int compareObject()
{	

	Return x;
}
5.  Can you instantiate an object through an interface?  Why or why not?
	Yes you can instantiate an object through an interface.  Assign object to interface type.
Same method in two different interfaces , you must use fully qualified name.
Int IJourney.NumberOfLegs()
{
Return x;
}
Interface does not support constructor, deconstructor, variables, parameters..ect.. no functionality is supported.
6.  Using the new keyword, can you declare a reference to an interface?
No, because you cannot create an instance of an interface.
7.  Can an object inherit from multiple interfaces?  Can a class implement multiple interfaces?  If so, how can it do so?
Yes.  Yes.  
8.  What does it mean to explicitly implement an interface?
By using the fully qualified name and declaring a return value to differentiate the methods with the same name in different interfaces.
9.  What are the restrictions on interfaces?
NO contructors, No deconstructor, no access modifier, no nested types, cannot interface from class or struct.
10.  What is the difference between an abstract class and interfaces?
Creating instances of an class is not allowed by using the abstract keyword, The difference is that an abstract class still supports functionality and an interface does not.

Abstract class is an abstraction of common functionality rather than an entity in its own right.
To declare that creating an instance of a class is not allowed you can use the keyword abstract.

11.  What is an abstract method?
A contract, it cannot be private, must be overridden, an inheriting class provides its own implementation of that method
12.  What is a sealed class?
Sealed the class and it cannot be a base class.
13.  What is a sealed method?
The last implementation of a method.

