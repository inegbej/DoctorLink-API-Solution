using Notifications.Common.Interfaces;
using Notifications.Common.Models;
using System;
using System.Collections.Generic;

namespace Notifications.DataAccess.Access
{
    public class InMemoryNotificationsAccess : INotificationsAccess
    {
        static InMemoryNotificationsAccess()
        {
            _notifications = new List<NotificationModel>
            {
                new NotificationModel { Id = Guid.NewGuid()},
                new NotificationModel { Id = Guid.NewGuid()},
                new NotificationModel { Id = Guid.NewGuid()},
                new NotificationModel { Id = Guid.NewGuid()},
                new NotificationModel { Id = Guid.NewGuid()},
                new NotificationModel { Id = Guid.NewGuid()},
                new NotificationModel { Id = Guid.NewGuid()},
                new NotificationModel { Id = Guid.NewGuid()},
                new NotificationModel { Id = Guid.NewGuid()},
                new NotificationModel { Id = Guid.NewGuid()}
            };
        }

        public IEnumerable<NotificationModel> GetAllNotifications()
        {
            return _notifications;
        }

        static List<NotificationModel> _notifications;
    }
}
