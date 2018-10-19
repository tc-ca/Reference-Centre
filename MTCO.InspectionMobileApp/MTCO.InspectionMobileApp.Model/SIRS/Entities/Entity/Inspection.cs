using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace MTCO.InspectionMobileApp.Dto.SIRS
{
    public class Inspection: INotifyPropertyChanged
    {
        #region Methods


        private void HasChangedCheck(object sender, PropertyChangedEventArgs e)
        {
            Inspection copiedInspection;
            copiedInspection = OriginalInspection;

            HasChanged = false;

            if (copiedInspection.InspSignatureSrc == null)
            {
                if (InspSignatureSrc != null)
                {
                    HasChanged = true;
                }
            }
            else
            {
                if (InspSignatureSrc == null)
                {
                    HasChanged = true;
                }
                else
                {
                    if (!copiedInspection.InspSignatureSrc.SequenceEqual(InspSignatureSrc))
                    {
                        HasChanged = true;
                    }
                }
            }

            if (copiedInspection.RepSignatureSrc == null)
            {
                if (RepSignatureSrc != null)
                {
                    HasChanged = true;
                }
            }
            else
            {
                if(RepSignatureSrc == null)
                {
                    HasChanged = true;
                }
                else
                {
                    if (!copiedInspection.RepSignatureSrc.SequenceEqual(RepSignatureSrc))
                    {
                        HasChanged = true;
                    }
                }
            }

            if (
                copiedInspection.VesselName != this.VesselName ||
                copiedInspection.MarineSafetyOffice != this.MarineSafetyOffice ||
                copiedInspection.Address != this.Address ||
                copiedInspection.InspectorName != this.InspectorName ||
                copiedInspection.InspectionDate != this.InspectionDate ||
                copiedInspection.PlaceOfInspection != this.PlaceOfInspection ||
                copiedInspection.DocumnetNo != this.DocumnetNo ||
                copiedInspection.InspectorSignDate != this.InspectorSignDate ||
                copiedInspection.ReceiptName != this.ReceiptName ||
                copiedInspection.Email != this.Email ||
                copiedInspection.Telephone != this.Telephone ||
                copiedInspection.Fax != this.Fax ||
                copiedInspection.ReceiptSignDate != this.ReceiptSignDate
            )
            {
                HasChanged = true;
            }
        }
        public Inspection OriginalInspection { get; set; }
        public Inspection Copy()
        {
            Inspection copiedInspection = new Inspection();
            #region Editable Inspection Info
            copiedInspection.VesselName = this.VesselName;
            copiedInspection.InspectionDate = this.InspectionDate;
            copiedInspection.PlaceOfInspection = this.PlaceOfInspection;
            copiedInspection.DocumnetNo = this.DocumnetNo;
            copiedInspection.InspectorSignDate = this.InspectorSignDate;
            copiedInspection.ReceiptName = this.ReceiptName;
            copiedInspection.ReceiptSignDate = this.ReceiptSignDate;            
            #endregion

            #region Inspection Readonly info
            copiedInspection.FileNumber = this.FileNumber;
            copiedInspection.InspectorNames = this.InspectorNames;
            copiedInspection.OfficialNumber = this.OfficialNumber;
            copiedInspection.Status = this.Status;
            copiedInspection.Type = this.Type;
            #endregion

            #region User Profile not editable from ViewEditInspection
            copiedInspection.InspectorName = this.InspectorName;
            copiedInspection.MarineSafetyOffice = this.MarineSafetyOffice;
            copiedInspection.Address = this.Address;
            copiedInspection.Telephone = this.Telephone;
            copiedInspection.Fax = this.Fax;
            copiedInspection.Email = this.Email;
            #endregion

            copiedInspection.InspSignatureSrc = this.InspSignatureSrc;
            copiedInspection.RepSignatureSrc = this.RepSignatureSrc;
            return copiedInspection;
        }

        public bool HasChangedCheck()
        {
            bool hasChanged = false;
            Inspection copiedInspection;
            copiedInspection = OriginalInspection;
            if (copiedInspection == null)
            {
                HasChanged = false;
                return HasChanged;
            }

            if(
                copiedInspection.VesselName != this.VesselName ||
                copiedInspection.Address != this.Address ||
                copiedInspection.InspectorName != this.InspectorName ||
                copiedInspection.InspectionDate != this.InspectionDate ||
                copiedInspection.PlaceOfInspection != this.PlaceOfInspection ||
                copiedInspection.DocumnetNo != this.DocumnetNo ||
                copiedInspection.InspectorSignDate != this.InspectorSignDate ||
                copiedInspection.ReceiptName != this.ReceiptName ||
                copiedInspection.Email != this.Email ||
                copiedInspection.Telephone != this.Telephone ||
                copiedInspection.Fax != this.Fax ||
                copiedInspection.ReceiptSignDate != this.ReceiptSignDate
            )
            {
                hasChanged = true;
            }

            HasChanged = hasChanged;
            return hasChanged;
        }
        #endregion
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

        private DateTime? _inspectionDate;
        public DateTime? InspectionDate
        {
            get
            {
                return _inspectionDate;
            }
            set
            {
                if(_inspectionDate != value)
                {
                    _inspectionDate = value;
                    OnPropertyChanged("InspectionDate");
                }
            }
        }

        private string _placeOfInspection;
        public string PlaceOfInspection
        {
            get
            {
                return _placeOfInspection;
            }
            set
            {
                if(_placeOfInspection != value)
                {
                    if(string.IsNullOrEmpty(value))
                    {
                        _placeOfInspection = null;
                    }
                    else
                    {
                        _placeOfInspection = value;
                    }
                    OnPropertyChanged("PlaceOfInspection");
                }
            }
        }

        private string _documentNo;
        public string DocumnetNo
        {
            get
            {
                return _documentNo;
            }
            set
            {
                if (_documentNo != value)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        _documentNo = null;
                    }
                    else
                    {
                        _documentNo = value;
                    }                    

                    OnPropertyChanged("DocumentNo");
                }
            }
        }

        private DateTime? _inspectorSignDate;
        public DateTime? InspectorSignDate
        {
            get
            {
                return _inspectorSignDate;
            }
            set
            {
                if (_inspectorSignDate != value)
                {
                    _inspectorSignDate = value;
                    OnPropertyChanged("InspectorSignDate");
                }
            }
        }

        private string _receiptName;
        public string ReceiptName
        {
            get
            {
                return _receiptName;
            }
            set
            {
                if (_receiptName != value)
                {
                    if(string.IsNullOrEmpty(value))
                    {
                        _receiptName = null;
                    }
                    else
                    {
                        _receiptName = value;
                    }

                    OnPropertyChanged("ReceiptName");
                }
            }
        }

        private DateTime? _receiptSignDate;
        public DateTime? ReceiptSignDate
        {
            get
            {
                return _receiptSignDate;
            }
            set
            {
                if (_receiptSignDate != value)
                {
                    _receiptSignDate = value;
                    OnPropertyChanged("ReceiptSignDate");
                }
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
                }
            }
        }

        private decimal? _telephone;
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
                    _telephone = value;
                    OnPropertyChanged("Telephone");
                }
            }
        }

        private decimal? _fax;
        public decimal? Fax
        {
            get
            {
                return _fax;
            }
            set
            {
                if(_fax != value)
                {
                    _fax = value;
                    OnPropertyChanged("Fax");
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
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal InspectionID { get; set; }
        private ObservableCollection<ListDeficiency> _deficiencies;
        public ObservableCollection<ListDeficiency> Deficiencies
        {
            get
            {
                return _deficiencies;
            }
            set
            {
                _deficiencies = value;
                OnPropertyChanged("Deficiencies");
            }
        }
        public ObservableCollection<ListInspector> Inspectors { get; set; }
        private string _vesselName;
        public string VesselName
        {
            get
            {
                return _vesselName;
            }
            set
            {
                if (_vesselName != value)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        _vesselName = null;
                    }
                    else
                    {
                        _vesselName = value;
                    }
                    this.OnPropertyChanged("VesselName");
                }
            }
        }
        public string FormerVesselName { get; set; }
        public decimal? FileNumber { get; set; }
        public decimal? OfficialNumber { get; set; }
        private string _InspectorNames = "";
        public string InspectorNames
        {
            get
            {
                string names = string.Empty;
                string separator = string.Empty;
                int index = 0;
                foreach (ListInspector i in Inspectors)
                {
                    index++;
                    if(index == Inspectors.Count)
                    {
                        separator = string.Empty;
                    }
                    else
                    {
                        separator = ", ";
                    }
                    names = names + i.Name + separator;
                }
                return names; 
            }
            set
            {
                _InspectorNames = value;
            }
        }


        public string Status { get; set; }
        public string Type { get; set; }

        private byte[] _inspSignatureImg;
        private byte[] _repSignatureImg;
        public byte[] InspSignatureImg
        {
            get { return _inspSignatureImg; }
            set
            {
                _inspSignatureImg = value;
                OnPropertyChanged("InspSignatureImg");
            }
        }

        public byte[] RepSignatureImg
        {
            get { return _repSignatureImg; }
            set
            {
                _repSignatureImg = value;
                OnPropertyChanged("RepSignatureImg");
            }
        }

        //public byte[] InspSignatureSrc { get; set; }
        private byte[] _inspSignatureSrc;
        public byte[] InspSignatureSrc
        {
            get
            {
                return _inspSignatureSrc;
            }
            set
            {
                if (value == null)
                {
                    if (_inspSignatureSrc != null)
                    {
                        _inspSignatureSrc = value;
                        OnPropertyChanged("InspSignatureSrc");
                    }
                }
                else
                {
                    //if (!_inspSignatureSrc.SequenceEqual(value))
                    //{
                    //    _inspSignatureSrc = value;
                    //    OnPropertyChanged("InspSignatureSrc");
                    //}
                    if (value.Length == 8) // Image source has been cleared after calling DigitalSignature.Strokes.Clear() which "clear" image source byte array to have length 8)  
                    {
                        _inspSignatureSrc = null;
                    }
                    else
                    {
                        _inspSignatureSrc = value;
                    }
                    OnPropertyChanged("InspSignatureSrc");
                }
            }
        }

        private byte[] _repSignatureSrc;
        public byte[] RepSignatureSrc
        {
            get
            {
                return _repSignatureSrc;
            }
            set
            {
                if (_repSignatureSrc == null)
                {
                    if (value != null)
                    {
                        _repSignatureSrc = value;
                        OnPropertyChanged("RepSignatureSrc");
                    }
                }
                else
                {
                    if (!_repSignatureSrc.SequenceEqual(value))
                    {
                        _repSignatureSrc = value;
                        OnPropertyChanged("RepSignatureSrc");
                    }
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
                    if (name != "HasChanged" && name != "RepSignatureImg" && name != "InspSignatureImg")
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
