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

   






  
  	
	
	

   

