using System;

// // Create a class named "Car" with a variable color:
// class Car{
//   public string color = "red";
// }

// class Program{
//   public static void Main (string[] args) {
//     // Create an Object + multiple objects
//     Car obj1 = new Car();
//     Car obj2 = new Car();
//     Console.WriteLine(obj1.color);
//     Console.WriteLine(obj2.color);
//   }
// }


// =============================================

// Class Members mean "data member + class methode"


//// 1: Constructors
// class Car{
//   // defining data members/class members
//   public int max_speed;
//   public string name;
//   private string color;

//   public Car(){
//     max_speed = 150;
//     name = "CIVIC";
//     color = "White";
//     Console.WriteLine ("color of the car is "+color);
//   }
  
// }

// class Program{
//   public static void Main (string[] args) {
//     Car obj1 = new Car();
//     Console.WriteLine(obj1.name);
//   }
// }


////parametrized constructor
// class Car{
//   // defining data members/class members
//   public int max_speed;
//   public string name;
//   private string color;

//   public Car(int s, string n, string c){
//     max_speed = s;
//     name = n;
//     color = c;
//     Console.WriteLine ("color of the car is "+color);
//   }

// }

// class Program{
//   public static void Main (string[] args) {
//     Car obj1 = new Car(190, "Lancrusior", "Black");
//     Console.WriteLine(obj1.name);
//   }
// }

// ============================================
// Note
 // By default, all members of a class are private if you don't specify an access modifier:
// Access Modifiers
                    // -public
                    // -private
                    // -protected

// Private Modifiers
                    // If you declare a field with a private access modifier, it can only be accessed within the same class:


// class Car
// {
//   private string model;
//   public string Function(string M)
//   {
//     model = M;
//     return model;
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Car myObj = new Car();
//     Console.WriteLine(myObj.Function("Mustang"));
//   }
// }
// --------------

// Public Modifier
                  // If you declare a field with a public access modifier, it is accessible for all classes:


// class Car
// {
//   public string model = "CIVIC";
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Car myObj = new Car();
//     Console.WriteLine(myObj.model);
//   }
// }
// -------------------------------

// protected Modifier
                    // The code is accessible within the same class, or in a class that is inherited from that class.

// We will see it soon

// ============================================


// C# Properties (Get and Set)

//         Encapsulation


                // The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:  provide public get and set methods, through properties, to access and update the value of a private field

// class Person
// {
//   private string name; // field
  
//   public string Name(string n)   // property
//   {
//     name=n;
//     return name;
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Person myObj = new Person();
//     string N = myObj.Name("Mian");
//     Console.WriteLine(N);
//   }
// }


// -----------------------

// Getter and Setters

// Example1:        

// class Person
// {
//   private string name; // field

//   // bellow function is for getter and setter in C# syntax by defult

//   public string Name  // property
//   {
//     get{return name;}
//     set{name = value;}
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Person myObj = new Person();
//     myObj.Name = "Mian G";
//     Console.WriteLine(myObj.Name);
//   }
// }
// ----------------------------
// Example 2
// using System;

// class Person
// {
//     // Private fields
//     private string name;
//     private int age;

//     // Getter and Setter for 'name'
//     public string Name
//     {
//         get { return name; }
//         set { name = value; }
//     }

//     // Getter and Setter for 'age'
//     public int Age
//     {
//         get { return age; }
//         set
//         {
//             // Validate that age is a positive value before setting it
//             if (value >= 0)
//             {
//                 age = value;
//             }
//             else
//             {
//                 Console.WriteLine("Age must be a positive value.");
//             }
//         }
//     }

//     // Method to display information about the person
//     public void DisplayInfo()
//     {
//         Console.WriteLine($"Name: {Name}, Age: {Age}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Create an instance of the Person class
//         Person person = new Person();

//         // Use the setter to set the values
//         person.Name = "John Doe";
//         person.Age = 25;

//         // Use the getter to retrieve and display the values
//         Console.WriteLine($"Person Information: {person.Name}, {person.Age} years old");

//         // Try setting an invalid age (negative value)
//         person.Age = -5;

//         // Display the information again
//         person.DisplayInfo();
//     }
// }


// ==================================================

// Inheritance (Derived and Base Class)
// In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:

// Derived Class (child) - the class that inherits from another class
// Base Class (parent) - the class being inherited from

        // Note 
// as it is inheritance so i will use here two concept one is itself inheritance and other one proctected access modifier

// when inheritance done we make objects for each class


