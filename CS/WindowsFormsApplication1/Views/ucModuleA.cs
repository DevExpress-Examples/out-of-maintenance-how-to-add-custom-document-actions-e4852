using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using WindowsFormsApplication1.ViewModels;

namespace WindowsFormsApplication1.Views {
    public partial class ucModuleA : UserControl, ISupportDocumentActions {
        ViewModelModuleA viewModel;
        public ucModuleA(ViewModelModuleA viewModel) {
            this.viewModel = viewModel;
            InitializeComponent();
        }
        #region ISupportDocumentActions Members
        public void OnQueryDocumentActions(IDocumentActionsArgs args) {
            args.DocumentActions.Add(new DocumentAction(DoAction1) { Caption = "Action 1" });
            args.DocumentActions.Add(new DocumentAction(CanDoAction2, DoAction2) { Caption = "Action 2" });
        }
        #endregion
        void DoAction1(Document document) {
            bool prev = viewModel.AllowAnotherAction;
            viewModel.DoSomeAction(); 
            MessageBox.Show("Some Action");
            if(!prev && prev != viewModel.AllowAnotherAction)
                MessageBox.Show("Action 2 enabled");
        }
        bool CanDoAction2(Document document) {
            return viewModel.AllowAnotherAction;
        }
        void DoAction2(Document document) {
            MessageBox.Show("Action 2 disabled");
            viewModel.ResetSomeAction();
        }
    }
}