using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace MTCO.InspectionMobileApp.Dto.SIRS
{
    public class InspectionDeficiency: INotifyPropertyChanged
    {
        private ObservableCollection<decimal> _actionsTaken = new ObservableCollection<decimal>();
        public ObservableCollection<decimal> ActionsTaken
        {
            get
            {
                return _actionsTaken;
            }
            set
            {
                _actionsTaken = value;
                OnPropertyChanged("ActionsTaken");
                HasChangedCheck(OriginalInspectionDeficiency);
            }
        }

        private ObservableCollection<decimal> _observations = new ObservableCollection<decimal>();
        public ObservableCollection<decimal> Observations
        {
            get
            {
                return _observations;
            }
            set
            {
                _observations = value;
                OnPropertyChanged("Observations");
                HasChangedCheck(OriginalInspectionDeficiency);
            }
        }
        public InspectionDeficiency()
        {
            //_actionsTaken.CollectionChanged += ContentCollectionChanged;
            //_observations.CollectionChanged += ContentCollectionChanged;
        }

        public void ContentCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                HasChanged = true;
                return;
            }
            else if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (decimal item in e.NewItems)
                {
                    HasChanged = true;
                    return;
                }
            }
        }

        //public void ContentCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        //{
        //    if (e.Action == NotifyCollectionChangedAction.Remove)
        //    {
        //        foreach (decimal item in e.OldItems)
        //        {
        //            //Removed items
        //            item.PropertyChanged -= EntityViewModelPropertyChanged;
        //        }
        //    }
        //    else if (e.Action == NotifyCollectionChangedAction.Add)
        //    {
        //        foreach (decimal item in e.NewItems)
        //        {
        //            //Added items
        //            item.PropertyChanged += EntityViewModelPropertyChanged;
        //        }
        //    }
        //}

        //public void EntityViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    //This will get called when the property of an object inside the collection changes
        //}

        public InspectionDeficiency OriginalInspectionDeficiency { get; set; }
        public InspectionDeficiency Copy()
        {

            InspectionDeficiency copiedInspectionDeficiency = new InspectionDeficiency();

            foreach(decimal action in this.ActionsTaken)
            {
                copiedInspectionDeficiency.ActionsTaken.Add(action);
            }

            foreach(decimal observation in this.Observations)
            {
                copiedInspectionDeficiency.Observations.Add(observation);
            }
            copiedInspectionDeficiency.ActionHistory = this.ActionHistory;
            copiedInspectionDeficiency.ARClosedDate = this.ARClosedDate;
            copiedInspectionDeficiency.ClosedByUser = this.ClosedByUser;
            copiedInspectionDeficiency.Comments = this.Comments;
            copiedInspectionDeficiency.ComplianceDueDate = this.ComplianceDueDate;
            copiedInspectionDeficiency.DateCompleted = this.DateCompleted;
            copiedInspectionDeficiency.DateDeficiencyCreated = this.DateDeficiencyCreated;
            copiedInspectionDeficiency.DeficiencyCD = this.DeficiencyCD;
            copiedInspectionDeficiency.ExtendedComplianceDueDate = this.ExtendedComplianceDueDate;
            copiedInspectionDeficiency.HasChanged = false;
            copiedInspectionDeficiency.InspectionID = this.InspectionID;
            copiedInspectionDeficiency.IsNew = this.IsNew;
            copiedInspectionDeficiency.ItemNo = this.ItemNo;
            copiedInspectionDeficiency.ROClosedDate = this.ROClosedDate;
            copiedInspectionDeficiency.SelectedDeficiencyCD = this.SelectedDeficiencyCD;
            copiedInspectionDeficiency.SuggestedReference = this.SuggestedReference;
            copiedInspectionDeficiency.Reference = this.Reference;
            return copiedInspectionDeficiency;
        }

        public bool HasChangedCheck(InspectionDeficiency copiedInspectionDeficiency)
        {
            bool hasChanged = false;
            if (IsNew)
            {
                HasChanged = true;
                return HasChanged;
            }
            if (copiedInspectionDeficiency == null)
            {
                HasChanged = false;
                return HasChanged;
            }

            if (ActionsTaken.Count == copiedInspectionDeficiency.ActionsTaken.Count)
            {
                foreach (decimal action in this.ActionsTaken)
                {
                    var found = copiedInspectionDeficiency.ActionsTaken.FirstOrDefault(i => i == action);
                    if (found == 0)
                    {
                        hasChanged =  true;
                    }
                }
            }
            else {
                hasChanged = true;
            }

            if(Observations.Count == copiedInspectionDeficiency.Observations.Count)
            {
                foreach (decimal observation in this.Observations)
                {
                    var found = copiedInspectionDeficiency.Observations.FirstOrDefault(i=> i == observation);
                    if(found == 0)
                    {
                        hasChanged = true;
                    }
                }
            }
            else
            {
                hasChanged= true;
            }

            if(
                copiedInspectionDeficiency.ActionHistory != this.ActionHistory ||
                copiedInspectionDeficiency.ARClosedDate != this.ARClosedDate ||
                copiedInspectionDeficiency.ClosedByUser != this.ClosedByUser ||
                copiedInspectionDeficiency.Comments != this.Comments ||
                copiedInspectionDeficiency.ComplianceDueDate != this.ComplianceDueDate ||
                copiedInspectionDeficiency.DateCompleted != this.DateCompleted ||
                copiedInspectionDeficiency.DateDeficiencyCreated != this.DateDeficiencyCreated ||
                copiedInspectionDeficiency.DeficiencyCD != this.DeficiencyCD ||
                copiedInspectionDeficiency.ExtendedComplianceDueDate != this.ExtendedComplianceDueDate ||
                copiedInspectionDeficiency.InspectionID != this.InspectionID ||
                copiedInspectionDeficiency.IsNew != this.IsNew ||
                copiedInspectionDeficiency.ItemNo != this.ItemNo ||
                copiedInspectionDeficiency.Reference != this.Reference ||
                copiedInspectionDeficiency.ROClosedDate != this.ROClosedDate ||
                copiedInspectionDeficiency.SelectedDeficiencyCD != this.SelectedDeficiencyCD ||
                copiedInspectionDeficiency.SuggestedReference != this.SuggestedReference
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
            if (IsNew)
            {
                HasChanged = true;
                return ;
            }
            if (OriginalInspectionDeficiency == null)
            {
                HasChanged = false;
                return;
            }

            if (ActionsTaken.Count == OriginalInspectionDeficiency.ActionsTaken.Count)
            {
                foreach (decimal action in this.ActionsTaken)
                {
                    var found = OriginalInspectionDeficiency.ActionsTaken.FirstOrDefault(i => i == action);
                    if (found == 0)
                    {
                        HasChanged =  true;
                    }
                }
            }
            else {
                HasChanged = true;
            }

            if (Observations.Count == OriginalInspectionDeficiency.Observations.Count)
            {
                foreach (decimal observation in this.Observations)
                {
                    var found = OriginalInspectionDeficiency.Observations.FirstOrDefault(i => i == observation);
                    if(found == 0)
                    {
                        HasChanged = true;
                    }
                }
            }
            else
            {
                HasChanged= true;
            }

            if(
                OriginalInspectionDeficiency.ActionHistory != this.ActionHistory ||
                OriginalInspectionDeficiency.ARClosedDate != this.ARClosedDate ||
                OriginalInspectionDeficiency.ClosedByUser != this.ClosedByUser ||
                OriginalInspectionDeficiency.Comments != this.Comments ||
                OriginalInspectionDeficiency.ComplianceDueDate != this.ComplianceDueDate ||
                OriginalInspectionDeficiency.DateCompleted != this.DateCompleted ||
                OriginalInspectionDeficiency.DateDeficiencyCreated != this.DateDeficiencyCreated ||
                OriginalInspectionDeficiency.DeficiencyCD != this.DeficiencyCD ||
                OriginalInspectionDeficiency.ExtendedComplianceDueDate != this.ExtendedComplianceDueDate ||
                OriginalInspectionDeficiency.InspectionID != this.InspectionID ||
                OriginalInspectionDeficiency.IsNew != this.IsNew ||
                OriginalInspectionDeficiency.ItemNo != this.ItemNo ||
                OriginalInspectionDeficiency.Reference != this.Reference ||
                OriginalInspectionDeficiency.ROClosedDate != this.ROClosedDate ||
                OriginalInspectionDeficiency.SelectedDeficiencyCD != this.SelectedDeficiencyCD ||
                OriginalInspectionDeficiency.SuggestedReference != this.SuggestedReference
            )
            {
                HasChanged = true;
            }
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
        public string SelectedDeficiencyCD { get; set; } 
        public string DeficiencyCD { get; set; } 
        public decimal    InspectionID { get; set; }
        public DateTime DateDeficiencyCreated { get; set; }

        private int _ItemNo;
        public int ItemNo
        {
            get
            {
                return _ItemNo;
            }
            set
            {
                if(_ItemNo != value)
                {
                    _ItemNo = value;
                    OnPropertyChanged("ItemNo");
                    HasChangedCheck(OriginalInspectionDeficiency);
                }
            }
        }

        public string SuggestedReference { get; set; }

        private string _reference;
        public string Reference
        {
            get

            {
                return _reference;
            }
            set
            { 
                if(_reference != value)
                {
                    if(string.IsNullOrEmpty(value))
                    {
                        _reference = null;
                    }
                    else
                    {
                        _reference = value;
                    }
                    OnPropertyChanged("Reference");
                    HasChangedCheck(OriginalInspectionDeficiency);
                }
            }
        }

        private string _comments;
        public string Comments
        {
            get
            {
                return _comments;
            }
            set
            { 
                if(_comments != value)
                {
                    if(string.IsNullOrEmpty(value))
                    {
                        _comments = null;
                    }
                    else
                    {
                        _comments = value;
                    }
                    OnPropertyChanged("Comments");
                    HasChangedCheck(OriginalInspectionDeficiency);
                }
            }
        }
        
        private DateTime? _complianceDueDate;
        [System.ComponentModel.DefaultValue(null)]
        public DateTime? ComplianceDueDate
        {
            get
            {
                return _complianceDueDate;
            }
            set
            {
                if(_complianceDueDate != value)
                {
                    _complianceDueDate = value;
                    OnPropertyChanged("ComplianceDueDate");
                    HasChangedCheck(OriginalInspectionDeficiency);
                }
            }
        }

        private DateTime? _extendedComplianceDueDate;
        public DateTime? ExtendedComplianceDueDate
        {
            get
            {
                return _extendedComplianceDueDate;
            }
            set
            {
                if (_extendedComplianceDueDate != value)
                {
                    _extendedComplianceDueDate = value;
                    OnPropertyChanged("ExtendedComplianceDueDate");
                    HasChangedCheck(OriginalInspectionDeficiency);
                }
            }
        } //only visiable on edit

        private decimal? _closedByUser;
        public decimal? ClosedByUser
        {
            get
            {
                return _closedByUser;
            }
            set
            {
                if(_closedByUser != value)
                {
                    _closedByUser = value;
                    OnPropertyChanged("ClosedByUser");
                    HasChangedCheck(OriginalInspectionDeficiency);
                }
            }
        } //SIRS User ID

        private DateTime? _aRClosedDate;
        public DateTime? ARClosedDate
        {
            get
            {
                return _aRClosedDate;
            }
            set
            {
                if(_aRClosedDate != value)
                {
                    _aRClosedDate = value;
                    OnPropertyChanged("ARClosedDate");
                    HasChangedCheck(OriginalInspectionDeficiency);
                }
            }
        } //AR Cosed DATE

        private DateTime? _rOClosedDate;
        public DateTime? ROClosedDate
        {
            get
            {
                return _rOClosedDate;
            }
            set
            {
                if (_rOClosedDate != value)
                {
                    _rOClosedDate = value;
                    OnPropertyChanged("ROClosedDate");
                    HasChangedCheck(OriginalInspectionDeficiency);
                }
            }
        }


        private DateTime? _dateCompleted = null;
        public DateTime? DateCompleted
        {
            get
            {
                return _dateCompleted;
            }
            set
            {
                if (_dateCompleted != value)
                {
                    _dateCompleted = value;
                    OnPropertyChanged("DateCompleted");
                    HasChangedCheck(OriginalInspectionDeficiency);
                }
            }
        } //TC Cosed DATE

        private string _actionHistory;
        public string ActionHistory
        {
            get
            {
                return _actionHistory;
            }
            set
            { 
                if(_actionHistory != value)
                {
                    _actionHistory = value;
                    OnPropertyChanged("ActionHistory");
                    HasChangedCheck(OriginalInspectionDeficiency);
                }
            }
        }
        public bool IsNew { get; set; }

        #region Property Changed Notification
        // Declare the event
        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                //if(name != "HasChanged")
                //{
                //    handler += HasChangedCheck;
                //}
                handler(this, new PropertyChangedEventArgs(name));
                //handler -= HasChangedCheck;
            }
        }
        #endregion

    }
}
