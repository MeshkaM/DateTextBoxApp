using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTextBoxApp.CustomControls
{
    public class CustomDateControl : ModelBase
    {
        private string _Year;
        private string _Month;
        private string _Day;

        public string Year
        {
            get => _Year;
            set
            {
                _Year = value;
                OnChange();
                OnPropertyChanged();

            }
        }

        public string Month
        {
            get => _Month;
            set
            {
                _Month = value;
                OnChange();
                OnPropertyChanged();
            }
        }

        public string Day
        {
            get => _Day;
            set
            {
                _Day = value;
                OnChange();
                OnPropertyChanged();
            }
        }

        private void OnChange()
        {
            bool has_y = !string.IsNullOrWhiteSpace(Year);
            bool has_m = !string.IsNullOrWhiteSpace(Month);
            bool has_d = !string.IsNullOrWhiteSpace(Day);
            if (has_y && has_m && has_d)
            {
                FullDate = $"{Day} / {Month} / {Year}";
            }
            else if (has_y && has_m && !has_d)
            {
                FullDate = $"{Month} / {Year}";
            }
            else if (has_y && !has_m && !has_d)
            {
                FullDate = $"{Year}";
            }
            else
            {
                FullDate = null;
            }
        }

        public string FullDate
        {
            get => _FullDate;
            set
            {
                _FullDate = value;
                OnPropertyChanged();
            }
        }
        private string _FullDate;
    }

    public class ModelBase : System.ComponentModel.INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
