Public Class Form1
    Const firstZone As Decimal = 4.9
    Const secondZone As Decimal = 5.9
    Const thirdZone As Decimal = 6.0
    Dim numOftickets As Integer
    Dim cost As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub Clear()
        lblprice.Text = ""
        TextBox1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = True
        RadioButton6.Checked = False
        TextBox1.Focus()
    End Sub

    Private Sub validationCheck()

        If IsNumeric(TextBox1.Text) Then
            Try
                numOftickets = Convert.ToInt32(TextBox1.Text)
            Catch Wronginput As Exception
                MsgBox("Bad Number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ATTENTION")
                Clear()
                Exit Sub
            End Try

            If TextBox1.Text <= 0 Or TextBox1.Text > 99 Then
                MsgBox("FormatNumber Of Tickets Must Be Over Zero And Less than 100", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ATTENTION")

            End If
            If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
                MsgBox("Check Zones Please", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ATTENTION")
                Clear()
            End If

        ElseIf TextBox1.Text = "" Then
            MsgBox("Enter Number Of Tickets Please", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ATTENTION")
            Clear()
        Else
            MsgBox("Number Of Tickets Must be Numeric", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "ATTENTION")
            Clear()
            Exit Sub
        End If
    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        validationCheck()
        If numOftickets > 0 And numOftickets < 100 Then
            If RadioButton1.Checked And RadioButton4.Checked Then
                cost = numOftickets * firstZone
                lblprice.Text = " The Cost of Zone 1-3 : " & cost.ToString("C")
            End If
            If RadioButton1.Checked And RadioButton5.Checked Then
                cost = numOftickets * firstZone
                lblprice.Text = " The Cost of Zone 1-3 : " & cost.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-GB"))
            End If
            If RadioButton1.Checked And RadioButton6.Checked Then
                cost = numOftickets * firstZone
                lblprice.Text = " The Cost of Zone 1-3 : " & cost.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("de-DE"))
            End If
            If RadioButton2.Checked And RadioButton4.Checked Then
                cost = numOftickets * secondZone
                lblprice.Text = " The Cost of Zone 1-5 : " & cost.ToString("C")
            End If
            If RadioButton2.Checked And RadioButton5.Checked Then
                cost = numOftickets * secondZone
                lblprice.Text = " The Cost of Zone 1-5 : " & cost.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-GB"))
            End If
            If RadioButton2.Checked And RadioButton6.Checked Then
                cost = numOftickets * secondZone
                lblprice.Text = " The Cost of Zone 1-5 : " & cost.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("de-DE"))
            End If
            If RadioButton3.Checked And RadioButton4.Checked Then
                cost = numOftickets * thirdZone
                lblprice.Text = " The Cost of Zone 1-6 : " & cost.ToString("C")
            End If
            If RadioButton3.Checked And RadioButton5.Checked Then
                cost = numOftickets * thirdZone
                lblprice.Text = " The Cost of Zone 1-6 : " & cost.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-GB"))
            End If
            If RadioButton3.Checked And RadioButton6.Checked Then
                cost = numOftickets * thirdZone
                lblprice.Text = " The Cost of Zone 1-6 : " & cost.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("de-DE"))
            End If
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Clear()
    End Sub
End Class
