Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication1.ViewModels
    Public Class ViewModelModuleB
        Public Property Flag() As Boolean
            Get
                Return m_Flag
            End Get
            Set(value As Boolean)
                m_Flag = Value
            End Set
        End Property
        Private m_Flag As Boolean

        Public Property IsSpecificState() As Boolean
            Get
                Return m_IsSpecificState
            End Get
            Set(value As Boolean)
                m_IsSpecificState = Value
            End Set
        End Property
        Private m_IsSpecificState As Boolean
        Public Sub SetSpecicState()
            IsSpecificState = True
        End Sub
        Public Sub ResetSpecificState()
            IsSpecificState = False
        End Sub
    End Class
End Namespace
