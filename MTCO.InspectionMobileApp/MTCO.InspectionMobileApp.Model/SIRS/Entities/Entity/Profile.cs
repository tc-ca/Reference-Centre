using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MTCO.InspectionMobileApp.Dto.SIRS
{
    public class Profile: INotifyPropertyChanged
    {
        public Profile OriginalProfile { get; set;}
        public Profile Copy()
        {
            Profile copiedProfile = new Profile();
            copiedProfile.IsEnglish = this.IsEnglish;
            copiedProfile.IsFrench = this.IsFrench;
            copiedProfile.InspectorName = this.InspectorName;
            copiedProfile.MarineSafetyOffice = this.MarineSafetyOffice;
            copiedProfile.Address = this.Address;
            copiedProfile.Telephone = this.Telephone;
            copiedProfile.Fax = this.Fax;
            copiedProfile.Email = this.Email;
            return copiedProfile;
        }

        private bool _hasChanged = false;
        public bool HasChanged
        {
            get
            {
                return _hasChanged;
            }
            set
            {
                _hasChanged = value;
                OnPropertyChanged("HasChanged");
            }
        }

        public bool HasChangedCheck(Profile copiedProfile)
        {
            bool hasChanged = false;
            if(copiedProfile == null)
            {
                return false;
            }
            if (
                //copiedProfile.IsFrench != this.IsFrench ||
                copiedProfile.IsEnglish != this.IsEnglish ||
                copiedProfile.Address != this.Address ||
                copiedProfile.Email != this.Email ||
                copiedProfile.Fax != this.Fax ||
                copiedProfile.InspectorName != this.InspectorName ||
                copiedProfile.MarineSafetyOffice != this.MarineSafetyOffice ||
                copiedProfile.Telephone != this.Telephone 
            )
            {
                hasChanged = true;
            }

            HasChanged = hasChanged;
            return hasChanged;
        }

        private void HasChangedCheck(object sender, PropertyChangedEventArgs e)
        {
            HasChanged = false;
            if (OriginalProfile == null)
            {
                return;
            }
            if (
                //OriginalProfile.IsFrench != this.IsFrench ||
                OriginalProfile.IsEnglish != this.IsEnglish ||
                OriginalProfile.Address != this.Address ||
                OriginalProfile.Email != this.Email ||
                OriginalProfile.Fax != this.Fax ||
                OriginalProfile.InspectorName != this.InspectorName ||
                OriginalProfile.MarineSafetyOffice != this.MarineSafetyOffice ||
                OriginalProfile.Telephone != this.Telephone
            )
            {
                HasChanged = true;
            }
        }
        private bool _isEnglish;
        public bool IsEnglish
        {
            get
            {
                return _isEnglish;
            }
            set
            {
                if (_isEnglish != value)
                {
                    _isEnglish = value;
                    OnPropertyChanged("IsEnglish");
                    //HasChangedCheck(OriginalProfile);
                }
            }
        }
        private bool _isFrench;
        public bool IsFrench
        {
            get
            {
                return _isFrench;
            }
            set
            {
                if (_isFrench != value)
                {
                    _isFrench = value;
                    OnPropertyChanged("IsFrench");
                }
                //IsEnglish = !_isFrench;
              //HasChangedCheck(OriginalProfile);
            }
        }

        private string _inspectorName;
        public string InspectorName
        {
            get
            {
                return _inspectorName;
            }
            set
            {
                if(_inspectorName != value)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        _inspectorName = null;
                    }
                    else
                    {
                        _inspectorName = value;
                    }
                    
                    OnPropertyChanged("InspectorName");
                    //HasChangedCheck(OriginalProfile);
                }
            }
        }

        private string _marineSafetyOffice;
        public string MarineSafetyOffice
        {
            get
            {
                return _marineSafetyOffice;
            }
            set
            {
                if(_marineSafetyOffice != value)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        _marineSafetyOffice = null;
                    }
                    else
                    {
                        _marineSafetyOffice = value;
                    }

                    OnPropertyChanged("MarineSafetyOffice");
                    //HasChangedCheck(OriginalProfile);
                }
            }
        }

        private string _address;
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if(_address != value)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        _address = null;
                    }
                    else
                    {
                        _address = value;
                    }

                    OnPropertyChanged("Address");
                    //HasChangedCheck(OriginalProfile);
                }
            }
        }


        private decimal? _fax = null;
        public decimal? Fax
        {
            get
            {
                return _fax;
            }
            set
            {
                if (_fax != value)
                {
                    if (value == null)
                    {
                        _fax = 0;
                    }
                    else
                    {
                        _fax = value;
                    }

                    OnPropertyChanged("Fax");
                   //HasChangedCheck(OriginalProfile);
                }
            }
        }

        private decimal? _telephone = null;
        public decimal? Telephone
        {
            get
            {
                return _telephone;
            }
            set
            {
             if(_telephone != value)
                {
                    if (value == null)
                    {
                        _telephone= 0;
                    }
                    else
                    {
                        _telephone = value;
                    }

                    OnPropertyChanged("Telephone");
                    //HasChangedCheck(OriginalProfile);
                }
            }
        }


        private string _email;
        [RegularExpression(@"\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b")]
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if(_email != value)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        _email = null;
                    }
                    else
                    {
                        _email = value;
                    }

                    this.OnPropertyChanged("Email");
                    //HasChangedCheck(OriginalProfile);
                }
            }
        }        
        
        #region Property Changed Notification
            // Declare the event
            public event PropertyChangedEventHandler PropertyChanged;
            // Create the OnPropertyChanged method to raise the event
            protected void OnPropertyChanged(string name)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    if(name != "HasChanged")
                    {
                        handler += HasChangedCheck;
                    }
                    handler(this, new PropertyChangedEventArgs(name));
                    handler -= HasChangedCheck;
                }
            }
        #endregion
    }
}
