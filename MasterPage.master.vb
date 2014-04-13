'Purpose: Unit One Test
'Date: 

Option Strict On
Option Explicit On


Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub btnSignUp_Click(sender As Object, e As System.EventArgs) Handles btnSignUp.Click
        Server.Transfer("~/Membership/MembershipSignup.aspx")

    End Sub

    Protected Sub btnClub_Click(sender As Object, e As System.EventArgs) Handles btnClub.Click
        Response.Redirect("http://cvnug.wi-ineta.org/")
    End Sub
End Class

