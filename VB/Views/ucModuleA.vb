Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports WindowsFormsApplication1.ViewModels

Namespace WindowsFormsApplication1.Views
	Public Partial Class ucModuleA
		Inherits UserControl
        Implements ISupportDocumentActions
        Private viewModel As ViewModelModuleA
        Public Sub New(ByVal viewModel As ViewModelModuleA)
            Me.viewModel = viewModel
            InitializeComponent()
        End Sub
#Region "ISupportDocumentActions Members"
        Public Sub OnQueryDocumentActions(args As IDocumentActionsArgs) Implements ISupportDocumentActions.OnQueryDocumentActions
            args.DocumentActions.Add(New DocumentAction(Sub(doc) DoAction1(args.Document)) With { _
                 .Caption = "Action 1" _
            })
            args.DocumentActions.Add(New DocumentAction(Function(doc) CanDoAction2(args.Document), Sub(doc) DoAction2(args.Document)) With { _
                 .Caption = "Action 2" _
            })
        End Sub
#End Region

        Private Sub DoAction1(ByVal document As Document)
            Dim prev As Boolean = viewModel.AllowAnotherAction
            viewModel.DoSomeAction()
            MessageBox.Show("Some Action")
            If (Not prev) AndAlso prev <> viewModel.AllowAnotherAction Then
                MessageBox.Show("Action 2 enabled")
            End If
        End Sub
        Private Function CanDoAction2(ByVal document As Document) As Boolean
            Return viewModel.AllowAnotherAction
        End Function
        Private Sub DoAction2(ByVal document As Document)
            MessageBox.Show("Action 2 disabled")
            viewModel.ResetSomeAction()
        End Sub
    End Class
End Namespace