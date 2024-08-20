using OperatorOverload;

GroupMate groupMate = new GroupMate();

groupMate.AddStudent(new Student() { Name = "Nihat", Surname = "Soltanov",Age = 17 });
groupMate.AddStudent(new Student() { Name = "Eldar", Surname = "Ehmedov",Age = 19 });
groupMate.AddStudent(new Student() { Name = "Ferdi", Surname = "Isamayilzade",Age = 18 });

groupMate.Sort();

Console.WriteLine(groupMate);