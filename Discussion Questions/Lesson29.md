


C# Discussion Questions 
Chapter 19, pages 423 – 438 


1. What is an enumerable collection? 
A collection that implements the System.Collection IEnumberable interface.  
2. What properties and methods does the IEnumerable interface contain? 
The IEnumberable interface contains the:
GetEnumerator Method
3. What properties and methods does the IEnumerator interface contain? 
The IEnumberator interface contains: 
a. MoveNext Method
b. Current Property
c. Reset Method
4. What values does the MoveNext() method return? What does it do? 
The MoveNext() method returns a true or a false.  True if there is an item in the next position an false if there is not.  It moves the pointer down to the next item in the list.
5. What values does the Reset() method return? What does it do? 
The Reset() method  does not return a value its return value is void…it simply moves the pointer back to the position right before the first item in the list.
6. Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety? 
The IEnumberator is a “not-type-safe” interface because the Current property returns an object.
The IEnumberable is a “not-type-safe” because it returns a Enumerator object.  You can implement type safety in both of the interfaces above by using the “type safe” generic versions available in the .NET framework library. These are safe because they utilize the generic <T> parameter.
7. Why don’t recursive methods retain state when used with data structures like binary trees? 
Recursive methods do not retain state when used with data structures like the binary tree because
Recursive methods do not retain state between method calls or retain the position in the structure. 
8. How do you define an enumerator?
You define an enumerator explicitly by using the drop-down context menu.
 9. What is an iterator?
An iterator is a way, a process by which you can specifies a sequence that an enumerator should use for returning its values.
 10. What does yield do?
The yield keyword is like a halt button in the process that passes back a value to the caller. It identifies the value that should be returned by each iteration.
