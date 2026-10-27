using System;

namespace OOPClassesAndObjects{

    public class Student{
        public string _name {get; set;}
        public int _id {get; set;}
        private double _gpa;

        public double gpa{
            get{
                return _gpa;
            }

            set{
                if(value>= 0.0 && value <= 4.0){
                    _gpa = value;
                }else{
                    Console.WriteLine("Please enter a valid gpa! The gpa value being set to default value!");
                    _gpa = 0.0;
                }
            }
        }

        public Student(string _name, int _id, double _gpa){
            this._name = _name;
            this._id = _id;
            this.gpa = _gpa;
        }

        public Student(string _name, int _id){
            this._name = _name;
            this._id = _id;
            this._gpa = 0.0;
        }
    
        public void displayInfo(){
            Console.WriteLine($"---Student Info---\nName: {_name}\nID: {_id}\nGPA: {gpa:F2}\n");
        }
    }

    internal class Program{
        static void Main(string[] args){

            Student s1 = new Student("test1", 1, 3.8432);
            Student s2 = new Student("test2", 2);

            s1.displayInfo();
            s2.displayInfo();

            s2 = s1;

            s2.displayInfo();

            s2._name = "test3";

            s1.displayInfo();
        }
    }
}
