using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using RapidNote.Notifications;

namespace RapidNote.Modules.NotesModule.NotificationHandlers
{
    public class UserDeletedNotificationHandler : NotificationHandler<UserDeletedNotification>
    {
        protected override void Handle(UserDeletedNotification notification)
        {
            throw new NotImplementedException();
        }
    }
}
