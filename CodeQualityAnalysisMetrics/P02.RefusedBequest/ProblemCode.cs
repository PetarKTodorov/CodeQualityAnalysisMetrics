namespace P02.RefusedBequest
{
    using System;

    public class ProblemCode
    {
        public class Vehicle
        {
            public Guid Id { get; set; }

            protected void Drive() 
            {
                throw new NotImplementedException();
            }
        }

        public class Car : Vehicle
        {

        }

        public class Plane : Vehicle
        {

        }
    }
}
