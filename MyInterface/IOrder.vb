Imports BO

Public Interface IOrder
    Inherits ICrud(Of Order)

    Function GetOrders() As List(Of ViewOrder)

End Interface
