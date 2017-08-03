Option Strict Off
Option Explicit On
Friend Class CCompanys
	Implements System.Collections.IEnumerable
	' The private collection object
	Private m_CCompanys As Collection
	
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		
		m_CCompanys = New Collection
		
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	
	' This sub adds a new CCompanyData item to the collection.
	Sub Add(ByRef Item As CCompanyData, Optional ByRef Key As Object = Nothing)
		
		'TODO: Initialize the new CCompanyData item's properties here
		
		m_CCompanys.Add(Item) ', Key
		
	End Sub
	
	
	' This sub remove an item from the collection.
	Sub Remove(ByRef Index As Object)
		
		m_CCompanys.Remove(Index)
		
	End Sub
	
	
	' This function returns a CCompanyData item from the collection. It's the default method.
	Function Item(ByRef Index As Object) As CCompanyData
		
		Item = m_CCompanys.Item(Index)
		
	End Function
	
	
	' This property returns the number of items in the collection.
	ReadOnly Property Count() As Integer
		Get
			
			Count = m_CCompanys.Count()
			
		End Get
	End Property
	
	
	' This sub remove all items from the collection.
	Sub Clear()
		
		m_CCompanys = New Collection
		
	End Sub
	
	
	' This function adds "For Each" enumeration support. Must have a -4 DispID.
	'UPGRADE_NOTE: NewEnum property was commented out. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B3FC1610-34F3-43F5-86B7-16C984F0E88E"'
	'Function NewEnum() As stdole.IUnknown
		'
		'NewEnum = m_CCompanys.GetEnumerator
		'
	'End Function
	
	Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
		'UPGRADE_TODO: Uncomment and change the following line to return the collection enumerator. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="95F9AAD0-1319-4921-95F0-B9D3C4FF7F1C"'
		'GetEnumerator = m_CCompanys.GetEnumerator
	End Function
End Class