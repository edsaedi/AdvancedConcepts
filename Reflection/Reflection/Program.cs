using System;
//using System.Reflection;
using System.Diagnostics;


namespace Reflection
{

    public class MyCool : Attribute
    {
        public bool Execute { get; set; }
    }



    [DebuggerDisplay("{DebuggerDisplay(),nq}")]
    class Program
    {

        public class Student
        {
            private string FullName { get; set; }

            public int Class { get; set; }

            public DateTime DateOfBirth { get; set; }

            public Student()
            {
                FullName = "Karan Bhamra";
                Class = 420;
                DateOfBirth = DateTime.UnixEpoch;
            }

            public Student(string name)
            {
                FullName = name;
                Class = 420;
                DateOfBirth = DateTime.UnixEpoch;
            }


            [MyCool(Execute = true)]
            public static void Greet()
            {
                Console.WriteLine("Hello there");
            }

            public string GetCharacteristics()
            {
                return FullName;
            }

            private string DebuggerDisplay()
            {
                return $"Student name: {FullName}";
            }
        }

        [DebuggerDisplay("poop")]
        public class AnObject
        {
            public int ObjectId { get; set; }
            public string StringProperty { get; set; }
            public int IntProperty { get; set; }

            private string DebuggerDisplay()
            {
                return $"{StringProperty} - {IntProperty}";
            }
        }

        static void Main(string[] args)
        {
            //Assembly


            //Console
            //string name = "Karan".Reverse();
            //string mrTeeTime = DateTime.Now.ToMrTTime();

            //var stuff = Assembly.GetExecutingAssembly();

            //var types = stuff.GetTypes();

            //foreach (var type in types)
            //{
            //    Console.WriteLine($"Class {type.Name} found");

            //    foreach (var method in type.GetMethods())
            //    {
            //        Console.WriteLine($"\tMethod {method.Name} found");
            //    }
            //    Console.WriteLine();

            //    foreach (var field in type.GetFields())
            //    {
            //        Console.WriteLine($"\tField {field.Name} found");

            //    }
            //    Console.WriteLine();

            //    foreach (var member in type.GetMembers())
            //    {
            //        Console.WriteLine($"\tMember {member.Name} found");

            //    }
            //    Console.WriteLine();

            //}

            //var type = typeof(Student).GetTypeInfo();

            //foreach (var item in type.DeclaredMembers)
            //{
            //    Console.WriteLine(item);
            //}

            //var type = typeof(Student);

            //object t = Activator.CreateInstance(type);

            //Console.WriteLine((t as Student).GetCharacteristics());

            //var blah = type.GetProperties();

            //foreach (var property in blah)
            //{
            //    Console.WriteLine(property.GetValue(t));
            //    Console.WriteLine(property.Name);



            //}


            //var assembly = Assembly.GetExecutingAssembly();


            //foreach (var type in assembly.GetTypes())
            //{
            //    foreach (var member in type.GetMethods())
            //    {
            //        foreach (var attribute in member.GetCustomAttributes())
            //        {


            //            if (attribute.GetType() == typeof(MyCool))
            //            {
            //                Console.WriteLine("found my attribute");

            //                var method = member.Invoke(null, null);
            //            }
            //            //Console.WriteLine(attribute);
            //        }

            //    }

            //}

            Student t = new Student("Karan");

            Student s = new Student();

            AnObject obj = new AnObject();

            ;


        }
    }
}
