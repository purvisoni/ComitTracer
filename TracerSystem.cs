using System;

namespace ComitTracer
{
    public class TracerSystem
    {
        
        public void CheckForExposure() {
            Console.WriteLine("Checking for exposure...");
        }

        public void VisitedLocation() {
            Console.WriteLine("Some user is visiting some location...");
        }

        public void UserShowsSymptoms() {
            Console.WriteLine("User is marked as showing symptoms...");
        }



    }
}