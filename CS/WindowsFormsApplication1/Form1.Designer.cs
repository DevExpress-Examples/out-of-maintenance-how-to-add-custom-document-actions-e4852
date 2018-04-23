namespace WindowsFormsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.tileContainer1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.page1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(this.components);
            this.document1Tile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.document2Tile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.document2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tile1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageGroup1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1Tile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2Tile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.windowsUIView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
            // 
            // windowsUIView1
            // 
            this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.tileContainer1,
            this.page1,
            this.pageGroup1});
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document1,
            this.document2});
            this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.document1Tile,
            this.document2Tile,
            this.tile1});
            this.windowsUIView1.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.windowsUIView1_QueryControl);
            // 
            // tileContainer1
            // 
            this.tileContainer1.ActivationTarget = this.page1;
            this.tileContainer1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.document1Tile,
            this.document2Tile,
            this.tile1});
            this.tileContainer1.Name = "tileContainer1";
            // 
            // page1
            // 
            this.page1.Caption = "Page";
            this.page1.Document = null;
            this.page1.Name = "page1";
            this.page1.Parent = this.tileContainer1;
            // 
            // document1Tile
            // 
            this.document1Tile.Document = this.document1;
            tileItemElement1.Text = "Module A";
            this.document1Tile.Elements.Add(tileItemElement1);
            this.document1Tile.Name = "document1Tile";
            // 
            // document1
            // 
            this.document1.Caption = "Document 1";
            this.document1.ControlName = "document1";
            // 
            // document2Tile
            // 
            this.document2Tile.Document = this.document2;
            tileItemElement2.Text = "Module B";
            this.document2Tile.Elements.Add(tileItemElement2);
            this.tileContainer1.SetID(this.document2Tile, 1);
            this.document2Tile.Name = "document2Tile";
            // 
            // document2
            // 
            this.document2.Caption = "Document 2";
            this.document2.ControlName = "document2";
            // 
            // tile1
            // 
            this.tile1.ActivationTarget = this.pageGroup1;
            tileItemElement3.Text = "Page Group";
            this.tile1.Elements.Add(tileItemElement3);
            this.tileContainer1.SetID(this.tile1, 2);
            this.tile1.Name = "tile1";
            // 
            // pageGroup1
            // 
            this.pageGroup1.Caption = "Page Group";
            this.pageGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.document1,
            this.document2});
            this.pageGroup1.Name = "pageGroup1";
            this.pageGroup1.Parent = this.tileContainer1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 503);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1Tile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2Tile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page page1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile document1Tile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile document2Tile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document2;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup pageGroup1;
    }
}

