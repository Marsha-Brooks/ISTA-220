C# Discussion Questions Chapter 11,  Lesson 13

1. How do you define a method that takes an arbitrary number of arguments? 
	You define a method that takes an arbitrary number of args by using the “params” keyword as an array parameter modifier when you define the method parameters.
2. How do you call a method that takes an arbitrary number of arguments? 
	You call a method that takes an arbitrary number of arguments by calling it using any number of parameter arguments without worrying about creating an array, because the compiler counts the number of arguments and creates an array of that size, fills the array with the args and then calls the method by passing the single array parameter.
3. Why can’t you use an array to pass an arbitrary number of arguments to a method?
	You cannot use an array to pass an arbitrary number of arguments to a method, because if you define an array, you have created a fixed parameter list that you cannot pass an arbitrary list of arguments.
 4. How many parameters can a method have? 
	A method can have as many parameters as you want it to, you just have to ensure you use the correct syntax and the right parameters format.
5. Do parameter arguments have to have the same type? 
	They do, unless you use a parameter array of type object.
6. What is the difference between a method that takes a parameter argument and one that takes optional arguments? 
	The difference between a method that takes optional arguments and one that takes parameter arguments is that one has a fixed list of parameters and one has an arbitrary list of parameters.  The method using the optional arguments is a fixed list and the method using the parameters arguments is a list of arbitrary arguments.
7. How do you define a method that takes different (and arbitrary) types of arguments?
	You define a method that takes different (and arbitrary) types of arguments by using a parameters array of type object to declare a method that accepts any number of object arguments, allowing the arguments passed in to be of any type.
