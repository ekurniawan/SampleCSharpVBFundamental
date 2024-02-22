Public Interface ICrud(Of T)
    Function Create(obj As T) As Integer
    Function GetAll() As List(Of T)
    Function GetById(id As Integer) As T
    Function Update(obj As T) As Integer
    Function Delete(id As Integer) As Integer
End Interface
