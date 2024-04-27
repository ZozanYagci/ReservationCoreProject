using DataAccess.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ReservationCoreProject.CQRS.Queries.GuideQueries;
using ReservationCoreProject.CQRS.Results.GuideResults;

namespace ReservationCoreProject.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler:IRequestHandler<GetAllGuideQuery, List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;
        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                Id = x.Id,
                Description = x.Description,
                Image= x.Image,
                Name = x.Name,

            }).AsNoTracking().ToListAsync();
        }
    }
}
