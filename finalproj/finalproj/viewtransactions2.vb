Imports System.Data.SqlClient


Public Class viewtransactions
    Private Sub viewtransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        show_Records()
        DateTimePickerreceived.Value = DateTime.Now
    End Sub
    Public Sub show_Records()
        If formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(8).Value = "Walk-In" Then
            ComboBoxtransacttype.SelectedItem = "Walk-in"
            Label7.Visible = False
            TextBoxreceivedby.Visible = False
            Label8.Visible = False
            DateTimePickerreceived.Visible = False
        ElseIf formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(8).Value = "Delivery" Then
            ComboBoxtransacttype.SelectedItem = "Delivery"
            Label7.Visible = True
            TextBoxreceivedby.Visible = True
            Label8.Visible = True
            DateTimePickerreceived.Visible = True
            Labelinvoice.Text = "Delivery No: "
        ElseIf formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(8).Value = "Picked-up" Then
            ComboBoxtransacttype.SelectedItem = "Pick up"
            Label7.Visible = True
            TextBoxreceivedby.Visible = True
            Label8.Visible = True
            DateTimePickerreceived.Visible = True
        End If

        If formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(9).Value = "Completed" Then
            Buttonedit.Visible = False

            If formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(8).Value = "Delivery" Or formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(8).Value = "Picked-up" Then
                TextBoxreceivedby.Text = formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(10).Value
                DateTimePickerreceived.Value = formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(11).Value
            End If
        Else
            Buttonedit.Visible = True
            Buttonedit.Enabled = True

        End If
        TextBoxinvoice.Text = formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(12).Value
        TextBoxtransactempname.Text = formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(7).Value
        TextBoxcustname.Text = formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(3).Value
        TextBoxcontactno.Text = formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(5).Value
        TextBoxcustadrs.Text = formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(4).Value
        LabelTotalamount.Text = formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(6).Value


        Call connection()
        Dim params(0) As SqlParameter
        params(0) = New SqlParameter("@transactionidd", SqlDbType.VarChar)
        params(0).Value = formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(1).Value

        cm = New SqlCommand
        cm.Connection = cn
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = "sproc_completedorders"

        cm.Parameters.AddRange(params)

        cm.ExecuteNonQuery()
        ada = New SqlDataAdapter(cm)
        Dim table As New DataTable()

        ada.Fill(table)

        DataGridViewcompletedorders.DataSource = table
        cn.Close()

    End Sub

    Private Sub Buttonedit_Click(sender As Object, e As EventArgs) Handles Buttonedit.Click
        TextBoxreceivedby.Enabled = True
        DateTimePickerreceived.Enabled = True
        Buttoncompleted.Enabled = True
    End Sub

    Private Sub Buttoncompleted_Click(sender As Object, e As EventArgs) Handles Buttoncompleted.Click

        If TextBoxreceivedby.Text = String.Empty Then
            MessageBox.Show("One or more fields have not been completed")
        ElseIf DateTimePickerreceived.Value < DateTimePicker1.Value Then
            MessageBox.Show("Check your Date received")
        Else
            If ComboBoxtransacttype.SelectedItem = "Delivery" Then
                insertintotype("sproc_insertdelivery")
            Else
                insertintotype("sproc_insertpickup")
            End If
        End If



    End Sub

    Public Sub insertintotype(prod As String)
        Call connection()
        Dim params(2) As SqlParameter
        params(0) = New SqlParameter("@transactionid", SqlDbType.VarChar)
        params(1) = New SqlParameter("@receivedby", SqlDbType.VarChar)
        params(2) = New SqlParameter("@receiveddate", SqlDbType.DateTime)

        params(0).Value = formcashier.DataGridViewcompletedtransactions.SelectedRows(0).Cells(1).Value
        params(1).Value = TextBoxreceivedby.Text
        params(2).Value = DateTimePickerreceived.Text

        cm = New SqlCommand
        cm.Connection = cn
        cm.CommandType = CommandType.StoredProcedure
        cm.CommandText = prod

        cm.Parameters.AddRange(params)

        If cm.ExecuteNonQuery() = 3 Then
            MessageBox.Show("Transaction Completed")
            formcashier.viewcompletedtransaction("", "sproc_viewfordelivery")
            formcashier.viewcompletedtransaction("", "sproc_viewforpickup")
            Me.Close()
        Else
            MessageBox.Show("Error Saving Records")
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        DateTimePickerreceived.Value = DateTime.Now
    End Sub

End Class