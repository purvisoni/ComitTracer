using System;

namespace ComitTracer
{
    class Program
    {
        static void Main(string[] args)
        {
            var theTracerSystem = new TracerSystem();

            Console.WriteLine("Welcome to the ComIT Tracer Application!");

            while (true) {

                Console.WriteLine("Please enter a command: v - user visited a location; c - check for exposure; u - user is showing symptoms; q - quit");

                string userInput = Console.ReadLine();

                if (userInput == "v") {
                    theTracerSystem.VisitedLocation();
                }

                if (userInput == "c") {
                    theTracerSystem.CheckForExposure();
                }

                if (userInput == "u") {
                    theTracerSystem.UserShowsSymptoms();
                    
                }

                if (userInput == "q") {
                    // User visited location
                    break;
                }
            }
        }
    }
}
