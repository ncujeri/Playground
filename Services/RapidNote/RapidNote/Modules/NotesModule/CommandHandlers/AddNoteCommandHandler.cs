using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RapidNote.Commands;

namespace RapidNote.Modules.NotesModule.CommandHandlers
{
    public class AddNoteCommandHandler : AsyncRequestHandler<AddNoteCommand>
    {
        protected override Task Handle(AddNoteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
