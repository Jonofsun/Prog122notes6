using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122notes6
{
    // internal
    // public
    // private
    // protected
    public class Student
    {
        // field
        string _firstName;
        string _lastName;
        double _gradeCSI;
        double _gradeGenEd;

        //public Student(string firstName)
        //{
        //    _firstName = firstName;
        //}

        public Student(string firstName, string lastName, double gradeCSI, double gradeGenEd) // contructor
        {
            _firstName = firstName;
            _lastName = lastName;
            _gradeCSI = gradeCSI;
            _gradeGenEd = gradeGenEd;
        }
        // property
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public double GradeCSI { get => _gradeCSI; set => _gradeCSI = value; }
        public double GradeGenEd { get => _gradeGenEd; set => _gradeGenEd = value; }

        //rtbRunDisplay.Text = s.FirstName + " " + s.LastName + " " + s.GradeCSI + " " + s.GradeGenEd;
        // how to override .ToString()

        public double StudentAverage()
        {
            return (_gradeCSI + _gradeGenEd) / 2;
        }
        // Review: what are the 4 parts of a method? Access modifier - return type - name - Paremeters
        public override string ToString() // class method directly interacts with the members of a class
        {
            return $"{_firstName} {_lastName} - CSI grade: {_gradeCSI} - Gen Ed grade: {_gradeGenEd} - Average {StudentAverage()}";
        }
    }
}
