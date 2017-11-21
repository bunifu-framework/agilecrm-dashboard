' Custom TaskItem Class.
Public Class TaskItem

    ' This adds a new TaskItem control.
    Public Sub Add(ByVal task_label As TaskLabels, ByVal show_separator As Boolean, ByVal task_subject As String, ByVal task_title As String, ByVal task_subtitle As String)

        ' Set the texts for the three Task values.
        subject.Text = task_subject
        title.Text = task_title
        subtitle.Text = task_subtitle

        ' If the TaskLabel option is set as "Important", then set the appropriate visual cues.
        ' Likewise, if the TaskLabel option is set as "Finished", then set the appropriate visual cue.

        If task_label = TaskLabels.Important Then

            indicator.Visible = True

            subject.ForeColor = Color.FromArgb(243, 49, 85)
            indicator.LineColor = Color.FromArgb(243, 49, 85)

        ElseIf task_label = TaskLabels.Finished Then

            title.Font = New Font(subject.Font.FontFamily, 9.75, FontStyle.Strikeout)

        End If

        ' If the user has disabled viewing an item's separator, which is hereby optional, then hide it.
        If show_separator = False Then

            separator.Visible = False

        End If

    End Sub

    ' This provides a list of TaskLabel options.
    Enum TaskLabels

        General = 0
        Intermediate = 1
        Important = 2
        Finished = 3

    End Enum

    Private Sub TaskItem_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus

        If Me.BackColor = Color.White Then

            Me.BackColor = Color.FromArgb(223, 218, 251)

            edit.Show()
            delete.Show()

        Else

            Me.BackColor = Color.White

            edit.Hide()
            delete.Hide()

        End If

    End Sub

    Private Sub TaskItem_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick, task_checkbox.MouseClick, task_image.MouseClick, subject.MouseClick, title.MouseClick, subtitle.MouseClick, edit.MouseClick, delete.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Left Then

            If Me.BackColor = Color.White Then

                Me.BackColor = Color.FromArgb(223, 218, 251)

                edit.Show()
                delete.Show()

            Else

                Me.BackColor = Color.White

                edit.Hide()
                delete.Hide()

            End If

        End If

    End Sub

    ' ' On TaskItem MouseHover, some visual effects will be previewed.
    ' Private Sub TaskItem_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover ' , task_checkbox.MouseHover, task_image.MouseHover, subject.MouseHover, title.MouseHover, subtitle.MouseHover, edit.MouseHover, delete.MouseHover
    ' 
    '     Me.BackColor = Color.FromArgb(223, 218, 251)
    ' 
    '     edit.Show()
    '     delete.Show()
    ' 
    ' End Sub

    ' On TaskItem MouseLeave, some visual effects will be previewed.
    ' Private Sub TaskItem_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave ' , task_checkbox.MouseLeave, task_image.MouseLeave, subject.MouseLeave, title.MouseLeave, subtitle.MouseLeave, edit.MouseHover, delete.MouseLeave
    ' 
    '     Me.BackColor = Color.White
    ' 
    '     edit.Hide()
    '     delete.Hide()
    ' 
    ' End Sub

End Class
