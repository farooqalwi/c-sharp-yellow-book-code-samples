using System;

namespace Code_Sample_22_Enum_Traffic_Light
{

    enum TrafficLight
    { Red, RedAmber, Green, Amber };

    class Program
    {
        public static void Main()
        {
            TrafficLight light;
            light = TrafficLight.Green;
            Console.WriteLine(light);
        }
    }
}
