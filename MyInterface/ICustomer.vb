Imports BO

Public Interface ICustomer
    Inherits ICrud(Of Customer)

    Function GetByName() As List(Of Customer)
    Function GetOrder() As List(Of ViewOrder)
End Interface
