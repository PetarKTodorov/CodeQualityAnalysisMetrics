namespace P04.MiddleMan
{
    public class ProblemCode
    {
        public class Program
        {
            public void Main()
            {
                Person person = new Person();

                person = person.GetManager();
            }
        }


        public class Person
        {
            public Department Department { get; set; }

            public Person GetManager()
            {
                return this.Department.GetManager();
            }
        }


        public class Department
        {
            private readonly Person manager;

            public Department(Person manager)
            {
                this.manager = manager;
            }

            public Person GetManager()
            {
                return this.manager;
            }
        }
    }
}
