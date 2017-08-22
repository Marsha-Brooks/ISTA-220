C# Discussion Questions Lesson 8


1. What is the difference between deep copy and shallow copy? 
The difference between deep copy and shallow copy is in reference to the cloning process.  When you clone the values contained in an object into a new instance of that object: This is deep copy.  When you  clone only references into an new instance of an object:  This is shallow copy. 
2. What is the value of a reference after you declare and initialize it? 
The value of a reference type after you declare and initialize it is the value of the object it is a reference of.
3. How do you declare a value type?
You declare a value type by identifying the variable type then assigning the value with an assignment operator.
 4. How do you declare a reference type? 
You declare a reference type by creating a new instance of the object and then assign the reference variable.
5. Does C# allow you to assign NULL to a value type?
 Yes
 6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?
No, you cannot assign a nullable value type to a non-nullable variable of the same type because it is an illegal function in C#, an ordinary value type cannot contain a null where a nullable value type can contain a null. 
 7. What is the difference between the stack and the heap? 
The difference between the stack and the heap is the way that memory is managed at runtime.
The stack is a neatly piled, organized allocation of memory for each parameter and local variable of a methods, created as the methods are called, whereas the heap is an unorganized assortment of memory allocations for new objects, each object has a reference to it contained in the stack.
8. What does it mean when we say that all classes are specialized types?
All classes are specialized types because each class is a collection specializing in specific functions.  
 9. What does ref do? 
The keyword ref creates to the original argument.  Meaning that the changes you make to the referenced augment will affect the original argument.
10. What does out do? 
The out keyword creates an alias to the original argument This requires the method to assign a value to the variable which is made to the actual argument
11. Describe boxing and unboxing in your own words. 
Boxing is assigning or initializing a variable of the object type or automatically copying an item from the stack to the heap.  Unboxing is when the compiler generated code extracts the value assigned to the boxed variable and assigns to another variable, through casting.
12. What does cast do? 
Casting is when the compiler checks whether converting an item of one type to another is safe before actually making the copy.  You prefix the object variable with the name of the type in (); i = (int)o;
