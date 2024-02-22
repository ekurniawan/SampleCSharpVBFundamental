Imports BO

Public Interface ICustomer
    Inherits ICrud(Of Customer)

    Function GetByName() As List(Of Customer)
End Interface
