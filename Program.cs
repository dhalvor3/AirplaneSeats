using System;
using System.Collections.Generic;
using System.Linq;

namespace AirplaneSeats
{
    class Program
    {
        public struct Seat
        {
            public string SeatNumber { get; set; }
            public SeatPosition Position { get; set; }
            public bool IsAvailable { get; set; }
        }
            public enum SeatPosition
            {
                Aisle,
                Middle,
                Window
            } 

        public class Plane
        {
            public string TailNumber { get; set; }
            public string FlightNumber { get; set; }
            public Seat[] Seats { get; set; }
            public List<Seat> SeatAsList
            {
                get { return Seats.ToList(); 
                }
            }
            public IEnumerable<Seat> getAvailSeats()
            {
                var availSeats = new List<Seat>();
                foreach (Seat seat in Seats)
                {
                    if (seat.IsAvailable)
                    {
                        availSeats.Add(seat);
                    }
                }
                return availSeats;
            }
        }
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            plane.Seats = new Seat[] {
                new Seat{SeatNumber="1C", Position= SeatPosition.Aisle, IsAvailable=false },
                new Seat{SeatNumber="10A", Position= SeatPosition.Window, IsAvailable=true  },
                new Seat{SeatNumber="7E", Position= SeatPosition.Middle, IsAvailable=true  },
                new Seat{SeatNumber="3D", Position= SeatPosition.Aisle, IsAvailable=false  },

            };
            foreach(Seat seat in plane.getAvailSeats())
            {
                Console.WriteLine($"Available Seat: {seat.SeatNumber} ");
            }
        }

    }
}
