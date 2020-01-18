using System;
using HotelReservation.Entities;


/// <summary>
/// a program to read the data of a hotel reservation (room number, check-in date and check-out date) and show the reservation data, 
/// including its duration in days. Then, read new check-in and check-out dates, update the reservation, 
/// and show the reservation again with the updated data. The program must not accept invalid data for the reservation, 
/// according to the following rules: -Booking changes can only occur for future dates -The departure date must be greater than the arrival date
/// </summary>

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-In date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date ");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                String error = reservation.UpdateDates(checkIn, checkOut);
                if ( error != null)
                {
                    Console.WriteLine("Error in reservation: " + error);
                }
                else
                {
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
            Console.ReadLine();
        }
    }
}
