using DataAccess.Concrete;
using ReservationCoreProject.CQRS.Commands.DestinationCommands;

namespace ReservationCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;
        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Id);
            values.City= command.City;
            values.DayNight= command.DayNight;
            values.Price= command.Price;
            _context.SaveChanges();
        }
    }
}
