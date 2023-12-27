using DateTextBoxApp.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DateTextBoxApp.Models
{
    public class CustomerModel : INotifyPropertyChanged
    {
        private int _CustomerID;
        public int CustomerID
        {
            get { return _CustomerID; }
            set
            {
                if (value != _CustomerID)
                {
                    _CustomerID = value;
                    OnPropertyChanged(nameof(CustomerID));
                }
            }
        }

        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (value != _FirstName)
                {
                    _FirstName = value;
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }

        private string _DateOfBirth;
        public string DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {
                if (value != _DateOfBirth)
                {
                    _DateOfBirth = value;
                    OnPropertyChanged(nameof(DateOfBirth));
                }
            }
        }


        //*********************************************************************************************************************************************************************************************************************88
        //*********************************************************************************************************************************************************************************************************************88
        //*********************************************************************************************************************************************************************************************************************88

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
