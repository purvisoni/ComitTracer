using System;

namespace ComitTracer
{
    public class Visit
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public Location Location { get; set; }
        public DateTime DateOfVisit { get; set; }
    }
}