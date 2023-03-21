# C# Essentials
### Basics
- Visual Studio is the IDE for developing .NET Apps. 
- A place where U develop the Applications using a certain programming language at an industrial Scale. 
- VS is used for developing Applications on .NET Technology.
- .NET is a technology developed by MS for creating various kinds of Applications like Terminal Based, Web Based, Desktop Based(Windows platform), Database centric, Service Based, Micro controller level Based Applications and many more. 
- It is platform independent and Language Independent. 
- U can create .NET Apps in any platform(Win, Linux or Mac) and run on any of the other platforms.
- Language Independence means that U create a code in one acceptable Programming language and its compiled unit can be consumed in other programming language of .NET.
- Programming Languages accepted by the .NET Technology are called as CLS Compliant Languages or simply .NET languages.
- How language independency is achieved:
	- The code of the .NET Language will be compiled by its language compiler. The code will be converted into an ASSEMBLY. The extension of the ASSEMBLY files are either EXE or DLL.
	- Each assembly interally has 2 parts: MSIL(MS Intermediatory language) that has language independent code and Metadata(Info about UR Code like additional dependencies of UR code).
	- When the Application is to be executed, it can be executed only in the .NET Execution Environment called as CLR(Common Language Runtime). CLR is the part of every shippment of Windows OS since Windows 7.
	- In the CLR, lies the JIT Compiler which compiles the MSIL code to the native optimized code that will execute on the target platform. Eventually UR code becomes platform independent as well as Language Independent.
- What is C# in this picture?
	- C# is the programming language with many of its features coming from C++ and few from Java and VB. Ofcourse, it has added many new features that are not available in other languages(Atleast during its inception).
	- C# is a language built on .NET and exclusively for .NET. It is powerfull and faster to execute in the .NET System. This makes it the most popular language for developing .NET Apps. 
-What are the other programming languages supported in .NET?
	- C++, VB, Python, Cobol, Pascal, Perl, Ruby on Rails and many more languages are supported by .NET. 
	- All these languages define their compilers based on CLS(Common Language Specification). If a code is mentioned as CLS compliant, then the code is usable on any other .NET Language. CLS define the guidelines for any new programming language that wants to enter the .NET Programming language Family. 
	
# How to use VS 2022
1. Visual Studio comes with lots of features for developing rich Industrial scaled Apps. 
2. The VS can be customized by going the Menu option: Tools->Options where the Dialog box shows various options for the VS customization. 
3. The Theme, Line Numbers, Word Wrap as well as Font selection: These are the prominent customization that developers do. 
4. VS groups UR code into projects and solutions. A project is a group of files that are built to form an Assembly. U cannot compile a file Directly in VS. UR code is grouped into files which are grouped into Projects and finally multiple projects are grouped into Solution. 
5. VS provides a set of Project Templates that can be used to create the Projects. These templates contain minimal code to build and if possible execute the Application. 
6. For language learning purposes we choose Console App project template. Console App is a terminal based Application which is executed thru a command Prompt.

### Console Application:
VS provides Console Application template for creating a min .NET App that will display the output on the Comman Prompt. We usually use the Console App Template for learning and testing purposes. 
The project template is Console App(.NET Framework) that can allow to develop .NET based Application that can be executed on the Windows OS. 

### Parts of the C# Program
1. C# code is written in files with extension .cs. 
2. It is recommended to have File name and the Class Name as same. 
3. C# code is based on OOP, so everything will be a part of a class. 
4. U cannot have global statements in C# .NET Framework.
5. UR classes are grouped into Namespaces. A Namespace is a conceptual grouping of UR classes within a project. Typically we use namespaces to avoid Naming conflicts. 
6. The .NET Framework itself has classes grouped into namespaces. For using any of the pre built classes of the .NET Framework, we use the namespace and refer the class. System is one such namespace. 
7. using keyword is used to have a declaration in the code that U intend to use the classes of that namespace. Below are some of the examples of using namespaces of .NET Framework. 
```
using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;

```
8. Main is the entry point of the C# program. It is case sensitive. It must have a modifier static.
9. The static makes the Main method to be invoked by the CLR without a need to create an instance of the class. 
10. Main can have only string Array as its argument. It can have either void or int as its return type. 
11. The App terminates when the Main Function completes its execution. 
12. Console is a static class defined in .NET Framework that represents the Output Window of the Application. Its WriteLine method is used to write a text or any data onto the Console Window.
13. Ctrl+Shift+B is used to build the Project and Ctrl+F5 is used to execute the Application. F5 is used to debug the Application. 

