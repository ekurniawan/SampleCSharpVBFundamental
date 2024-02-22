Public Interface ICrud(Of T)
    Function Create(ByVal obj As T) As Integer
    Function GetAll() As List(Of T)
    Function GetById(ByVal id As Integer) As T
    Function Update(ByVal obj As T) As Integer
    Function Delete(ByVal id As Integer) As Integer
End Interface
