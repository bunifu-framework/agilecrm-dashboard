<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaskItem))
        Me.separator = New Bunifu.Framework.UI.BunifuSeparator()
        Me.delete = New Bunifu.Framework.UI.BunifuImageButton()
        Me.edit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.subtitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.title = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.subject = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.task_image = New System.Windows.Forms.PictureBox()
        Me.task_checkbox = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.indicator = New Bunifu.Framework.UI.BunifuSeparator()
        CType(Me.delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.task_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'separator
        '
        Me.separator.BackColor = System.Drawing.Color.Transparent
        Me.separator.LineColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.separator.LineThickness = 1
        Me.separator.Location = New System.Drawing.Point(0, 70)
        Me.separator.Name = "separator"
        Me.separator.Size = New System.Drawing.Size(443, 10)
        Me.separator.TabIndex = 45
        Me.separator.Transparency = 255
        Me.separator.Vertical = False
        '
        'delete
        '
        Me.delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete.Image = CType(resources.GetObject("delete.Image"), System.Drawing.Image)
        Me.delete.ImageActive = Nothing
        Me.delete.Location = New System.Drawing.Point(397, 25)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(25, 23)
        Me.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.delete.TabIndex = 44
        Me.delete.TabStop = False
        Me.delete.Visible = False
        Me.delete.Zoom = 10
        '
        'edit
        '
        Me.edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.edit.Image = CType(resources.GetObject("edit.Image"), System.Drawing.Image)
        Me.edit.ImageActive = Nothing
        Me.edit.Location = New System.Drawing.Point(366, 25)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(25, 21)
        Me.edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.edit.TabIndex = 43
        Me.edit.TabStop = False
        Me.edit.Visible = False
        Me.edit.Zoom = 10
        '
        'subtitle
        '
        Me.subtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.subtitle.AutoEllipsis = True
        Me.subtitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.subtitle.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.subtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.subtitle.Location = New System.Drawing.Point(68, 48)
        Me.subtitle.Name = "subtitle"
        Me.subtitle.Size = New System.Drawing.Size(354, 15)
        Me.subtitle.TabIndex = 42
        Me.subtitle.Text = "TASK SUBTITLE"
        '
        'title
        '
        Me.title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.title.AutoEllipsis = True
        Me.title.Cursor = System.Windows.Forms.Cursors.Hand
        Me.title.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.title.ForeColor = System.Drawing.Color.Black
        Me.title.Location = New System.Drawing.Point(68, 28)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(372, 15)
        Me.title.TabIndex = 41
        Me.title.Text = "TASK TITLE"
        '
        'subject
        '
        Me.subject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.subject.AutoEllipsis = True
        Me.subject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.subject.Font = New System.Drawing.Font("Roboto", 8.25!)
        Me.subject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.subject.Location = New System.Drawing.Point(69, 10)
        Me.subject.Name = "subject"
        Me.subject.Size = New System.Drawing.Size(371, 13)
        Me.subject.TabIndex = 40
        Me.subject.Text = "TASK LABEL"
        '
        'task_image
        '
        Me.task_image.Image = CType(resources.GetObject("task_image.Image"), System.Drawing.Image)
        Me.task_image.Location = New System.Drawing.Point(41, 26)
        Me.task_image.Name = "task_image"
        Me.task_image.Size = New System.Drawing.Size(21, 20)
        Me.task_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.task_image.TabIndex = 39
        Me.task_image.TabStop = False
        '
        'task_checkbox
        '
        Me.task_checkbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.task_checkbox.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.task_checkbox.Checked = False
        Me.task_checkbox.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.task_checkbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.task_checkbox.ForeColor = System.Drawing.Color.White
        Me.task_checkbox.Location = New System.Drawing.Point(15, 27)
        Me.task_checkbox.Name = "task_checkbox"
        Me.task_checkbox.Size = New System.Drawing.Size(20, 20)
        Me.task_checkbox.TabIndex = 38
        '
        'indicator
        '
        Me.indicator.BackColor = System.Drawing.Color.Transparent
        Me.indicator.LineColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.indicator.LineThickness = 3
        Me.indicator.Location = New System.Drawing.Point(-4, 0)
        Me.indicator.Name = "indicator"
        Me.indicator.Size = New System.Drawing.Size(10, 76)
        Me.indicator.TabIndex = 46
        Me.indicator.Transparency = 255
        Me.indicator.Vertical = True
        Me.indicator.Visible = False
        '
        'TaskItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.subtitle)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.subject)
        Me.Controls.Add(Me.task_image)
        Me.Controls.Add(Me.task_checkbox)
        Me.Controls.Add(Me.indicator)
        Me.Controls.Add(Me.separator)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.Name = "TaskItem"
        Me.Size = New System.Drawing.Size(443, 76)
        CType(Me.delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.task_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents separator As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents delete As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents edit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents subtitle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents title As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents subject As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents task_image As System.Windows.Forms.PictureBox
    Friend WithEvents task_checkbox As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents indicator As Bunifu.Framework.UI.BunifuSeparator

End Class
