using Task1;
using Student_name;
using Teacher_n;

Person person = new Person();
person.Name("Tom"); 
person.Greet();

Student student = new Student();
student.Name("Timi");
student.SetAge(21);
student.Hello();

Teacher teacher = new Teacher();
teacher.Name("Ms.Sandra");
teacher.SetAge(30);
teacher.Hello();
teacher.Explain();

