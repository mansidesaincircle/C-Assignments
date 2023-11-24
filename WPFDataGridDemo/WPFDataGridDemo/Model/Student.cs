using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDataGridDemo
{
    public class Student
    {
        private int Id;
        public int id
        {
            get { return Id; }
            set { Id = value; }
           
        }

        private string Name;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        private bool IsSoccerPlayer;
        public bool isSoccerPlayer
        {
            get { return IsSoccerPlayer; }
            set { IsSoccerPlayer = value; }
        }

        private Gender gender;
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public static ObservableCollection<Student>GetStudent()
        {
            var student = new ObservableCollection<Student>();
            student.Add(new Student() { id = 101, name = "Mansi", isSoccerPlayer = true, Gender = Gender.Female });
            student.Add(new Student() { id = 102, name = "Kunal", isSoccerPlayer = false, Gender = Gender.Male });
            student.Add(new Student() { id = 103, name = "Ayesha", isSoccerPlayer = true, Gender = Gender.Female });
            student.Add(new Student() { id = 104, name = "Sujal", isSoccerPlayer = false, Gender = Gender.Male });
            student.Add(new Student() { id = 105, name = "Aryan", isSoccerPlayer = true, Gender = Gender.Male });
            student.Add(new Student() { id = 106, name = "Ritik", isSoccerPlayer = true, Gender = Gender.Female });
            return student;
        }
    }
    public enum Gender
    {
        Male,
        Female,
        Unknown
    }
}
