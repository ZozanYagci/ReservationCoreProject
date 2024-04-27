using MediatR;
using ReservationCoreProject.CQRS.Results.GuideResults;

namespace ReservationCoreProject.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
