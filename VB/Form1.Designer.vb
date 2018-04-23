Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim tileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
			Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
			Me.windowsUIView1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(Me.components)
			Me.tileContainer1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(Me.components)
			Me.page1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(Me.components)
			Me.document1Tile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
			Me.document1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
			Me.document2Tile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
			Me.document2 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
			Me.tile1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
			Me.pageGroup1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(Me.components)
			CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tileContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.page1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document1Tile, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document2Tile, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tile1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pageGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' documentManager1
			' 
			Me.documentManager1.ContainerControl = Me
			Me.documentManager1.View = Me.windowsUIView1
			Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.windowsUIView1})
			' 
			' windowsUIView1
			' 
			Me.windowsUIView1.ContentContainers.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer() { Me.tileContainer1, Me.page1, Me.pageGroup1})
			Me.windowsUIView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() { Me.document1, Me.document2})
			Me.windowsUIView1.Tiles.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() { Me.document1Tile, Me.document2Tile, Me.tile1})
'			Me.windowsUIView1.QueryControl += New DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(Me.windowsUIView1_QueryControl);
			' 
			' tileContainer1
			' 
			Me.tileContainer1.ActivationTarget = Me.page1
			Me.tileContainer1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() { Me.document1Tile, Me.document2Tile, Me.tile1})
			Me.tileContainer1.Name = "tileContainer1"
			' 
			' page1
			' 
			Me.page1.Caption = "Page"
			Me.page1.Document = Nothing
			Me.page1.Name = "page1"
			Me.page1.Parent = Me.tileContainer1
			' 
			' document1Tile
			' 
			Me.document1Tile.Document = Me.document1
			tileItemElement1.Text = "Module A"
			Me.document1Tile.Elements.Add(tileItemElement1)
			Me.document1Tile.Name = "document1Tile"
			' 
			' document1
			' 
			Me.document1.Caption = "Document 1"
			Me.document1.ControlName = "document1"
			' 
			' document2Tile
			' 
			Me.document2Tile.Document = Me.document2
			tileItemElement2.Text = "Module B"
			Me.document2Tile.Elements.Add(tileItemElement2)
			Me.tileContainer1.SetID(Me.document2Tile, 1)
			Me.document2Tile.Name = "document2Tile"
			' 
			' document2
			' 
			Me.document2.Caption = "Document 2"
			Me.document2.ControlName = "document2"
			' 
			' tile1
			' 
			Me.tile1.ActivationTarget = Me.pageGroup1
			tileItemElement3.Text = "Page Group"
			Me.tile1.Elements.Add(tileItemElement3)
			Me.tileContainer1.SetID(Me.tile1, 2)
			Me.tile1.Name = "tile1"
			' 
			' pageGroup1
			' 
			Me.pageGroup1.Caption = "Page Group"
			Me.pageGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document() { Me.document1, Me.document2})
			Me.pageGroup1.Name = "pageGroup1"
			Me.pageGroup1.Parent = Me.tileContainer1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(874, 503)
			Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tileContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.page1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document1Tile, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document2Tile, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tile1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pageGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
		Private WithEvents windowsUIView1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView
		Private tileContainer1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer
		Private page1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page
		Private document1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private document1Tile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
		Private document2Tile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
		Private document2 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private tile1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
		Private pageGroup1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup
	End Class
End Namespace

