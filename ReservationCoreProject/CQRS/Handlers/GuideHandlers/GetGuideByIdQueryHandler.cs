using DataAccess.Concrete;
using MediatR;
using NuGet.Protocol.Plugins;
using ReservationCoreProject.CQRS.Queries.GuideQueries;
using ReservationCoreProject.CQRS.Results.GuideResults;

namespace ReservationCoreProject.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler:IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;
        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values=await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                Id = values.Id,
                Description = values.Description,
                Name = values.Name,

            };
        }
    }
}
