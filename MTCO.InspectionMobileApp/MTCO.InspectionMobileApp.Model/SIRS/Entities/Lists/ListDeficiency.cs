using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MTCO.InspectionMobileApp.Dto.SIRS
{
    public class ListDeficiency: INotifyPropertyChanged
    {

        private int _index;
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
                OnPropertyChanged("Index");
            }
        }
        public string DeficiencyCD { get; set; } 
        public decimal      InspectionID { get; set; }
        public DateTime DateDeficiencyCreated { get; set; }

        private int _itemNo;
        //[DisplayName("Item Number is mandatory")]
        //[Required]
        public int ItemNo
        {
            get
            {
                return _itemNo;
            }
            set
            {
                _itemNo = value;
                OnPropertyChanged("ItemNo");
            }
        }
        public string Description { get; set; }
        public string Observation { get; set; }
        public string Reference { get; set; }
        public string Comments { get; set; }
        public string ActionTaken { get; set; }
        public DateTime? ComplianceDueDate { get; set; }
        public DateTime? DateCompleted { get; set; }

        #region Property Changed Notification
            // Declare the event
            public event PropertyChangedEventHandler PropertyChanged;
            // Create the OnPropertyChanged method to raise the event
            protected void OnPropertyChanged(string name)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(name));
                }
            }
        #endregion



    }
}
