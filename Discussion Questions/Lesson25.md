


 C# Discussion Questions
Lesson 25 Chapter 17

1. What is a type parameter?
A parameter “type” is a generic placeholder for a real type.  The real type is identified and instantiated at run time.

2. What does a type parameter do?
A “type” parameter is a placeholder.  That can be instantiated as a reference type or a value type.  The “type” parameter eliminates the need to cast, box and unbox variables.

3. How many type parameters can a generic class have?
A generic class can have innumerable “type” parameters.  As many as the programmer sees fit.

4. What is the diﬀerence between a generic class and a generalized class?
A generalized class is an object-based class.  There is a single implementation of this class and its methods take object parameters and return object types.  You use instances of this class, which requires casting data to and from the object type.
A generic class uses “type” parameters.  Each time you use a generic class with a type parameter the compiler generates an entirely new class that has functionality defined by the generic class.  Generic classes are “type” specific classes on demand called constructed types that are treated as distinctly different types.  

5. What is a constraint? How do you specify a constraint?
Constraints are conditions that ensure that the type parameter used by a generic class identifies a type that provides certain methods.
You can limit the type parameters of a generic class to those that implement a particular set of interfaces and therefore provide the methods defined by those interfaces.

6. What is a generic method? How do you deﬁne a generic method?
A generic method is used to specify the types of the parameters and the return type by using a type parameter in a manner similar to that used when you define a generic class. You define a generic method by using the same type parameter syntax you use when you create generic classes.

7. What do we mean when we say that a generic type interface is invariant?
A generic interface that has covariant or contravariant generic type parameters is called variant.
You can declare variant generic interfaces by using the in and out keywords for generic type parameters.
8. What do we mean when we cay that a generic type interface is covariant?
Specifies the out qualifier for covariant type parameters.  Reference the covariant type parameters only as the return types from methods and not as the types for method parameters.
9. Does covariance work with value types? Does it work with reference types?
Covariance does not work with value types only with reference types.

10. What do we mean when we cay that a generic type interface is contravariant?
Specify the in qualifier for contravariant type parameters.  Reference the contravariant type parameters only as the types of method parameters and not as return types. 
