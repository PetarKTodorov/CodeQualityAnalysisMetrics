namespace P04.MiddleMan
{
    public class SolutionCode
    {
        public class Program
        {
            public void Main()
            {
                Person person = new Person();

                Department department = person.GetDepartment();

                person = department.GetManager();
            }
        }

        public class Person
        {
            private Department department = null;

            public Department GetDepartment()
            {
                return this.department;
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
