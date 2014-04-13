'Purpose: Unit One Test
'Date:

Option Strict On
Option Explicit On

Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        lblLogin.Text = "Logged Out"
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As System.EventArgs) Handles btnLogin.Click
        lblLogin.Text = "Logged In"
    End Sub

End Class
