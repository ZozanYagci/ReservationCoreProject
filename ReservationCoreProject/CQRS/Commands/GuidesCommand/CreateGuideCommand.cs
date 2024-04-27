﻿using MediatR;

namespace ReservationCoreProject.CQRS.Commands.GuidesCommand
{
    public class CreateGuideCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