#### Reading and Writing on Console.
1. WriteLine method is used to display a Stream of Text on the Console Window. 
2. Anything U place as arg to the WriteLine will be displayed on the Console Window. Internally the value of the arg will be converted to string and displayed on the Window. 
3. Inputs are always taken as String only. The ReadLine method is used to take inputs from the Console Window. It returns string. 
4. Read method of the Console is used to take a single char and return its ascii value. Write method is similar to WriteLine but will not move itself to the next line. 
5. var is a Implicit typed variable to store any kind of data in it. var is a convinient way of creating local variables in C#. 

#### Data types in C#.
1. C# gets its data types from the Common Type System of the .NET Framework. 
2. As .NET Framework was designed to work on multiple languages, it provided a common data type system for all the programming languages of .NET. This is called as CTS(Common Type System). 
3. C# provides keywords for the data types of the CTS. 
4. The .NET Type system has broadly classified the data types into 2 parts:
	- Value Types: Primitive and store the value in them
	- Reference Types: Classes where the value will be the address of the location of the data instead of the data itself.
5. In value types we have the following types:
	- Integral Types: byte(Byte), short(Int16), int(Int32), long(Int64). 
	- Floating Types: float(Single), double(Double), decimal(Decimal).
	- Other types: char(Char), bool(Boolean)
	- User Defined Types: struct, Enums, DataTime.
6. All structs in .NET are value types. 
7. All classes are reference types.
	- There is a datatype called object(Object) in .NET that refers to Universal data type. 
	- object is a reference type. 
8. All CTS types are defined under System Namespace. 
9. We organize the code into smaller functions and call them in the Main Program. 
10. All primitive data types have functions and consts to get info about it. As all Value types are structs, they have functions and fields which can give some info  about the type. 
11. Data Conversions in C# are either implicit or explicit. Longer ranged data types store the shorter range types implicitly. But the reverse is not possible. In that case, U should type cast the data. Casting is explicit. U can use Convert class to convert any type to another in C#.
12. DateTime is a Value type that stores the Date and Time. DateTime.Now API is used to get the System Date and Time. It has other APIs to get different parts of the DateTime object. Its Parse method is used to convert a string to a valid DateTime. The String should be in the format identified by the System. 

#### Enums in C#.
- Enums are Named constants. They allow to store integral values by names represented like a group. Months of an Year could be grouped into Enum which makes the user enter any one of the specified values. This ensures that the user will not enter value that is not recognized by UR Program. 
- Enum is a UDT, so U should declare with Values and then consume it.
- System.Enum class can be used to get Info about the Enum Values at runtime and do conversions from string to enum types.
- <b>typeof</b> operator is used to get the Type Information of the Type in C#.

#### Arrays in C#.
- All arrays in C# are objects of a class called System.Array. This class has Functions and Properties to get info about the array object. 
- Like other programming languages, array elements are accessed using [] operator.
- The index will get the value of the array in that position. 
- The no of elements in the array can be obtained using Length property of the Array class.
- Rank property is used to get the dimensions of the Array. 
- GetLength() gets the length of the specified dimension of the Array. The dimension index is passed as argument. First dimension is 0.
- Array class has static methods that can give more information about the Arrays. It can be used to dynamically create Array objects. Refer the methods CreateInstance for creating instances of Arrays dynamically. 
- Copy, CopyTo and Clone methods are used to copy the contents of one array into another.

## Classes and objects
- Class is a reference type in .NET. it is instantiated using new operator. 
- Constructor is used to inject the dependencies for the object before it is fully operational. 
- Constructor is like a function that can take arguments but will not have return type. The name of the function will be the name of the class.
- Constructors can be many for one class.(Constructor overloading).  U can call one constructor from another using this operator which refers the current instance at Runtime. The syntax will be at the constructor : this(args). Refer the example. 
- It is a recommended practise to have a default constructor(Constructor with no args) and then followed by UR Requirment based Constructors. 
- Data for the class will be usually private. Private members can be refered only within the class scope. Not the object scope. 
- We can use properties as accessors to the data. U can have get/set or both accessors for the data. 

#### Methods
- Methods are functions that are used to manipulate the data of the Class. This could setting new data, updating existing data or deleting data. Methods are usually public but can be private or any other access specifier based on the requirement. Private methods are created for better modularity purposes.
- Methods in C# are of 2 kinds:Static and Instance based. 
- There are no global methods in C#, so we use static methods instead as they can be called by the class name without a need for any instance creation. 
- U cannot call instance methods from static methods unless U create an instance of the class. However, U can call the static methods from the instance methods.
- Method Parameters are default pass by value. U can still pass them by reference using ref keyword, out keyword.
- out parameters are set by the function, so there is no need to initialize the values before passing it into the function. 
- params keyword is used in a function if U want to pass variable no args to the function. 










   






  
  	
	
	

   

