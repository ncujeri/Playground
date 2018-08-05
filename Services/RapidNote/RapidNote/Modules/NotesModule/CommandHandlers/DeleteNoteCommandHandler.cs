using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RapidNote.Commands;

namespace RapidNote.Modules.NotesModule.CommandHandlers
{
    public class DeleteNoteCommandHandler : AsyncRequestHandler<DeleteNoteCommand>
    {
        protected override Task Handle(DeleteNoteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
