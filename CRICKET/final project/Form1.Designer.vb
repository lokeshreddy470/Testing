<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pricelabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Totallabel = New System.Windows.Forms.Label()
        Me.lbItems = New System.Windows.Forms.ListBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Cartbutton = New System.Windows.Forms.Button()
        Me.CheckOutButton = New System.Windows.Forms.Button()
        Me.lbCart = New System.Windows.Forms.ListBox()
        Me.txtSearchItem = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.pnlCricket = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCricket.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.final_project.My.Resources.Resources.vbpic
        Me.PictureBox1.Location = New System.Drawing.Point(497, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(469, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AllStar Cricket Company"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Items On Sale"
        '
        'pricelabel
        '
        Me.pricelabel.AutoSize = True
        Me.pricelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricelabel.Location = New System.Drawing.Point(187, 95)
        Me.pricelabel.Name = "pricelabel"
        Me.pricelabel.Size = New System.Drawing.Size(48, 16)
        Me.pricelabel.TabIndex = 4
        Me.pricelabel.Text = "Price:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(534, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cart"
        '
        'Totallabel
        '
        Me.Totallabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Totallabel.Location = New System.Drawing.Point(186, 134)
        Me.Totallabel.Name = "Totallabel"
        Me.Totallabel.Size = New System.Drawing.Size(100, 23)
        Me.Totallabel.TabIndex = 6
        Me.Totallabel.Text = "Total:"
        '
        'lbItems
        '
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.Items.AddRange(New Object() {"Bat", "Ball", "Shoes", "Gloves", "Wickets", "Pads", "Helmet", "Jersy"})
        Me.lbItems.Location = New System.Drawing.Point(18, 81)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbItems.Size = New System.Drawing.Size(142, 186)
        Me.lbItems.TabIndex = 7
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(392, 18)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 8
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'Cartbutton
        '
        Me.Cartbutton.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cartbutton.Location = New System.Drawing.Point(249, 178)
        Me.Cartbutton.Name = "Cartbutton"
        Me.Cartbutton.Size = New System.Drawing.Size(119, 39)
        Me.Cartbutton.TabIndex = 9
        Me.Cartbutton.Text = "Add To Cart"
        Me.Cartbutton.UseVisualStyleBackColor = True
        '
        'CheckOutButton
        '
        Me.CheckOutButton.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOutButton.Location = New System.Drawing.Point(255, 231)
        Me.CheckOutButton.Name = "CheckOutButton"
        Me.CheckOutButton.Size = New System.Drawing.Size(108, 37)
        Me.CheckOutButton.TabIndex = 10
        Me.CheckOutButton.Text = "Checkout"
        Me.CheckOutButton.UseVisualStyleBackColor = True
        '
        'lbCart
        '
        Me.lbCart.FormattingEnabled = True
        Me.lbCart.Location = New System.Drawing.Point(485, 70)
        Me.lbCart.Name = "lbCart"
        Me.lbCart.Size = New System.Drawing.Size(150, 199)
        Me.lbCart.TabIndex = 11
        '
        'txtSearchItem
        '
        Me.txtSearchItem.Location = New System.Drawing.Point(166, 20)
        Me.txtSearchItem.Name = "txtSearchItem"
        Me.txtSearchItem.Size = New System.Drawing.Size(214, 20)
        Me.txtSearchItem.TabIndex = 12
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtPrice.Location = New System.Drawing.Point(249, 94)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(162, 23)
        Me.txtPrice.TabIndex = 13
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTotal.Location = New System.Drawing.Point(249, 131)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(162, 23)
        Me.lblTotal.TabIndex = 14
        '
        'pnlCricket
        '
        Me.pnlCricket.Controls.Add(Me.CheckOutButton)
        Me.pnlCricket.Controls.Add(Me.lbCart)
        Me.pnlCricket.Controls.Add(Me.Label5)
        Me.pnlCricket.Controls.Add(Me.lbItems)
        Me.pnlCricket.Controls.Add(Me.Label2)
        Me.pnlCricket.Controls.Add(Me.lblTotal)
        Me.pnlCricket.Controls.Add(Me.txtPrice)
        Me.pnlCricket.Controls.Add(Me.txtSearchItem)
        Me.pnlCricket.Controls.Add(Me.pricelabel)
        Me.pnlCricket.Controls.Add(Me.Totallabel)
        Me.pnlCricket.Controls.Add(Me.SearchButton)
        Me.pnlCricket.Controls.Add(Me.Cartbutton)
        Me.pnlCricket.Location = New System.Drawing.Point(-3, 157)
        Me.pnlCricket.Name = "pnlCricket"
        Me.pnlCricket.Size = New System.Drawing.Size(676, 349)
        Me.pnlCricket.TabIndex = 15
        Me.pnlCricket.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(685, 45)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterPasswordToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(96, 41)
        Me.ToolStripMenuItem1.Text = "Login"
        '
        'EnterPasswordToolStripMenuItem
        '
        Me.EnterPasswordToolStripMenuItem.Name = "EnterPasswordToolStripMenuItem"
        Me.EnterPasswordToolStripMenuItem.Size = New System.Drawing.Size(273, 42)
        Me.EnterPasswordToolStripMenuItem.Text = "Enter Password"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(273, 42)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 535)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlCricket)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "AllStar Cricket Company"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCricket.ResumeLayout(False)
        Me.pnlCricket.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pricelabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Totallabel As Label
    Friend WithEvents lbItems As ListBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents Cartbutton As Button
    Friend WithEvents CheckOutButton As Button
    Friend WithEvents lbCart As ListBox
    Friend WithEvents txtSearchItem As TextBox
    Friend WithEvents txtPrice As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents pnlCricket As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EnterPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
