//Reflection is reading the metadata of the Assembly and gettings its information like Classes, Namespaces, Members of each class and use that information either for invocation of the methods using "LATE BINDING" or for displaying the members of the Entities at runtime..

using System;
using System.Reflection;
namespace Frameworks
{
	class Ex24ReflectionExample
	{
		static Type selectedType;
		static MethodInfo selectedMethod;
		static object objInstance;
		static object[] parameters;

		static void Main(string[] args)
		{
			displayAllClassesOfTheAssembly();
			Console.WriteLine("Enter the full Name of the class that U want to get details");
			string typeName = Console.ReadLine();
			selectedType = Type.GetType(typeName);
			displayMembersOfClass(selectedType);

			Console.WriteLine("Enter the Name of the method that U want to invoke");
			string methodName = Console.ReadLine();	
			MethodInfo method = selectedType.GetMethod(methodName);
			if(method == null)
			{
				Console.WriteLine("Invalid Method");
				return;
			}

			var pmList = method.GetParameters();
			parameters = new object[pmList.Length];
			int index = 0;
			foreach(var pm in pmList)
			{
				Console.WriteLine($"Enter the value for the parameter {pm.Name} of the data type {pm.ParameterType.Name}");
				parameters[index] = Convert.ChangeType(Console.ReadLine(), pm.ParameterType);
				index++;
			}
			//Now to create the instance of the selected class...
			objInstance = Activator.CreateInstance(selectedType);
			object result = method.Invoke(objInstance, parameters);
			Console.WriteLine("The result of this operation is " + result);

		}

        private static void displayMembersOfClass(Type type)
        {
   //         PropertyInfo[] properties = type.GetProperties();
			//foreach (var property in properties)
			//{
			//	string info = $"Name: {property.Name}\tData Type: {property.PropertyType.Name}";
			//	Console.WriteLine(info);
			//}

			MemberInfo[] members = type.GetMembers();
			foreach(var member in members)
			{
				string info = $"Name: {member.Name}\t Member Type: {member.MemberType}";
				Console.WriteLine(info);
			}
        }

        private static void displayAllClassesOfTheAssembly()
        {
            //Get the Assembly object. 
			Assembly asm = Assembly.GetExecutingAssembly();
			Type[] types = asm.GetTypes();
			foreach (Type type in types)
			{
				Console.WriteLine(type.FullName);
			}
        }
    }
}
