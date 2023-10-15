//using System;

//public interface ICodeAcademy
//{
//    string CodeEmail { get; set; }
//    string GenerateEmail();
//}

//public class Student : ICodeAcademy
//{
//    private static int Count = 0;
//    public int Id { get; }
//    public string Name { get; }
//    public string Surname { get; }
//    public string CodeEmail { get; set; }

//    public Student(string name, string surname)
//    {
//        if (CheckName(name, surname))
//        {
//            Id = ++Count;
//            Name = name;
//            Surname = surname;
//            GenerateEmail();
//        }
//        else
//        {
//            throw new ArgumentException("Invalid Name or Surname.");
//        }
//    }

//    public static bool CheckName(string name, string surname)
//    {
//        // Check if Name and Surname are valid
//        if (IsNameValid(name) && IsNameValid(surname))
//        {
//            return true;
//        }
//        return false;
//    }

//    private static bool IsNameValid(string name)
//    {
//        if (name.Length >= 3 && name.Length <= 25)
//        {
//            foreach (char c in name)
//            {
//                if (!Char.IsLetter(c))
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//        return false;
//    }

//    public string GenerateEmail()
//    {
//        string email = $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";
//        CodeEmail = email;
//        return email;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        string name = "Murad";
//        string surname = "Aliyev";

//        if (Student.CheckName(name, surname))
//        {
//            Student student = new Student(name, surname);
//            Console.WriteLine($"Student Id: {student.Id}");
//            Console.WriteLine($"Student Name: {student.Name}");
//            Console.WriteLine($"Student Surname: {student.Surname}");
//            Console.WriteLine($"Student Email: {student.CodeEmail}");
//        }
//    }
//}
//using System;
//using System.Linq;

//public static class ExtensionHelpers
//{
//    public static bool IsOdd(this int number)
//    {
//        return number % 2 != 0;
//    }

//    public static bool IsEven(this int number)
//    {
//        return number % 2 == 0;
//    }

//    public static bool HasDigit(this string text)
//    {
//        return text.Any(char.IsDigit);
//    }

//    public static bool CheckPassword(this string password)
//    {
//        return password.Length >= 8 &&
//               password.Any(char.IsUpper) &&
//               password.Any(char.IsLower) &&
//               password.Any(char.IsDigit);
//    }

//    public static string Capitalize(this string text)
//    {
//        if (string.IsNullOrEmpty(text))
//            return text;

//        return char.ToUpper(text[0]) + text.Substring(1).ToLower();
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int num1 = 5;
//        int num2 = 10;
//        Console.WriteLine($"{num1} is odd: {num1.IsOdd()}");
//        Console.WriteLine($"{num2} is even: {num2.IsEven()}");

//        string text1 = "Hello123";
//        string text2 = "NoDigitsHere";
//        Console.WriteLine($"'{text1}' has a digit: {text1.HasDigit()}");
//        Console.WriteLine($"'{text2}' has a digit: {text2.HasDigit()}");

//        string password1 = "Abc12345";
//        string password2 = "WeakPwd1";
//        Console.WriteLine($"Is '{password1}' a valid password? {password1.CheckPassword()}");
//        Console.WriteLine($"Is '{password2}' a valid password? {password2.CheckPassword()}");

//        string text3 = "capitalize me";
//        Console.WriteLine($"Capitalized: '{text3.Capitalize()}'");
//    }
//}

//using System;

//public class Student
//{
//    public static int Count = 0;
//    public int Id { get; }
//    public string Name { get; }
//    public string Surname { get; }

//    public Student(string name, string surname)
//    {
//        Id = ++Count;
//        Name = name;
//        Surname = surname;
//    }

//    public string GetInfo()
//    {
//        return $"Student Id: {Id}, Name: {Name}, Surname: {Surname}";
//    }
//}

//public class Group
//{
//    public static Group[] Groups = new Group[10];
//    public static int GroupCount = 0;
//    public int GroupId { get; }
//    public string GroupName { get; }
//    public Student[] Students = new Student[10];
//    public int StudentCount = 0;

//    public Group(string groupName)
//    {
//        GroupId = ++GroupCount;
//        GroupName = groupName;
//        Groups[GroupId] = this;
//    }

//    public void GetGroupInfo()
//    {
//        Console.WriteLine($"Group Id: {GroupId}, Group Name: {GroupName}");
//        Console.WriteLine($"Number of Students in Group: {StudentCount}");
//    }

//    public Student GetStudent(int id)
//    {
//        for (int i = 0; i < StudentCount; i++)
//        {
//            if (Students[i].Id == id)
//            {
//                return Students[i];
//            }
//        }
//        return null;
//    }

//    public void AddStudent(Student student)
//    {
//        if (StudentCount < Students.Length)
//        {
//            Students[StudentCount] = student;
//            StudentCount++;
//        }
//    }

//    public void Search(string searchQuery)
//    {
//        for (int i = 0; i < StudentCount; i++)
//        {
//            if (Students[i].Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
//                Students[i].Surname.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
//            {
//                Console.WriteLine(Students[i].GetInfo());
//            }
//        }
//    }

//    public void RemoveStudent(int id)
//    {
//        for (int i = 0; i < StudentCount; i++)
//        {
//            if (Students[i].Id == id)
//            {
//                for (int j = i; j < StudentCount - 1; j++)
//                {
//                    Students[j] = Students[j + 1];
//                }
//                StudentCount--;
//                break;
//            }
//        }
//    }

//    public void ShowStudents()
//    {
//        Console.WriteLine($"Students in Group {GroupName}:");
//        for (int i = 0; i < StudentCount; i++)
//        {
//            Console.WriteLine(Students[i].GetInfo());
//        }
//    }

//    public static void ShowAllGroups()
//    {
//        for (int i = 1; i <= GroupCount; i++)
//        {
//            Groups[i].GetGroupInfo();
//        }
//    }

//    public static void AddGroup(Group group)
//    {
//        if (GroupCount < Groups.Length)
//        {
//            GroupCount++;
//            Groups[GroupCount] = group;
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
       
//        Group group1 = new Group("Group A");
//        Group group2 = new Group("Group B");

        
//        Student student1 = new Student("Nihat", "Rehimzade");
//        Student student2 = new Student("Ronaldo", "Cristiano");
//        Student student3 = new Student("Quraaresma", "BJK");
//        Student student4 = new Student("Marcelo", "Real");
//        group1.AddStudent(student1);
//        group1.AddStudent(student2);
//        group2.AddStudent(student3);
//        group2.AddStudent(student4);

      
//        Group.ShowAllGroups();
//    }
//}
