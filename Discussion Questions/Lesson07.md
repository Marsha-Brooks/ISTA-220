C# Programming Lesson 7 Discussion Questions
Answer the discussion questions in writing.
1.	What is a class? According to the book, what does a class “arrange?”
a.	A class when created is a way to systematically arrange information and behavior into a meaningful entity.
b.	A class arranges information and behavior OR data and methods.
2.	What are the two purposes of encapsulation?
a.	Encapsulation limits access of code to the scope of the class or method.
b.	Combines methods and data in class
3.	How do you instantiate an instance of a class? How do you access that instance?
a.	An instance of a Class is created using the word “new” 
b.	You access the instance of the class(object) by providing a constructor and initializing the parameters
4.	What is the default access of the ﬁelds and methods of a class? How do you change the default?
a.	The default access of the fields and methods is the default constructor automatically created by the compiler when a new instance of a class is created.
b.	You change the default by creating a custom constructor; however if you create a custom constructor, you still have to go back and create another default constructor.
5.	What is the syntax for writing a constructor?
a.	The syntax for writing a constructor is as follows
b.	Public Circle() {radius= 0;}
6.	What is the diﬀerence between class ﬁelds and methods, and instance ﬁelds ad methods? How do you create class ﬁelds and methods?
a.	The difference between class fields and methods and instance fields and methods is that the class are in class scope and accessible to all instances of that class. However the instance are limited to the scope of the instance class.  
b.	You create class fields using the word this , this.x, this.y
You create instance methods by calling an instance of the method from the class.
7.	How do you bring a static class in scope? Why would you want to bring a static class in scope?
a.	The way you bring a static class in scope is by applying a “using” statement.
b.	You would want to bring a static class into scope if you wanted to write code where you didn’t want to use the full qualified name of the instance methods within that class.
8.	Can you think of a good reason to create an anonymous class? What is it?
a.	A good reason to create an anonymous class would be to create a class that could not be manipulated easily because the compiler creates a name that you do not know.
9.	What is polymorphism as this term is used in computer science? This is not in the book.
a.	Polymorphism is having a parent template that allows inheritance, but the inherited 
Objects can modify some of the functional traits to suit the new instance.
10.	What is message passing as this term is used in computer science? This is not in the book.
Message passing is a form of communication between objects, processes or other resources used in object-oriented programming, inter-process communication and parallel computing.11. What was the ﬁrst object-oriented programming language?
12. Consider this quote by Alexander Stepanov:
1
I ﬁnd OOP technically unsound. It attempts to decompose the world in terms of interfaces that vary on a single type. To deal with the real problems you need multisorted algebras — families of interfaces that span multiple types. I ﬁnd OOP philosophically unsound. It claims that everything is an object. Even if it is true it is not very interesting — saying that everything is an object is saying nothing at all.
Who is Alexander Stephanov? What do you think about this quote?

I think identifying everything as an object is as effective as saying everything is matter…oops..what about  anti-matter or Dark matter?   Everything is in fact matter but of so many different varying kinds that applying generalized logic would limit the capacity of the understanding of the diverse types of matter and our ability to experience dimensions that we have yet to explore.

