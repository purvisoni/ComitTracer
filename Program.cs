using System;

using ComitTracer.Storage;

namespace ComitTracer
{
    class Program
    {
        static void Main(string[] args)
        {
            var userStorage = new UserStorageList();
            var theTracerSystem = new TracerSystem(userStorage);

            Console.WriteLine("Welcome to the ComIT Tracer Application!");

            while (true) {

                Console.WriteLine("Please enter a command: v - user visited a location; c - check for exposure; u - user is showing symptoms; q - quit");

                string userInput = Console.ReadLine();

                if (userInput == "v") {
                    try {
                        Console.WriteLine("Enter the user Id: ");
                        var userIdString = Console.ReadLine();
                        Guid userId = new Guid(userIdString);

                        Console.WriteLine("Enter the location Id: ");
                        var locationIdString = Console.ReadLine();
                        Guid locationId = new Guid(locationIdString);

                        theTracerSystem.VisitedLocation(userId, locationId);
                        Console.WriteLine("User visit has been recorded");
                    } catch (Exception e) {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                    
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
