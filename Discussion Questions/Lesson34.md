



C# Discussion Questions
Lesson 34
Chapter 22, pages 493 – 514


 Answer the discussion questions in writing.
 1. Explain the difference between the concepts of associativity and precedence.
The difference between associativity and precedence is that associativity is the left to right or right to left association in which the expression is interpreted.  Using an assignment operator, which used right to left associativity; assigns the value on the right side to the type on the left side of the operator.  Most all other operators have left to right associativity. The flow is left to right, the order in which you read the expression.
Precedence on the other hand is the order in which the operators are applied.  A multiplication operator will be executed before an assignment operator so it has higher precedence than the assignment operator.
 2. Explain the difference between the concepts of binary and unary operators. 
A Binary operator takes two explicit arguments and a unary operator takes one specific argument.

3. List four constraints imposed by C# with respect to operator overloading.
1. All operators must be public.
2. All operators must be static
3.  You cannot change the precedence or the associativity of the operator
4.  You cannot change the meaning of the operator






 4. What is the syntax for overloading operators? Discuss access, scope, return value types, and parameter types and multiplicity.


 5. What are symmetric overloaded binary operators and how do they differ from non-symmetric overloaded binary operators?
Declares a binary+ operator whose first parameter is an object and whose second parameter is a data type. The real logic behind the operator is held in a single place.
Where a non-symmetric type must use a structure that implements a constructor that creates the object from the data type. This converts the data type into the object prior to the implementation of the binary operator.
 6. Can you overload compound assignment operators? If so, please state how you do so. If not, explain 
why not. 
A compound assignment operator is an overloaded version of a simple operator. When you use the compound assignment operator you are implementing the overloaded version of the simple operator

7. What is the difference between overloading increment and decrement operators for value types and reference types?
Within a class, which is a reference type, the assignment postfix statement = now makes the variable postfix refer to the same object as now.  Updating now..updates postfix.  However, when applying the same assignment in a struct, which is a value type, the now and the postfix are treated as two separate entities and go individually go unchanged when updates are made individually.
 8. Why do we overload some operators in pairs? 
This is based on the neither-or-both rule that applies to operator pairs, operators that naturally come in pair.
9. What is the difference between widening conversion and narrowing conversion? 
Widening conversions refer to conversion where no data is at risk of loss and the conversion is safe such as converting an int to a double.  The int is smaller than the double and is an implicit conversion.  Because double is a larger value type than int, it is called a “Widening Conversion”.  The exact inverse applies to the concept of a “narrowing conversion” which would be an unsafe conversion with the risk of data loss and would require an explicit cast.


10. What is the difference between explicit conversion and implicit conversion?
An implicit conversion is a safe conversion that has no risk of data loss and will not throw an exception and does not require casting. The explicit conversion is a risk, an unsafe conversion that risk losing data and can throw an exception. It requires a cast.
