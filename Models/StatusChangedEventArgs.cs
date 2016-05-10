using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Interface;
using Common.Interfaces;

namespace BotFactory.Models
{
    public  class StatusChangedEventArgs : EventArgs, IStatusChangedEventArgs
    {
        public string newStatus;
        public IFactoryQueueElement firstQE;
        public ITestingUnit testunit;


        public StatusChangedEventArgs()
        {
        }

        public StatusChangedEventArgs(string _newStatus, IFactoryQueueElement _firstQE, ITestingUnit _testunit)
        {
            this.newStatus = _newStatus;
            this.firstQE = _firstQE;
            this.testunit = _testunit;
        }
 

        public string NewStatus
        {
            get
            {
                return newStatus;
            }

            set
            {
                newStatus = value;
            }
        }

        public IFactoryQueueElement FirstQE
        {
            get
            {
                return firstQE;
            }

            set
            {
                value = firstQE;
            }
        }

        public ITestingUnit Testunit
        {
            get
            {
                return testunit;
            }

            set
            {
               value = testunit;
            }
        }
    }
}
