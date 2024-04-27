using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using ReservationCoreProject.CQRS.Results.DestinationResults;

namespace ReservationCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;
        public GetAllDestinationQueryHandler(Context context)
        {
                _context = context;
        }
        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                Id = x.Id,
                Capacity = x.Capacity,
                City = x.City,
                DayNight = x.DayNight,
                Price = x.Price,
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
