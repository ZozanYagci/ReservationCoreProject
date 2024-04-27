﻿namespace ReservationCoreProject.CQRS.Commands.DestinationCommands
{
    public class UpdateDestinationCommand
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
    }
}
