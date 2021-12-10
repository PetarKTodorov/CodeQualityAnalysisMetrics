namespace P02.RefusedBequest
{
    using System;

    public class SolutionCode
    {
        public class Vehicle
        {
            public Guid Id { get; set; }
        }

        public class Car : Vehicle
        {
            public void Drive() 
            {
                throw new NotImplementedException();
            }
        }

        public class Plane : Vehicle
        {

        }
    }
}
