using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RapidNote.Commands;

namespace RapidNote.Modules.UsersModule.CommandHandlers
{
    public class ChangeUserPasswordCommandHandler : AsyncRequestHandler<ChangeUserPasswordCommand>
    {
        protected override Task Handle(ChangeUserPasswordCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
