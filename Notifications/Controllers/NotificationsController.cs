﻿using Microsoft.AspNetCore.Mvc;
using Notifications.Common.Interfaces;
using Notifications.Common.Models;
using System.Collections.Generic;

namespace Notifications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationsService _notificationsService;

        public NotificationsController(INotificationsService notificationsService)
        {
            this._notificationsService = notificationsService;
        }

        [Route("")]
        [HttpGet]
        public IReadOnlyCollection<NotificationModel> Get()
        {
            return _notificationsService.GetAllNotifications();
        }
    }
}
