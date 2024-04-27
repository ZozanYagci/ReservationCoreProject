
using DataAccess.Concrete;
using Entity.Concrete;
using ReservationCoreProject.CQRS.Commands.DestinationCommands;

namespace ReservationCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;
        public CreateDestinationCommandHandler(Context context)
        {
                _context = context;
        }

        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinations.Add(new Destination
            {
                City=command.City,
                Price=command.Price,
                DayNight=command.DayNight,
                Capacity=command.Capacity,
                Status=true
            });
            _context.SaveChanges();
        }
    }
}
