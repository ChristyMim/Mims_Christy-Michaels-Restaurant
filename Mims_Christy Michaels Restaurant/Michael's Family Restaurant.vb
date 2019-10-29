Public Class frmMichaelsRestaurant
    'Project: Michael's Family Restaurant
    'Programmer Name: Christy Mims
    'Date: 02/01/17
    'Description:  This program allows the user to choose food choices and add their prices together to calculate
    'a subtotal, along with the sales tax and the final total.  There is also buttons included to clear out the
    'information and exit the program.
    Dim Subtotal As Decimal = 0
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'This button allows the user to close the program.
    End Sub

    Private Sub btnCombo1_Click(sender As Object, e As EventArgs) Handles btnCombo1.Click
        Dim Combo1 As String
        Dim price As Decimal
        Combo1 = "Combo #1"
        price = 5.79
        lstResults.Items.Add("Combo #1 ....." & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the food.
    End Sub

    Private Sub btnCombo2_Click(sender As Object, e As EventArgs) Handles btnCombo2.Click
        Dim Combo2 As String
        Dim price As Decimal
        Combo2 = "Combo #2"
        price = 6.45
        lstResults.Items.Add("Combo #2 ......" & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the food.
    End Sub

    Private Sub btnCombo3_Click(sender As Object, e As EventArgs) Handles btnCombo3.Click
        Dim Combo3 As String
        Dim price As Decimal
        Combo3 = "Combo #3"
        price = 6.85
        lstResults.Items.Add("Combo #3 ......." & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the food.
    End Sub

    Private Sub btnCombo4_Click(sender As Object, e As EventArgs) Handles btnCombo4.Click
        Dim Combo4 As String
        Dim price As Decimal
        Combo4 = "Combo #4"
        price = 7.55
        lstResults.Items.Add("Combo #3 ......" & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the food.
    End Sub

    Private Sub btnHamburger_Click(sender As Object, e As EventArgs) Handles btnHamburger.Click
        Dim Hamburger As String
        Dim price As Decimal
        Hamburger = "Hamburger"
        price = 1.85
        lstResults.Items.Add("Hamburger ......" & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the food.
    End Sub

    Private Sub btnCheeseburger_Click(sender As Object, e As EventArgs) Handles btnCheeseburger.Click
        Dim Cheeseburger As String
        Dim price As Decimal
        Cheeseburger = "Cheeseburger"
        price = 2.05
        lstResults.Items.Add("Cheeseburger ........" & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the food.
    End Sub

    Private Sub btnDoubleCheeseburger_Click(sender As Object, e As EventArgs) Handles btnDoubleCheeseburger.Click
        Dim DoubleCheeseburger As String
        Dim price As Decimal
        DoubleCheeseburger = "Double Cheeseburger"
        price = 3.45
        lstResults.Items.Add("Double Cheeseburger ......." & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the food.
    End Sub

    Private Sub btnHalfPound_Click(sender As Object, e As EventArgs) Handles btnHalfPound.Click
        Dim Halfpound As String
        Dim price As Decimal
        Halfpound = "Half Pound Cheeseburger"
        price = 4.25
        lstResults.Items.Add("Half Pound Cheeseburger......" & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the food.
    End Sub

    Private Sub btnTacoSalad_Click(sender As Object, e As EventArgs) Handles btnTacoSalad.Click
        Dim TacoSalad As String
        Dim price As Decimal
        TacoSalad = "Taco Salad"
        price = 4.35
        lstResults.Items.Add("Taco Salad ......" & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the food.
    End Sub

    Private Sub btnChefSalad_Click(sender As Object, e As EventArgs) Handles btnChefSalad.Click
        Dim ChefSalad As String
        Dim price As Decimal
        ChefSalad = "Chef Salad"
        price = 6.85
        lstResults.Items.Add("Chef Salad ......" & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the food.
    End Sub

    Private Sub btnHouseSalad_Click(sender As Object, e As EventArgs) Handles btnHouseSalad.Click
        Dim HouseSalad As String
        Dim price As Decimal
        HouseSalad = "House Salad"
        price = 5.25
        lstResults.Items.Add("House Salad ......" & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the food.
    End Sub

    Private Sub btnSmallFries_Click(sender As Object, e As EventArgs) Handles btnSmallFries.Click
        Dim SmallFries As String
        Dim price As Decimal
        SmallFries = "Small Fries"
        price = 1.55
        lstResults.Items.Add("Small Fries ......." & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the food.
    End Sub

    Private Sub btnLargeFries_Click(sender As Object, e As EventArgs) Handles btnLargeFries.Click
        Dim LargeFries As String
        Dim price As Decimal
        LargeFries = "Large Fries"
        price = 2.65
        lstResults.Items.Add("Large Fries ......." & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the food.
    End Sub

    Private Sub btnOnionRings_Click(sender As Object, e As EventArgs) Handles btnOnionRings.Click
        Dim OnionRings As String
        Dim price As Decimal
        OnionRings = "Onion Rings"
        price = 3.15
        lstResults.Items.Add("Onion Rings ......" & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the food.
    End Sub

    Private Sub btnSmallSoftDrink_Click(sender As Object, e As EventArgs) Handles btnSmallSoftDrink.Click
        Dim SmallSoftDrink As String
        Dim price As Decimal
        SmallSoftDrink = "Small Soft Drink"
        price = 1.75
        lstResults.Items.Add("Small Soft Drink ......." & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the drink.
    End Sub

    Private Sub btnMediumSoftDrink_Click(sender As Object, e As EventArgs) Handles btnMediumSoftDrink.Click
        Dim MediumSoftDrink As String
        Dim price As Decimal
        MediumSoftDrink = "Medium Soft Drink"
        price = 1.95
        lstResults.Items.Add("Medium Soft Drink ....." & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the drink.
    End Sub

    Private Sub btnLargeSoftDrink_Click(sender As Object, e As EventArgs) Handles btnLargeSoftDrink.Click
        Dim LargeSoftDrink As String
        Dim price As Decimal
        LargeSoftDrink = "Large Soft Drink"
        price = 2.15
        lstResults.Items.Add("Large Soft Drink ......" & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the drink.
    End Sub

    Private Sub btnSweetTea_Click(sender As Object, e As EventArgs) Handles btnSweetTea.Click
        Dim SweetTea As String
        Dim price As Decimal
        SweetTea = "Sweet Tea"
        price = 1.75
        lstResults.Items.Add("Sweet Tea ........" & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the drink.
    End Sub

    Private Sub btnUnsweetTea_Click(sender As Object, e As EventArgs) Handles btnUnsweetTea.Click
        Dim UnsweetTea As String
        Dim price As Decimal
        UnsweetTea = "Unsweet Tea"
        price = 1.75
        lstResults.Items.Add("Unsweet Tea ........." & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the drink.
    End Sub

    Private Sub btnWater_Click(sender As Object, e As EventArgs) Handles btnWater.Click
        Dim Water As String
        Dim price As Decimal
        Water = "Water"
        price = 0.25
        lstResults.Items.Add("Water ......." & price)
        Subtotal = Subtotal + price
        'This button allows the user to display the product and the price of the drink.
    End Sub

    Private Sub btnGetTotal_Click(sender As Object, e As EventArgs) Handles btnGetTotal.Click
        Dim SalesTax, Total As Decimal
        SalesTax = 0.07D
        lstResults.Items.Add("")
        lstResults.Items.Add("")
        lstResults.Items.Add("")
        lstResults.Items.Add("     ---------------------------------------    ")
        lstResults.Items.Add("")
        lstResults.Items.Add("Subtotal ......." & Subtotal)
        SalesTax = SalesTax * Subtotal
        lstResults.Items.Add("SalesTax........" & Math.Round(SalesTax, 2))
        Total = Subtotal + SalesTax
        lstResults.Items.Add("Total ........" & Math.Round(Total, 2))
        'This button allows the user to calculate the subtotal, the sales tax, and the final total for each order.
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        lstResults.Items.Clear()
        Subtotal = 0
        'This button allows the user to clear the information and to start a new order.
    End Sub
End Class
