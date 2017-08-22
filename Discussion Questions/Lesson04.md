C# Programming Lesson 4 Discussion questions

1.	 What are the possible values of a Boolean Express?
a.	True or False
2.	 List eight Boolean Operators.
a.	NOT operator (!)
b.	Logical && (AND)
c.	Logical ll (OR)
d.	Less than <
e.	Greater than >
f.	Less than or equal to <=
g.	Greater than or equal to <=
h.	== equality operator True if match
i.	!= equality operator True if doesn’t match

3.	 What are the difference in how short circuiting works for the (AND) && Logical operator and the II (OR) operator?
a.	The AND operator must result in both arguments being TRUE for whole expression to be true.  If the left argument is FALSE..the RIGHT argument does not need to be compiled.
b.	The OR operator must result in at least one argument being TRUE for the expression to be TRUE.  If the left argument is TRUE, the right argument does not need to be compiled.
4.	Look at the list of operators.  What operator has the highest precedence? And Which has the lowest precedence?
a.	In the Primary category of operators the Parentheses has the highest order of precedence and the lowest is the Assignment operator in the Assignment category (=).
5.	 In an if or else construction using multiple lines of code, what effect does the effect of curly braces have?  
a.	 The Curly braces create blocks, which are series of statements in a group.  This eliminates the need to create additional methods and call methods.  Instead the multiple statements can be grouped as needed in the individual if and else statements.
*if no curly braces..only the first line of code is executed.

6.	 In a switch statement, what happens if you omit break?
a.	If you omit break in the switch statement the compiler will continue to fall through the code without stopping and most likely create a compiler error If there are statements between case labels.  You can intentionally eliminate the break statement if you want to apply a statement two more than one case label, but no statements can exist between the case labels that are in sequence before the respective statement.  
b.	Case statement Is true..the break statement exits the Switch statement.
