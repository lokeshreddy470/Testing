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
        Me.ItemsListBox = New System.Windows.Forms.ListBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CartButton = New System.Windows.Forms.Button()
        Me.CheckoutButton = New System.Windows.Forms.Button()
        Me.CheckOutListBox = New System.Windows.Forms.ListBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriceLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BaseBall_Project.My.Resources.Resources.Book
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ItemsListBox
        '
        Me.ItemsListBox.FormattingEnabled = True
        Me.ItemsListBox.Location = New System.Drawing.Point(13, 180)
        Me.ItemsListBox.Name = "ItemsListBox"
        Me.ItemsListBox.Size = New System.Drawing.Size(181, 238)
        Me.ItemsListBox.TabIndex = 1
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(248, 125)
        Me.SearchTextBox.Multiline = True
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(118, 36)
        Me.SearchTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(245, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter item to Search Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "P&rice"
        '
        'CartButton
        '
        Me.CartButton.Enabled = False
        Me.CartButton.Location = New System.Drawing.Point(248, 209)
        Me.CartButton.Name = "CartButton"
        Me.CartButton.Size = New System.Drawing.Size(145, 41)
        Me.CartButton.TabIndex = 6
        Me.CartButton.Text = "Add To Cart"
        Me.CartButton.UseVisualStyleBackColor = True
        '
        'CheckoutButton
        '
        Me.CheckoutButton.Enabled = False
        Me.CheckoutButton.Location = New System.Drawing.Point(411, 209)
        Me.CheckoutButton.Name = "CheckoutButton"
        Me.CheckoutButton.Size = New System.Drawing.Size(145, 41)
        Me.CheckoutButton.TabIndex = 7
        Me.CheckoutButton.Text = "CheckOut"
        Me.CheckoutButton.UseVisualStyleBackColor = True
        '
        'CheckOutListBox
        '
        Me.CheckOutListBox.FormattingEnabled = True
        Me.CheckOutListBox.Location = New System.Drawing.Point(562, 209)
        Me.CheckOutListBox.Name = "CheckOutListBox"
        Me.CheckOutListBox.Size = New System.Drawing.Size(194, 238)
        Me.CheckOutListBox.TabIndex = 8
        '
        'searchButton
        '
        Me.searchButton.Enabled = False
        Me.searchButton.Location = New System.Drawing.Point(549, 120)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(118, 41)
        Me.searchButton.TabIndex = 9
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(315, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Total"
        '
        'TotalLabel
        '
        Me.TotalLabel.BackColor = System.Drawing.Color.White
        Me.TotalLabel.Location = New System.Drawing.Point(283, 426)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(110, 31)
        Me.TotalLabel.TabIndex = 11
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(799, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterPasswordToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "F&ile"
        '
        'EnterPasswordToolStripMenuItem
        '
        Me.EnterPasswordToolStripMenuItem.Name = "EnterPasswordToolStripMenuItem"
        Me.EnterPasswordToolStripMenuItem.ShortcutKeyDisplayString = "P"
        Me.EnterPasswordToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.EnterPasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.EnterPasswordToolStripMenuItem.Text = "Enter Password"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'PriceLabel
        '
        Me.PriceLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PriceLabel.Location = New System.Drawing.Point(399, 125)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(100, 36)
        Me.PriceLabel.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 512)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.CheckOutListBox)
        Me.Controls.Add(Me.CheckoutButton)
        Me.Controls.Add(Me.CartButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.ItemsListBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ItemsListBox As System.Windows.Forms.ListBox
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CartButton As System.Windows.Forms.Button
    Friend WithEvents CheckoutButton As System.Windows.Forms.Button
    Friend WithEvents CheckOutListBox As System.Windows.Forms.ListBox
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PriceLabel As System.Windows.Forms.Label

End Class
