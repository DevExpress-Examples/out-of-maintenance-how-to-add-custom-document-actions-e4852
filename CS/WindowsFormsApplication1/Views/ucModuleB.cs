using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using WindowsFormsApplication1.ViewModels;

namespace WindowsFormsApplication1.Views {
    public partial class ucModuleB : UserControl, ISupportDocumentActions {
        ViewModelModuleB viewModel;
        public ucModuleB(ViewModelModuleB viewModel) {
            this.viewModel = viewModel;
            InitializeComponent();
        }
        #region ISupportDocumentActions Members
        public void OnQueryDocumentActions(IDocumentActionsArgs args) {
            args.DocumentActions.Add(new DocumentCheckAction(() => viewModel.Flag, OnToggle) { Caption = "Flag" });
            args.DocumentActions.Add(new DocumentCheckAction(() => viewModel.IsSpecificState, OnCheck, OnUncheck) { Caption = "Specific State" });
        }
        #endregion
        void OnToggle(Document document) {
            viewModel.Flag = !viewModel.Flag;
            MessageBox.Show("Flag is " + (viewModel.Flag).ToString());
        }
        void OnCheck(Document document) {
            viewModel.SetSpecicState();
            MessageBox.Show("Specific state enabled");
        }
        void OnUncheck(Document document) {
            viewModel.ResetSpecificState();
            MessageBox.Show("Specific state disabled");
        }
    }
}