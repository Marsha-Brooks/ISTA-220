C# Chapter 15 Discussion Questions  

 1. What is the difference between a property and a field? 
The difference between a property and a field, is a field instance class variable, it is a reference to a value on the heap and a property is a cross between a field and a method.  When declaring a property, the compiler generates code that calls the accessor and modifier methods (get, set) and does not reference a value directly. The get and set accessors reference the property not a field.  
2. What is the difference between a property and a method?
The differences between a property and a method are, a property cannot take parameters, It contains only two blocks of code; a get block and a set block, property cannot be uses as a “ref” or an “out”  argument to a method, property cannot contain other methods, fields or properties and the use of properties focuses more on the property of the object while using methods focuses on the behavior of the object. 
3. What is your understanding of encapsulation? 
Encapsulation is the use of access modifiers to hide the content of your code from the outside world.
4. Some languages are case insensitive, that is, an ‘a” and an “A” are considered to be the same letter. C# is case sensitive. What implications does this have regarding the naming of variables, methods, and other identifiers? Do you think that the difference in case in the initial character of two different identifiers is sufficient to distinguish them?
Only differing the naming convention of your variables by using upper and lowercase letters can cause all kinds of confusion in code.  Example you have a private field that is lowercase employeeID and the property EmployeeID provides public access to this field.  The get and set accessors can end up referencing the property EmployeeID instead of the field employeeID and cause a recursive loop and an StackOverFlowException to be thrown, simply by mistakenly using a capital E instead of a lowercase e.  That is why it is recommended that an “underscore” be used to prefix private fields in these situations.

5. Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use s write-only property. 
An example where you might want to use a read-only property is when designing background features of a game; scenery ect that would be constant and unchanged.

An example of a write-only property would be the answer to a security question? Input of a PIN?

6. Can you think of a reason why you might ever want to make getters and setters private? Give an example. Also, make a case why getters and setters should never be private. 
The reason you would want to make a getter private, when you set the get to private you would only be able to use the property in the read context within the containing type.
The reason you would want to make a setter private, when you set the setter to private you control the ability to change the value that is passed to the set accessor within the containing type

I cannot make a case for why getters and setters should never be private; because there are so many varying circumstances.  With Encapsulation a foundation of Object Oriented Programming, the use of access modifiers are key to the proper functionality accessibility of code. The only cause for setters and getters to never be private would be to isolate this argument to a single case where you create a program in which you want your user to be able to absolutely manipulate the properties declared in a given containing type.

7. What are restrictions on the use of properties? 
a.  Can only be assigned value after the class or struct have been initialized.
b.  cannot be used as a “ref” or an “out” to a method.
c.  get and set accessors cannot take any parameters
d.  cannot be declared using keyword “const”



8. What is an object initializer? What is the syntax for an object initializer?
And object initializer is used when you create an instance of a class, and you initialize it by specifying the names and values for any public properties that have set accessors.

The syntax is as follows:
Triangle tri5 = new Triangle(“Equilateral Triangle”) {Side1Length = 3, Side2Lenght =3, Side3Length = 3};
