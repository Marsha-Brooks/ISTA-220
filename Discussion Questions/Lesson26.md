



Discussion Questions
Lesson 26 Chapter 18
Answer the discussion questions in writing.
1. You are building a help ticket system. You want to ensure that the older the ticket, the sooner it will be handled by the team. For example, a ticket submitted a week ago has a higher priority than a ticked just submitted. What kind of data structure would you use, and why?
You would use a Queue<T> collection class because it is a “First In First Out mechanism”
2. You are building a tracking system for seasonal agricultural farm labor. The labor requirements vary widely, depending on the season. Your requirement is that the newest hires are terminated ﬁrst, and that our more experienced hires are kept longer. What kind of data structure would you use, and why?
You would use the Stack<T> Collection class because it is a “Last in Last out mechanism”
3. You are building a transaction database. Your requirement is that the database adds data very quickly, and that deletions, updates, and searches happen infrequently. In other words, data is typically added in the order in which the transaction occurs. What kind of data structure would you use, and why?
I would use a LinkedList<T>  data structure because of the ease in which you can step through the references to review the transactions.
4. You are building an analytical database. Your requirement is that the database handle queries very quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates. What kind of data structure would you use, and why?
You would use a Dictionary<TKey,TValue> collection class  because the key and value properties are read-only and can be queried but no changes can be made.  It is also a data structure that allows for quick  queries based on KeyValuePairs.
5. You are building a personnel directory, where searched are performed by last name, ﬁrst name, middle name. What kind of data structure would you use, and why?
You would use a SortedList<T> Collection class because the sorted nature of the collection makes it a perfect fit for a personnel directory.  
6. You are building a username/password database. Your requirement is that updates happen frequently (when users change their passwords) and that searches (to authenticate users) happens extremely quickly. What kind of data structure would you use, and why?
I would use a HashSet<T> data structure because it is optimized for performing set operations, determining sets  and generating the union and intersection of sets.
7. What is a lambda expression? Give an example. Why would we use a lambda expression?
A lambda expression is an expression that returns a method.  Made up of a list of parameters and a Method body.  The lambda expression does not define the method name and the return type is inferred from the context in which the lambda expression is used.  An example is the argument within the Find Method as it refers to List<T> and LinkedList<T> collection classes.  The Find method contains a lambda expression that performs the work within the method.  You would use a lambda expression is to specify a predicate within a method.
8. What is the diﬀerence between lambda expressions and anonymous methods? What are the advantages of each?
The difference between lambda expressions and anonymous methods is that anonymous methods were the precursor to the lambda expression and are not as flexible, anonymous methods require the application of the “delegate” keyword.  The lambda expression is more streamlined and pervades many of the more advanced aspects of C#.  Lambda expressions are recommended over anonymous methods in code.  The advantage of the anonymous method is it gives a way to define delegates without having to create a named method, by providing the definition of the method body in place of the method name.
