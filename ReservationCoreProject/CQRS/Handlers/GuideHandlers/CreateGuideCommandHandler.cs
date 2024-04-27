using DataAccess.Concrete;
using DocumentFormat.OpenXml.Wordprocessing;
using Entity.Concrete;
using MediatR;
using NuGet.Protocol.Plugins;
using ReservationCoreProject.CQRS.Commands.GuidesCommand;

namespace ReservationCoreProject.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                Name = request.Name,
                Description= request.Description,
                Status=true,

            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