// class Person
// {
//     protected int age; // field
//     private string name; // field

//     public string Name
//     {
//         get { return name; }
//         set { name = value; }
//     }

//     // Method to set the age
//     public void SetAge(int a)
//     {
//         age = a;
//     }

//     // Method to get the age
//     public int GetAge()
//     {
//         return age;
//     }
// }

// class Women : Person
// {
//     public Women()
//     {
//        salary=60;
//         SetAge(30); // Set the age using the method
//         Console.WriteLine("Protected age is " + GetAge()); // Get the age using the method
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Person myObj = new Person();
//         myObj.Name = "Mian G";
//         Console.WriteLine(myObj.Name);

//         Women wobj = new Women();
//     }
// }



// =========================================

//               Polymorphism

// polymorphism allows you to use a single interface (like a method or a class) to represent different types of objects or behaviors.
// two types of polymorphism
//   -Compile-time Polymorphism (Method Overloading):
//   -Runtime Polymorphism (Method Overriding):



// 1:  -Compile-time Polymorphism (Method Overloading):
// Same name methodes in same class but for different purpose

// sample code:
// class Calculator
// {
//     public int Add(int a, int b)
//     {
//         return a + b;
//     }

//     public double Add(double a, double b)
//     {
//         return a + b;
//     }
// }


// ------------------------

// 2: -Runtime Polymorphism (Method Overriding):
// conditions
// -Inheritance
// -Same name funtion in base class
// Inheritance and method overriding enable runtime polymorphism. Suppose you have a base class Shape with a method Draw. You can have different classes (like Circle and Square) that inherit from Shape and provide their own implementation of the Draw method.
    
// Goal is to do action with same work not how


// class Shape
// {
//     public virtual void Draw()
//     {
//         Console.WriteLine("Drawing a shape");
//     }
// }

// class Circle : Shape
// {
//     public override void Draw()
//     {
//         Console.WriteLine("Drawing a circle");
//     }
// }

// class Square : Shape
// {
//     public override void Draw()
//     {
//         Console.WriteLine("Drawing a square");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Shape myObj = new Shape();
//         Circle cirObj= new Circle();
//         Square sqObj = new Square();

//         myObj.Draw();
//         cirObj.Draw();
//         sqObj.Draw();
      
//     }
// }
// --------------------
//           Output of Above code will be

// Shape shape1 = new Circle();
// Shape shape2 = new Square();

// shape1.Draw();  // Output: Drawing a circle
// shape2.Draw();  // Output: Drawing a square

// ==================================

//           Abstract Class and Abstract methode

//       Abstract Classes
// -Do not have object or intances to initiate the class it is access by child class
// -It can be inherited and same as other class but with abstract keyword
// -It can have both abstract(do not have body in abstract class) and non-abstract methods.

// abstract class Animal
// {
//     public abstract void MakeSound();  // Abstract method without a body

//     public void Sleep()
//     {
//         Console.WriteLine("Zzzzz");
//     }
// }


//       Abstract Methods:
// -An abstract method is a method declared in an abstract class without providing an implementation.
// -It must be implemented (overridden) by any non-abstract derived class.

// abstract class Animal
// {
//     public abstract void MakeSound();  // Abstract method without a body
//   public void Sleep()
//   {
//       Console.WriteLine("Zzzzz");
//   }
// }
// class Cat : Animal
// {
//     public override void MakeSound()
//     {
//         Console.WriteLine("Meow");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Animal cat = new Cat();
//         cat.MakeSound();  // Output: Meow
//         cat.Sleep();      // Output: Zzzzz
//     }
// }
// // 

// ===============================

//                     Interfaces
// Another way to achieve abstraction in C#, is with interfaces.

// An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies):

// Note not need of to use the override keyword when implementing an interface:

// Interface


// ------------------

//               Multiple Interfaces
// To implement multiple interfaces, separate them with a comma:

interface IFirstInterface 
{
  void myMethod(); // interface method
}

interface ISecondInterface 
{
  void myOtherMethod(); // interface method
}

// Implement multiple interfaces
class DemoClass : IFirstInterface, ISecondInterface 
{
  public void myMethod() 
  {
    Console.WriteLine("Some text..");
  }
  public void myOtherMethod() 
  {
    Console.WriteLine("Some other text...");
  }
}

class Program 
{
  static void Main(string[] args)
  {
    DemoClass myObj = new DemoClass();
    myObj.myMethod();
    myObj.myOtherMethod();
  }
} 

