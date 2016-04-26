using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
using BotFactory.Interface;

namespace BotFactory.Models
{
    public class TestingUnit : ITestingUnit
    {

        public double buildTime;
        public bool isWorking;
        public string model;
        public string name;
        public double speed;
        public Coordinates parkingPos;
        public Coordinates workingPos;

        public TestingUnit() { 

        }

        public TestingUnit(double _buildTime,bool _isWorking,string _model, string _name,double _speed,Coordinates _parkingPos,Coordinates _workingPos)
        {
            buildTime = _buildTime;
            isWorking = _isWorking;
            model = _model;
            name = _name;
            speed = _speed;
            parkingPos = _parkingPos;
            workingPos = _workingPos;

        }

        public double BuildTime
        {
            get
            {
                return buildTime;
            }

            set
            {
                value = buildTime;
            }
        }

        public bool IsWorking
        {
            get
            {
                return isWorking;
            }

            set
            {
                value = isWorking;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                value = model;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                value = name;
            }
        }

        public Coordinates ParkingPos
        {
            get
            {
                return parkingPos;
            }

            set
            {
                value = parkingPos;
            }
        }

        public double Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public Coordinates WorkingPos
        {
            get
            {
                return workingPos;
            }

            set
            {
                value = workingPos;
            }
        }
    }
}
