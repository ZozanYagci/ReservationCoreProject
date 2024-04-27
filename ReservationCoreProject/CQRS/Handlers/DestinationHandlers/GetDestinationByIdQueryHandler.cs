
using DataAccess.Concrete;
using ReservationCoreProject.CQRS.Queries.DestinationQueries;
using ReservationCoreProject.CQRS.Results.DestinationResults;

namespace ReservationCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.Id);
            return new GetDestinationByIdQueryResult
            {
                Id = values.Id,
                City=values.City,
                DayNight=values.DayNight,
                Price=values.Price,
            };
        }
    }
}
