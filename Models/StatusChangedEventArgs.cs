using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Interface;

namespace BotFactory.Models
{
    public abstract class StatusChangedEventArgs : EventArgs, IStatusChangedEventArgs
    {

        string newStatus;

        public string NewStatus
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
