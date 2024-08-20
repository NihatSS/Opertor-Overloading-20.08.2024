namespace OperatorOverload;

internal class GroupMate
{
    public List<Student> students = new();


    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void Sort()
    {
        students = students.OrderBy(s => s.Age).ToList();

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}
