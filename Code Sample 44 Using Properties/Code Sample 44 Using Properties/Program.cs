using System;

namespace Code_Sample_44_Using_Properties
{
    public class StaffMember
    {
        private int ageValue;
        public int Age
        {
            set
            {
                if ((value > 0) && (value < 120))
                {
                    this.ageValue = value;
                }
            }
            get
            {
                return this.ageValue;
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            StaffMember s = new StaffMember();
            s.Age = 21;
            Console.WriteLine("Age is : " + s.Age);
        }
    }
}
