using MediatR;
using ReservationCoreProject.CQRS.Results.GuideResults;

namespace ReservationCoreProject.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery:IRequest<GetGuideByIdQueryResult>
    {
        public GetGuideByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
