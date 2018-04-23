Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1.ViewModels
    Public Class ViewModelModuleA
        Public Property AllowAnotherAction() As Boolean
            Get
                Return m_AllowAnotherAction
            End Get
            Private Set(value As Boolean)
                m_AllowAnotherAction = Value
            End Set
        End Property
        Private m_AllowAnotherAction As Boolean
        Friend Sub DoSomeAction()
            AllowAnotherAction = True
        End Sub
        Friend Sub ResetSomeAction()
            AllowAnotherAction = False
        End Sub
    End Class
End Namespace
