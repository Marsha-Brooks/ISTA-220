C# Lesson 22  Discussion Questions

1. Give five examples (using valid C# code) of the five bitwise operators listed in the text.
	a.  NOT(~) operator:   bits &= ~(1<<5)
	b.  left-shift (<<) operator:  bits &= ~(1<<5)
	c. right-shift (>>) operator: bits &= ~(1>>5)
	d.  OR (l) operator:  bits l= (1<<5)
	e.  AND (&) operator:   bits &= (1>>5)
	f. XOR (^) operator:    bits[6] ^= true;
 2. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valid C# code. 
3. Explain in detail this code: bits & (1 << index);  
The code listed above takes two operands, the value of the variable “bits” and the bit position represented by (1<<index) which contains a left-shift binary operator that shifts the position within the index to the left as many spaces as the value of index(far right value) specifies.  The bitwise operator AND(&) will compare the binary expression of the variable bits and the binary expression of the value in the index position presented by (1<<index). And returns a 1 in each position where both of the operands have a 1.  
4. Explain in detail this code: bits |= (1 << index);
The code listed above takes two operands, the value of the variable “bits” and the value of the position represented by the (1<<index) which contains a left-shift binary operator that shifts the position with th index to the left as many spaces as the value of index (far right value) specifies.  The bitwise operator OR (l) compares the binary expression of the variable bits and the binary expression of the value in the index position presented by (1<<index) and returns a 1 in each position where either of the operands have a 1.
5. Explain in detail this code: bits &= (1 << index);
The expression uses the compound assignment operator &= to set the bit at position 6 to 0.
6. How does C# interpret this? bool peek = bits[n]; 
Retrieves the value of bool at the index [n] to check the value
7. How does C# interpret this? bits[n] = true; 
Set the bit at index [n] to true
8. How does C# interpret this? bits[n] ^= true; 
This is in a read/write context.  The XOR operator is used to invert the value of the bit at index 6 in the bits variable
9. Assume that users were assigned read, write, and execute permissions according to this scheme: 
read = 1, 
write = 2, 
execute = 4.
 How would you interpret the following user permissions? 
 (a) permission = 0 :  no permissons
(b) permission =1 : read only 
(c) permission = 2:  write only
 (d) permission = 3 : read/write
(e) permission = 4 : execute
(f) permission = 5 : read/execute
 (g) permission = 6 : write/execute
(h) permission = 7 : full control

10. Answer the previous question by converting the decimal permissions into binary permissions. What does this tell you about using this schema of permissions?
A) 00000000
B) 00000001
C) 00000010
D 00000011
E 00000100
F) 00000101
G) 00000110
H) 00000111
It tells me that to use binary permissions would be exhausting and confusing.
