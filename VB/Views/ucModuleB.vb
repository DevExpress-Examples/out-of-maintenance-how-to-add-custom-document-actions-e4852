Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports WindowsFormsApplication1.ViewModels

Namespace WindowsFormsApplication1.Views
	Public Partial Class ucModuleB
		Inherits UserControl
        Implements ISupportDocumentActions
        Private viewModel As ViewModelModuleB
        Public Sub New(ByVal viewModel As ViewModelModuleB)
            Me.viewModel = viewModel
            InitializeComponent()
        End Sub
#Region "ISupportDocumentActions Members"
        Public Sub OnQueryDocumentActions(args As IDocumentActionsArgs) Implements ISupportDocumentActions.OnQueryDocumentActions
            args.DocumentActions.Add(New DocumentCheckAction(Function() viewModel.Flag, Sub() OnToggle(args.Document)) With { _
                .Caption = "Flag" _
            })
            args.DocumentActions.Add(New DocumentCheckAction(Function() viewModel.IsSpecificState, Sub() OnCheck(args.Document), Sub() OnUncheck(args.Document)) With { _
                .Caption = "Specific State" _
            })
        End Sub
#End Region
        Private Sub OnToggle(ByVal document As Document)
            viewModel.Flag = Not viewModel.Flag
            MessageBox.Show("Flag is " & (viewModel.Flag).ToString())
        End Sub
        Private Sub OnCheck(ByVal document As Document)
            viewModel.SetSpecicState()
            MessageBox.Show("Specific state enabled")
        End Sub
        Private Sub OnUncheck(ByVal document As Document)
            viewModel.ResetSpecificState()
            MessageBox.Show("Specific state disabled")
        End Sub
    End Class
End Namespace