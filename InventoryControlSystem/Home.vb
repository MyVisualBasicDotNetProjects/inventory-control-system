Public Class Home

    Public Sub Home_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If InventoryControlSystem.UserLogin.SalesPerson = True Then
            btnPurchase.Enabled = False
            btnPurchase2.Enabled = False
            btnUsers.Enabled = False
            btnUsers2.Enabled = False

        ElseIf InventoryControlSystem.UserLogin.Purchaser = True Then
            btnSales.Enabled = False
            btnSales2.Enabled = False
            btnUsers.Enabled = False
            btnUsers2.Enabled = False

            'btnSales.Hide()
            'btnSales2.Hide()
            'btnUsers.Hide()
            'btnUsers2.Hide()

        Else
            btnSales.Enabled = True
            btnSales2.Enabled = True
            btnUsers.Enabled = True
            btnUsers2.Enabled = True
            btnPurchase.Enabled = True
            btnPurchase2.Enabled = True
        End If
        'closeLoginForm()

    End Sub

    Private Sub btnSales2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSales2.Click
        SalesTable.Show()
        Me.Hide()
    End Sub

    Private Sub btnProducts2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducts2.Click
        Products.Show()
        Me.Hide()
    End Sub
    
    Private Sub btnPurchase2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchase2.Click
        PurchaseEntry.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsers2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsers2.Click
        CreateUserAccount.Show()
        Me.Hide()
    End Sub

    Private Sub btnReports2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports2.Click
        Reports.Show()
        Me.Hide()
    End Sub

    Private Sub btnChangePassword2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePassword2.Click
        ChangeUserPassword.Show()
        Me.Hide()
    End Sub

    Public Sub closeLoginForm()
        InventoryControlSystem.UserLogin.Dispose()
    End Sub

    Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.Click
        Me.Dispose()
    End Sub


    'DECORATION
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub btnBackUp2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBackUp2.MouseEnter
        btnBackUp2.Image = InventoryControlSystem.My.Resources.btnBackUp2
    End Sub

    Private Sub btnBackUp2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBackUp2.MouseLeave
        btnBackUp2.Image = InventoryControlSystem.My.Resources.btnBackUp
    End Sub

    Private Sub btnChangePassword2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChangePassword2.MouseEnter
        btnChangePassword2.Image = InventoryControlSystem.My.Resources.btnPassword2
    End Sub

    Private Sub btnChangePassword2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChangePassword2.MouseLeave
        btnChangePassword2.Image = InventoryControlSystem.My.Resources.btnPassword
    End Sub

    Private Sub btnProducts2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducts2.MouseEnter
        btnProducts2.Image = InventoryControlSystem.My.Resources.btnProducts2
    End Sub

    Private Sub btnProducts2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducts2.MouseLeave
        btnProducts2.Image = InventoryControlSystem.My.Resources.btnProducts
    End Sub

    Private Sub btnSales2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSales2.MouseEnter
        btnSales2.Image = InventoryControlSystem.My.Resources.btnSales2
    End Sub

    Private Sub btnSales2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSales2.MouseLeave
        btnSales2.Image = InventoryControlSystem.My.Resources.btnSales
    End Sub

    Private Sub btnReports2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports2.MouseEnter
        btnReports2.Image = InventoryControlSystem.My.Resources.btnReports2
    End Sub

    Private Sub btnReports2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports2.MouseLeave
        btnReports2.Image = InventoryControlSystem.My.Resources.btnReports
    End Sub

    Private Sub btnUsers2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsers2.MouseEnter
        btnUsers2.Image = InventoryControlSystem.My.Resources.btnUsers2
    End Sub

    Private Sub btnUsers2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsers2.MouseLeave
        btnUsers2.Image = InventoryControlSystem.My.Resources.btnUsers
    End Sub

    Private Sub btnPurchase2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchase2.MouseEnter
        btnPurchase2.Image = InventoryControlSystem.My.Resources.btnPurchase2
    End Sub

    Private Sub btnPurchase2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchase2.MouseLeave
        btnPurchase2.Image = InventoryControlSystem.My.Resources.btnPurchase
    End Sub

    Private Sub picMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOff.Click
        UserLogin.Show()
        UserLogin.txtPassword.Text = ""
        Me.Close()
    End  ~dulla^@204~ 