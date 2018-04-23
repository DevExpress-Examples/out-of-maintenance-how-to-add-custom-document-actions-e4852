Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI

Namespace WindowsFormsApplication1
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			pageGroup1.Properties.ShowPageHeaders = DevExpress.Utils.DefaultBoolean.False
			AddHandler windowsUIView1.QueryDocumentActions, AddressOf windowsUIView1_QueryDocumentActions
			AddHandler windowsUIView1.TileClick, AddressOf windowsUIView1_TileClick
		End Sub
		Private Sub windowsUIView1_TileClick(ByVal sender As Object, ByVal e As TileClickEventArgs)
            If e.Tile Is document1Tile Then
                page1.Document = document1
            End If
            If e.Tile Is document2Tile Then
                page1.Document = document2
            End If
		End Sub
		Private Sub windowsUIView1_QueryControl(ByVal sender As Object, ByVal e As QueryControlEventArgs) Handles windowsUIView1.QueryControl
			If e.Document Is document1 Then
				e.Control = New Views.ucModuleA(New ViewModels.ViewModelModuleA())
			End If
			If e.Document Is document2 Then
				e.Control = New Views.ucModuleB(New ViewModels.ViewModelModuleB())
			End If
		End Sub
		'
        Private Sub windowsUIView1_QueryDocumentActions(sender As Object, e As QueryDocumentActionsEventArgs)
            e.DocumentActions.Add(New DocumentAction(Sub(doc) Hello(e.Document)) With { _
                 .Caption = "Hello" _
            })
            If e.Source Is pageGroup1 Then
                e.DocumentActions.Add(New DocumentAction(Function(doc) doc Is document2, Sub(doc) windowsUIView1.ActivateDocument(document1)) With { _
                     .Caption = "Document 1" _
                })
                e.DocumentActions.Add(New DocumentAction(Function(doc) doc Is document1, Sub(doc) windowsUIView1.ActivateDocument(document2)) With { _
                     .Caption = "Document 2" _
                })
            End If
        End Sub
		Private Sub Hello(ByVal document As Document)
			MessageBox.Show("Hello from " & document.Caption)
		End Sub
	End Class
End Namespace