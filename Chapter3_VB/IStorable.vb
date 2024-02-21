Public Interface IStorable
    Sub Read()
    Sub Write()
    Property Status As Integer
End Interface

Public Interface ISaveable
    Inherits IStorable

    Sub Save()
    Sub Load()
End Interface

Public Interface ICompressible
    Sub Compress()
    Sub Decompress()
End Interface

Public Class Document
    Implements ISaveable

    Public Property Status As Integer Implements IStorable.Status
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub Save() Implements ISaveable.Save
        Throw New NotImplementedException()
    End Sub

    Public Sub Load() Implements ISaveable.Load
        Throw New NotImplementedException()
    End Sub

    Public Sub Read() Implements IStorable.Read
        Throw New NotImplementedException()
    End Sub

    Public Sub Write() Implements IStorable.Write
        Throw New NotImplementedException()
    End Sub
End Class
