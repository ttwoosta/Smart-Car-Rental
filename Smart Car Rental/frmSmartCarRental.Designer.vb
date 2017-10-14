<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmartCarRental
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.picSmartCarRental = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblRentalCost = New System.Windows.Forms.Label()
        Me.lblNumberOfDaysLabel = New System.Windows.Forms.Label()
        Me.lblNumberOfMilesLabel = New System.Windows.Forms.Label()
        Me.lblTotalCostLabel = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtNumberOfDays = New System.Windows.Forms.TextBox()
        Me.txtNumberOfMiles = New System.Windows.Forms.TextBox()
        Me.btnDisplayFare = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picSmartCarRental, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSmartCarRental
        '
        Me.picSmartCarRental.Image = Global.Smart_Car_Rental.My.Resources.Resources.Car_Rental
        Me.picSmartCarRental.Location = New System.Drawing.Point(0, -1)
        Me.picSmartCarRental.Name = "picSmartCarRental"
        Me.picSmartCarRental.Size = New System.Drawing.Size(268, 314)
        Me.picSmartCarRental.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmartCarRental.TabIndex = 0
        Me.picSmartCarRental.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(321, 26)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(242, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Smart Car Rental"
        '
        'lblRentalCost
        '
        Me.lblRentalCost.AutoSize = True
        Me.lblRentalCost.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalCost.Location = New System.Drawing.Point(321, 69)
        Me.lblRentalCost.Name = "lblRentalCost"
        Me.lblRentalCost.Size = New System.Drawing.Size(243, 16)
        Me.lblRentalCost.TabIndex = 2
        Me.lblRentalCost.Text = "Only $XX.XX per day plus $X.XX per mile."
        '
        'lblNumberOfDaysLabel
        '
        Me.lblNumberOfDaysLabel.AutoSize = True
        Me.lblNumberOfDaysLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfDaysLabel.Location = New System.Drawing.Point(336, 120)
        Me.lblNumberOfDaysLabel.Name = "lblNumberOfDaysLabel"
        Me.lblNumberOfDaysLabel.Size = New System.Drawing.Size(103, 16)
        Me.lblNumberOfDaysLabel.TabIndex = 3
        Me.lblNumberOfDaysLabel.Text = "Number of days:"
        '
        'lblNumberOfMilesLabel
        '
        Me.lblNumberOfMilesLabel.AutoSize = True
        Me.lblNumberOfMilesLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfMilesLabel.Location = New System.Drawing.Point(336, 158)
        Me.lblNumberOfMilesLabel.Name = "lblNumberOfMilesLabel"
        Me.lblNumberOfMilesLabel.Size = New System.Drawing.Size(106, 16)
        Me.lblNumberOfMilesLabel.TabIndex = 4
        Me.lblNumberOfMilesLabel.Text = "Number of miles:"
        '
        'lblTotalCostLabel
        '
        Me.lblTotalCostLabel.AutoSize = True
        Me.lblTotalCostLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostLabel.Location = New System.Drawing.Point(336, 196)
        Me.lblTotalCostLabel.Name = "lblTotalCostLabel"
        Me.lblTotalCostLabel.Size = New System.Drawing.Size(118, 16)
        Me.lblTotalCostLabel.TabIndex = 5
        Me.lblTotalCostLabel.Text = "Total cost of rental:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(470, 196)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(65, 16)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "$8,888.88"
        '
        'txtNumberOfDays
        '
        Me.txtNumberOfDays.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfDays.Location = New System.Drawing.Point(470, 117)
        Me.txtNumberOfDays.Name = "txtNumberOfDays"
        Me.txtNumberOfDays.Size = New System.Drawing.Size(39, 22)
        Me.txtNumberOfDays.TabIndex = 7
        Me.txtNumberOfDays.Text = "8888"
        '
        'txtNumberOfMiles
        '
        Me.txtNumberOfMiles.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfMiles.Location = New System.Drawing.Point(470, 155)
        Me.txtNumberOfMiles.Name = "txtNumberOfMiles"
        Me.txtNumberOfMiles.Size = New System.Drawing.Size(39, 22)
        Me.txtNumberOfMiles.TabIndex = 8
        Me.txtNumberOfMiles.Text = "8888"
        '
        'btnDisplayFare
        '
        Me.btnDisplayFare.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayFare.Location = New System.Drawing.Point(303, 266)
        Me.btnDisplayFare.Name = "btnDisplayFare"
        Me.btnDisplayFare.Size = New System.Drawing.Size(89, 23)
        Me.btnDisplayFare.TabIndex = 9
        Me.btnDisplayFare.Text = "Display Fair"
        Me.btnDisplayFare.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(398, 266)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(493, 266)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSmartCarRental
        '
        Me.AcceptButton = Me.btnDisplayFare
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(602, 310)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayFare)
        Me.Controls.Add(Me.txtNumberOfMiles)
        Me.Controls.Add(Me.txtNumberOfDays)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalCostLabel)
        Me.Controls.Add(Me.lblNumberOfMilesLabel)
        Me.Controls.Add(Me.lblNumberOfDaysLabel)
        Me.Controls.Add(Me.lblRentalCost)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picSmartCarRental)
        Me.Name = "frmSmartCarRental"
        Me.Text = "Smart Car Rental"
        CType(Me.picSmartCarRental, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSmartCarRental As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRentalCost As Label
    Friend WithEvents lblNumberOfDaysLabel As Label
    Friend WithEvents lblNumberOfMilesLabel As Label
    Friend WithEvents lblTotalCostLabel As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtNumberOfDays As TextBox
    Friend WithEvents txtNumberOfMiles As TextBox
    Friend WithEvents btnDisplayFare As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
