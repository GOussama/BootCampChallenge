﻿using BotFactory.Common.Interfaces;
using BotFactory.Common.Tools;
using BotFactory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace BotFactory.Tools
{
    public class UnitDataContext : INotifyPropertyChanged
    {
        //private ITestableUnit _ibot = null;
        private ITestingUnit _ibot = null;
        private Boolean _response = false;
        private Boolean _working = false;
        private ObservableCollection<String> _reporting = new ObservableCollection<String>();

        #region Properties
        
       // public ITestableUnit IBot
        public ITestingUnit IBot
        {
            get { return _ibot; }
            set
            {
                if (_ibot != null)
                {
                    _ibot.UnitStatusChanged -= _ibot_UnitStatusChanged;
                }
                SetField(ref _ibot, value, nameof(IBot));
                _ibot.UnitStatusChanged += _ibot_UnitStatusChanged;
                Reports.Clear();
                ForceUpdate();
            }
        }

        public ObservableCollection<String> Reports
        {
            get
            {
                return _reporting;
            }
            set
            {
                SetField(ref _reporting, value, nameof(Reports));
                ForceUpdate();
            }
        }

        private void _ibot_UnitStatusChanged(object sender, EventArgs e)
        {
            Reports.Add(((StatusChangedEventArgs)e).NewStatus);
        }

        private void ForceUpdate()
        {
            Working = _ibot.IsWorking;
            BuildTime = 0;
            CurrentPos = null;
            Response = false;
        }

        public Boolean Response
        {
            get { return _response; }
            set { SetField(ref _response, value, nameof(Response)); }
        }

        public Boolean Working
        {
            get { return _working; }
            set { SetField(ref _working, value, nameof(Working)); }
        }

        public String Model
        {
            get { return _ibot.GetType().Name; }
            set { OnPropertyChanged("Model"); }
        }

        public Double BuildTime
        {
            get { return _ibot.BuildTime; }
            set { OnPropertyChanged("BuildTime"); }
        }

        public Coordinates CurrentPos
        {
            get { return _ibot.CurrentPos; }
            set { OnPropertyChanged("CurrentPos"); }
        }

        #endregion

        #region INotifyPropertyChanged Interface Methods

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion
    }
}
