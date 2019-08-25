﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_UWP.Enums;

namespace Windows_UWP.ViewModels
{
    public class PromotionViewModel : INotifyPropertyChanged
    {
        public int Id { get; set; }
        private string _name;
        public string Name {
            get { return _name; }
            set {
                if(value == "" && value == null)
                {
                    throw new Exception("Naam van de promotie moet ingevuld zijn.");
                }
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        private PromotionType _promotionType = PromotionType.Andere;
        public PromotionType PromotionType {
            get { return _promotionType; }
            set {
                _promotionType = value;
                OnPropertyChanged("PromotionType");
            }
        }

        private DateTimeOffset _startDate;
        public DateTimeOffset StartDate {
            get { return _startDate; }
            set {
                _startDate = value;
                OnPropertyChanged("StartDate");
            }
        }

        private DateTimeOffset _endDate;
        public DateTimeOffset EndDate
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
                OnPropertyChanged("EndDate");
            }
        }
        public string EndDateString
        {
            get { return _endDate.ToString("d"); }
            
        }
        public string StartDateString
        {
            get { return _startDate.ToString("d"); }

        }
        public string _description;

        public string Description {
            get { return _description; }
            set {
                if (value == "" && value == null)
                {
                    throw new Exception("Description van de promotie moet ingevuld zijn.");
                }
                _description = value;
                OnPropertyChanged("Description");
            }
        }
        public DateTime Creation { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
