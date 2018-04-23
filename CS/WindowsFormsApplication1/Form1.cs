using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            pageGroup1.Properties.ShowPageHeaders = DevExpress.Utils.DefaultBoolean.False;
            windowsUIView1.QueryDocumentActions += windowsUIView1_QueryDocumentActions;
            windowsUIView1.TileClick += windowsUIView1_TileClick;
            windowsUIView1.AllowCaptionDragMove = DevExpress.Utils.DefaultBoolean.True;
        }
        void windowsUIView1_TileClick(object sender, TileClickEventArgs e) {
            if(e.Tile == document1Tile)
                page1.Document = document1;
            if(e.Tile == document2Tile)
                page1.Document = document2;
        }
        void windowsUIView1_QueryControl(object sender, QueryControlEventArgs e) {
            if(e.Document == document1)
                e.Control = new Views.ucModuleA(new ViewModels.ViewModelModuleA());
            if(e.Document == document2)
                e.Control = new Views.ucModuleB(new ViewModels.ViewModelModuleB());
        }
        //
        void windowsUIView1_QueryDocumentActions(object sender, QueryDocumentActionsEventArgs e) {
            e.DocumentActions.Add(new DocumentAction(Hello) { Caption = "Hello" });
            if (e.Source == pageGroup1) {
                e.DocumentActions.Add(new DocumentAction((doc) => doc == document2,
                    (doc) => windowsUIView1.ActivateDocument(document1)) { Caption = "Document 1" });
                e.DocumentActions.Add(new DocumentAction((doc) => doc == document1,
                    (doc) => windowsUIView1.ActivateDocument(document2)) { Caption = "Document 2" });
            }
        }
        void Hello(Document document) {
            MessageBox.Show("Hello from " + document.Caption);
        }
    }
}