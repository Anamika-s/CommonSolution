using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Student
    {
    int rn;
    string studentName;
    string studentAddress;
    int[] marks = new int[5];

    // Default constructor
    public Student()
    {
        rn = 0;
        studentName = string.Empty;
        studentAddress = string.Empty;
        marks = new int[] { 0, 0, 0, 0, 0 };
    }
    // Parameterized constructor
    public Student(int rn)
    {
        this.rn = rn;
        Console.WriteLine("Enter Name");
        studentName = Console.ReadLine();
        Console.WriteLine("Enter Address");
        studentAddress = Console.ReadLine();
        Console.WriteLine("Enter Marks");
        for (int i = 0; i < 5; i++)
        {
            marks[i] = new int();
            Console.WriteLine("Enter Marks of {0} subject", i + 1);
            marks[i] = Convert.ToByte(Console.ReadLine());

        }
    }
    // Parameterized constructor
    public Student(int rn, string studentName)
    {
        this.rn = rn;
        this.studentName = studentName;
        Console.WriteLine("Enter Address");
        studentAddress = Console.ReadLine();
        Console.WriteLine("Enter Marks");
        for (int i = 0; i < 5; i++)
        {
            marks[i] = new int();
            Console.WriteLine("Enter Marks of {0} subject", i + 1);
            marks[i] = Convert.ToByte(Console.ReadLine());

        }
    }
    // Parameterized constructor
    public Student(string studentName)
    {
        Console.WriteLine("Enter RollNo");
        rn = Convert.ToByte(Console.ReadLine());
        this.studentName = studentName;
        Console.WriteLine("Enter Address");
        studentAddress = Console.ReadLine();
        Console.WriteLine("Enter Marks");
        for (int i = 0; i < 5; i++)
        {
            marks[i] = new int();
            Console.WriteLine("Enter Marks of {0} subject", i + 1);
            marks[i] = Convert.ToByte(Console.ReadLine());

        }
    }
    // Parameterized constructor
    public Student(int rn, string studentName, string studentAddress)
    {
        this.rn = rn;
        this.studentName = studentName;
        this.studentAddress = studentAddress;
        Console.WriteLine("Enter Marks");
        for (int i = 0; i < 5; i++)
        {
            marks[i] = new int();
            Console.WriteLine("Enter Marks of {0} subject", i + 1);
            marks[i] = Convert.ToByte(Console.ReadLine());

        }
    }
    // Parameterized constructor
    public Student(int rn, string studentName, string studentAddress, int[] marks)
    {
        this.rn = rn;
        this.studentName = studentName;
        this.studentAddress = studentAddress;
        for (int i = 0; i < 5; i++)
        {
            this.marks[i] = new int();

            this.marks[i] = marks[i];

        }
    }
    // Parameterized constructor
    public Student(string studentName, string studentAddress)
    {
        Console.WriteLine("Enter RollNo");
        rn = Convert.ToByte(Console.ReadLine());
        this.studentName = studentName;
        this.studentAddress = studentAddress;
        Console.WriteLine("Enter Marks");
        for (int i = 0; i < 5; i++)
        {
            marks[i] = new int();
            Console.WriteLine("Enter Marks of {0} subject", i + 1);
            marks[i] = Convert.ToByte(Console.ReadLine());

        }
    }
    // Copy constructor
    public Student(Student obj)

    {
        Console.WriteLine("Enter RollNo");
        rn = Convert.ToByte(Console.ReadLine());
        this.studentName = obj.studentName;
        this.studentAddress = obj.studentAddress;

        for (int i = 0; i < 5; i++)
        {
            this.marks[i] = new int();

            this.marks[i] = obj.marks[i];

        }
    }
    public void GetStudentDetails()
    {
        Console.WriteLine("Enter RollNo");
        rn = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Enter Name");
        studentName = Console.ReadLine();
        Console.WriteLine("Enter Address");
        studentAddress = Console.ReadLine();
        Console.WriteLine("Enter Marks");
        for(int i=0;i<5;i++)
        {
            marks[i] = new int();
            Console.WriteLine("Enter Marks of {0} subject" , i+1);
            marks[i] = Convert.ToByte(Console.ReadLine());

        }
    }
    public void DisplayStudentDetails()
    {
        Console.WriteLine("RollNo is     : {0} " , rn);
        Console.WriteLine("Name is       : {0} ", studentName);
        Console.WriteLine("Address is    : {0} ", studentAddress);
        Console.WriteLine("Marks are");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Marks in {0} subject are {1} ", i + 1, marks[i]);
           
        }
    }

}

