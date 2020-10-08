using System;

    class Program
    {
        static void Main(string[] args)
        {
        Student student1 = new Student();
        student1.GetStudentDetails();
        student1.DisplayStudentDetails();
        Student student2 = new Student(10, "Ajay");
        student2.DisplayStudentDetails();
        Student student3 = new Student(11);
        student3.DisplayStudentDetails();
        Student student4 = new Student(studentAddress:"delhi", studentName: "ajay");
        student4.DisplayStudentDetails();
        Student student5 = new Student(student2);
        student5.DisplayStudentDetails();









        } 
    }

