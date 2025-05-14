using WebSystemManageTasks.Entities;

namespace WebSystemManageTasks
{
    public class Data
    {
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User
            {
                Id = Guid.Parse("42e16103-cbcd-4cc1-8553-a2fa7bced3af"),
                Name = "user",
                Surname = "user",
                Email = "user@mail.ru",
                Login = "login123",
                //password
                PasswordHash = "$2a$11$JuehRExKbznIw99WCv66U.um0/filYQ3IpZsN97FBxTcBVcuu28rW",
            },
        };

        public static List<Project> Projects { get; set; } = new List<Project>()
        {
            new Project { Id = Guid.Parse("f19d7055-75c6-401f-a942-aab8fb75168c"), Name = "Project1"},
            new Project { Id = Guid.Parse("53866444-ffeb-479f-b0c1-9ca0d88d490e"), Name = "Project2"},
        };

        public static List<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>()
        {
            new ProjectTask {
                Id = Guid.Parse("27dc289c-02ac-43c4-baee-6c75f6a0ced0"), 
                Name = "Task1",
            },
            new ProjectTask {
                Id = Guid.Parse("f01dedfc-ead7-4607-b955-3ea7a482594b"),
                Name = "Task2",
            },
            new ProjectTask {
                Id = Guid.Parse("c4ee7478-e031-416d-91cf-080f48bbc996"),
                Name = "Task3",
            },
            new ProjectTask {
                Id = Guid.Parse("29cab245-19ec-465b-b425-410fb68d8e1f"),
                Name = "Task4",
            },
            new ProjectTask {
                Id = Guid.Parse("7c465c2b-d6d1-4ea2-9e4d-b8e318133c33"),
                Name = "Task5",
            },
            new ProjectTask {
                Id = Guid.Parse("a52b6224-72d2-4b6d-80ab-90cfce73ddb3"),
                Name = "Task6",
            },
            new ProjectTask {
                Id = Guid.Parse("aa32955a-78c8-4c5d-b51e-7d4a907324a9"),
                Name = "Task7",
            },
            new ProjectTask {
                Id = Guid.Parse("3d468720-196a-4f1a-b1ed-31fad29fb4d8"),
                Name = "Task8",
            },
            new ProjectTask {
                Id = Guid.Parse("b478cd76-c8a8-4295-b9f1-07ed38b156cb"),
                Name = "Task9",
            },
            new ProjectTask {
                Id = Guid.Parse("5d9556f6-b150-41f6-8107-311d4830978a"),
                Name = "Task10",
            },
        };

        public static List<Role> Roles { get; set; } = new List<Role>()
        {
            new Role { Id =  Guid.Parse("6225f164-feb7-4810-961f-032e30aa13fc"), Name = "Пользователь"},
            new Role { Id =  Guid.Parse("98fc5065-5faf-48d4-8022-2647038627e6"), Name = "Администратор"},
        };

        public static List<StatusTask> StatusTasks { get; set; } = new List<StatusTask>()
        {
            new StatusTask {Id = Guid.Parse("ac78c9f2-44a1-49e5-96a1-0a10143eaae3"), Name = "Сделать" },
            new StatusTask {Id = Guid.Parse("ed194ae6-4b78-4ded-b9de-c1a42b2dea40"), Name = "В процессе" },
            new StatusTask {Id = Guid.Parse("fea5dc04-e86c-488a-ba74-aeafb13d0930"), Name = "Тестируется" },
            new StatusTask {Id = Guid.Parse("9875dce0-bd3e-447c-81a0-c086a01f719f"), Name = "Готово" },
        };
    }
}
