using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WcfStudents.Common.Models
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int StudentID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public int Age  { get; set; }
        [DataMember]
        public DateTime Birthday { get; set; }

        public Student()
        {
        }

        public Student(string name, string surname, DateTime birthday)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            Birthday = birthday;

            Age = GetAgeByBirthday(birthday);
        }

        public Student(int studentID, string name, string surname, int age, DateTime birthday)
        {
            StudentID = studentID;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            Age = age;
            Birthday = birthday;
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentID == student.StudentID &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   Age == student.Age &&
                   Birthday == student.Birthday;
        }

        public override int GetHashCode()
        {
            int hashCode = -436139999;
            hashCode = hashCode * -1521134295 + StudentID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + Birthday.GetHashCode();
            return hashCode;
        }

        private int GetAgeByBirthday(DateTime birthday)
        {
            int age = 0;
            age = DateTime.Today.Year - birthday.Year;

            if (DateTime.Today.DayOfYear < birthday.DayOfYear) age--;

            return age;
        }
    }
}
