Imports Bunifu.DataViz

Public Class Dashboard

#Region "Methods"

    ' Method for spline charts generation.
    Sub GenerateLineCharts()

        ' Create a new canvas for rendering our chart.
        Dim line_chart_canvas As New Canvas

        ' Create the first spline chart datapoints-set.
        Dim line1_datapoints As New DataPoint(BunifuDataViz._type.Bunifu_line)

        ' Add all the datapoints for the first spline chart.
        line1_datapoints.addLabely("1 Jul", "2800")
        line1_datapoints.addLabely("3 Jul", "2600")
        line1_datapoints.addLabely("5 Jul", "2900")
        line1_datapoints.addLabely("7 Jul", "2400")
        line1_datapoints.addLabely("9 Jul", "2500")
        line1_datapoints.addLabely("11 Jul", "2450")
        line1_datapoints.addLabely("14 Jul", "2900")
        line1_datapoints.addLabely("16 Jul", "2700")
        line1_datapoints.addLabely("19 Jul", "1800")
        line1_datapoints.addLabely("22 Jul", "1600")
        line1_datapoints.addLabely("24 Jul", "3100")
        line1_datapoints.addLabely("26 Jul", "2500")
        line1_datapoints.addLabely("29 Jul", "2800")
        line1_datapoints.addLabely("31 Jul", "2600")

        ' Now add the datapoints-set to the canvas created.
        line_chart_canvas.addData(line1_datapoints)

        ' Create the second spline chart datapoints-set.
        Dim line2_datapoints As New DataPoint(BunifuDataViz._type.Bunifu_line)

        ' Add all the datapoints for the second spline chart.
        line2_datapoints.addLabely("1 Jul", "2000")
        line2_datapoints.addLabely("3 Jul", "2400")
        line2_datapoints.addLabely("7 Jul", "2500")
        line2_datapoints.addLabely("8 Jul", "1800")
        line2_datapoints.addLabely("11 Jul", "700")
        line2_datapoints.addLabely("15 Jul", "1900")
        line2_datapoints.addLabely("18 Jul", "1950")
        line2_datapoints.addLabely("19 Jul", "2100")
        line2_datapoints.addLabely("22 Jul", "2350")
        line2_datapoints.addLabely("24 Jul", "2200")
        line2_datapoints.addLabely("27 Jul", "2150")
        line2_datapoints.addLabely("29 Jul", "2200")
        line2_datapoints.addLabely("32 Jul", "3600")

        ' Add the datapoints-set to our canvas.
        line_chart_canvas.addData(line2_datapoints)

        ' Finally include the canvas created to a Dataviz component for rendering.
        BunifuDataViz1.Render(line_chart_canvas)

    End Sub

    ' This adds a new TaskItem inside our task-list panel section.
    Sub AddTask(ByVal task_label As TaskItem.TaskLabels, ByVal show_separator As Boolean, ByVal task_subject As String, ByVal task_title As String, ByVal task_subtitle As String)

        ' Create a new TaskItem and set the required parameters with the "Add" method.
        Dim task_item As New TaskItem
        task_item.Add(task_label, show_separator, task_subject, task_title, task_subtitle)

        ' Then set the TaskItem's Dock property to "Top".
        task_item.Dock = DockStyle.Top

        ' Set the width of the text controls to fit the panel and give space for the vertical scrollbar.
        If Panel1.VerticalScroll.Visible Then

            task_item.Width = task_item.Width - SystemInformation.VerticalScrollBarWidth

        End If

        ' Add the TaskItem to the Panel.
        Panel1.Controls.Add(task_item)

        ' Finally, bring the TaskItem to the front to avoid disarrangements.
        task_item.BringToFront()

    End Sub

    ' Add a list of pre-defined TaskItems.
    Sub AddTasks()

        AddTask(TaskItem.TaskLabels.General, True, "EMAIL", "Send over investment documents uru ruruc eueuen ueue heu eu3j e4", "Assigned to Mark R. - Added 12 Jun 2014 meeting to discuss new features fhfjfjfjjfnjfr5uttutunntu ututu")
        AddTask(TaskItem.TaskLabels.General, True, "DOCUMENT", "Prepare for a bi-weekly meeting to discuss new features fhfjfjfjjfnjfr5uttutunntu ututu", "Assigned to Amy G. - Added 12 Jun 2014")
        AddTask(TaskItem.TaskLabels.Important, True, "SCHEDULE - OVERDUE FOR 3 DAYS", "Schedule a call with Claudia for Thursday", "Assigned to Quinn T. - Added 12 Jun 2014")
        AddTask(TaskItem.TaskLabels.Finished, True, "EMAIL", "Send over investment documents", "Assigned to Mark R. - Added 12 Jun 2014")
        AddTask(TaskItem.TaskLabels.General, False, "BOOKING", "Register client for Monday meeting", "Assigned to James P. - Added 12 Jun 2014")

    End Sub

#End Region

#Region "Dashboard Events"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' Call the method "GenerateSplineCharts()".
        GenerateLineCharts()

        ' Then, once the chart has been rendered, stop the timer.
        Timer1.Stop()

        ' This will ensure that the chart has been generated only after the form has been loaded at runtime.
        ' Also, it assists in isolating the chart-rendering event and the form-loading process, since it 
        ' initializes chart-rendering after 100 Milliseconds... Also, ensure that your timer is enabled; 
        ' likewise, you can also set a number of milliseconds more if required.

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Use an animation library to animate the navigation panel.
        Dim ctrl_animator As New AnimatorNS.Animator

        ' Now animate the navigation panel while the form loads.
        ctrl_animator.Show(BunifuCards1, False, AnimatorNS.Animation.HorizSlide)

        ' Add the TaskItems inside the panel control.
        AddTasks()

        ' Let us now add the code for coloring the Charts.
        ' Add a colorset for beautifying our charts.
        BunifuDataViz1.colorSet.Add(Color.FromArgb(114, 203, 66))
        BunifuDataViz1.colorSet.Add(Color.FromArgb(110, 89, 237))

        ' This means that our three line charts will be applied with the above colors in respective order.
        ' And that's it...

    End Sub

#End Region

End Class
