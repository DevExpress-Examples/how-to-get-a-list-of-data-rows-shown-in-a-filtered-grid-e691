Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Namespace WindowsApplication1
	Public Class Customer
		Public Sub New()

		End Sub

		' Fields...
		Private _ID As Integer
		Private _B As String
		Private _LastName As String
		Private _FirstName As String


		Public Property FirstName() As String
			Get
				Return _FirstName
			End Get
			Set(ByVal value As String)
				_FirstName = value
			End Set
		End Property


		Public Property LastName() As String
			Get
				Return _LastName
			End Get
			Set(ByVal value As String)
				_LastName = value
			End Set
		End Property




		Public Property ID() As Integer
			Get
				Return _ID
			End Get
			Set(ByVal value As Integer)
				_ID = value
			End Set
		End Property


	End Class
End Namespace
