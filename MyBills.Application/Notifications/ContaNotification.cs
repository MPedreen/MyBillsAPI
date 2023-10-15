using MediatR;
using MyBills.Application.Models.Queries;

namespace MyBills.Application.Notifications
{
    public class ContaNotification : INotification
    {
        public ActionNotificationEnum Action { get; set; }

        public ContaQuery Conta { get; set; }
    }
}
