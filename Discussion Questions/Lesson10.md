
C# Lesson 10 Discussion Questions

 1. Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols, like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt? 
ENUM Ranks  {PVT, PVTWO, PFC, SPC, SGT, SSG, SFC, MSG, CSM}
ENUM OFFICERS {ONELT, TWOLT, CPT, MAJ, LTC, COL, LTGEN, MAJGEN, GEN}
2. Using the Ranks enum, assign a rank to yourself or a friend.
RANKS.MARSHA = {SSG};
 3. Determine the numeric index of particular ranks, using the Ranks enum.
RANK.ENLISTED {0,1,2,3,4,5,6,7,8};
RANK.COMMISSIONED {0,1,2,3,4,5,6,7,8};
 4. How do you select the type of an enum? 
You select a type of enum based on the appropriate type, based on the memory allocation
5. Are structs stored on the stack or on the heap? What about enums? 
Structs are stored on the stack. Enums are stored on the stack as well.
6. Declare a struct named DOD with four branches. 
Struct DOD
{
Private string Navy, Airforce, Army, CoastGuard;
}
7. Why can’t you create a default constructor for a struct?
You cannot create a default constructor for a struct, because one is always automatically created by the compiler.
 8. What is CIL? What does the CLR do to the CIL?
CIL is “Common Intermediate Language”= it compiles your programming language like C# and translates it to machine readable byte code.
CLR is the “Common Language Runtime” = it compiles the machine readable byte code and translates it to binary code.

