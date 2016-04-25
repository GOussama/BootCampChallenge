using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Interface;

namespace BotFactory.Models
{
    public class EventArgs : IEventArgs
    {
        public string newStatus;

        string IEventArgs.NewStatus
        {
            get
            {
                return newStatus;
            }

            set
            {
                value = newStatus;
            }
        }
    }
}
