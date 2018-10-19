using MTCO.InspectionMobileApp.ReferenceCentre.ViewModels;
using System.Windows.Controls;

namespace MTCO.InspectionMobileApp.ReferenceCentre.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ReferenceCentre : UserControl
    {
        ReferenceCentreViewModel viewModel;
        public ReferenceCentre()
        {
            InitializeComponent();
            viewModel = (ReferenceCentreViewModel)DataContext;
        }
        
    }
}
