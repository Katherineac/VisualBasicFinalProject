<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScores
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvGridOneHighScores = New System.Windows.Forms.DataGridView()
        Me.GridOneScoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridOneHSDataSet = New Codewords.GridOneHSDataSet()
        Me.dgvGridTwoHighScores = New System.Windows.Forms.DataGridView()
        Me.GridTwoScoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HighScoresDataSet = New Codewords.HighScoresDataSet()
        Me.lblGridOne = New System.Windows.Forms.Label()
        Me.lblGridTwo = New System.Windows.Forms.Label()
        Me.GridTwoScoresTableAdapter = New Codewords.HighScoresDataSetTableAdapters.GridTwoScoresTableAdapter()
        Me.GridOneScoresTableAdapter = New Codewords.GridOneHSDataSetTableAdapters.GridOneScoresTableAdapter()
        Me.GridOneHSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColNameGridOne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTimeGridOne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNameGridTwo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTimeGridTwo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvGridOneHighScores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridOneScoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridOneHSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGridTwoHighScores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridTwoScoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighScoresDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridOneHSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGridOneHighScores
        '
        Me.dgvGridOneHighScores.AllowUserToAddRows = False
        Me.dgvGridOneHighScores.AllowUserToDeleteRows = False
        Me.dgvGridOneHighScores.AllowUserToResizeColumns = False
        Me.dgvGridOneHighScores.AllowUserToResizeRows = False
        Me.dgvGridOneHighScores.AutoGenerateColumns = False
        Me.dgvGridOneHighScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGridOneHighScores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvGridOneHighScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridOneHighScores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNameGridOne, Me.ColTimeGridOne})
        Me.dgvGridOneHighScores.DataSource = Me.GridOneScoresBindingSource
        Me.dgvGridOneHighScores.Location = New System.Drawing.Point(12, 49)
        Me.dgvGridOneHighScores.Name = "dgvGridOneHighScores"
        Me.dgvGridOneHighScores.ReadOnly = True
        Me.dgvGridOneHighScores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvGridOneHighScores.RowTemplate.ReadOnly = True
        Me.dgvGridOneHighScores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGridOneHighScores.Size = New System.Drawing.Size(302, 233)
        Me.dgvGridOneHighScores.TabIndex = 0
        '
        'GridOneScoresBindingSource
        '
        Me.GridOneScoresBindingSource.DataMember = "GridOneScores"
        Me.GridOneScoresBindingSource.DataSource = Me.GridOneHSDataSet
        '
        'GridOneHSDataSet
        '
        Me.GridOneHSDataSet.DataSetName = "GridOneHSDataSet"
        Me.GridOneHSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvGridTwoHighScores
        '
        Me.dgvGridTwoHighScores.AllowUserToAddRows = False
        Me.dgvGridTwoHighScores.AllowUserToDeleteRows = False
        Me.dgvGridTwoHighScores.AllowUserToResizeColumns = False
        Me.dgvGridTwoHighScores.AllowUserToResizeRows = False
        Me.dgvGridTwoHighScores.AutoGenerateColumns = False
        Me.dgvGridTwoHighScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGridTwoHighScores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvGridTwoHighScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridTwoHighScores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNameGridTwo, Me.ColTimeGridTwo})
        Me.dgvGridTwoHighScores.DataSource = Me.GridTwoScoresBindingSource
        Me.dgvGridTwoHighScores.Location = New System.Drawing.Point(343, 49)
        Me.dgvGridTwoHighScores.Name = "dgvGridTwoHighScores"
        Me.dgvGridTwoHighScores.ReadOnly = True
        Me.dgvGridTwoHighScores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvGridTwoHighScores.RowTemplate.ReadOnly = True
        Me.dgvGridTwoHighScores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGridTwoHighScores.Size = New System.Drawing.Size(302, 233)
        Me.dgvGridTwoHighScores.TabIndex = 1
        '
        'GridTwoScoresBindingSource
        '
        Me.GridTwoScoresBindingSource.DataMember = "GridTwoScores"
        Me.GridTwoScoresBindingSource.DataSource = Me.HighScoresDataSet
        '
        'HighScoresDataSet
        '
        Me.HighScoresDataSet.DataSetName = "HighScoresDataSet"
        Me.HighScoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblGridOne
        '
        Me.lblGridOne.AutoSize = True
        Me.lblGridOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGridOne.Location = New System.Drawing.Point(12, 29)
        Me.lblGridOne.Name = "lblGridOne"
        Me.lblGridOne.Size = New System.Drawing.Size(70, 17)
        Me.lblGridOne.TabIndex = 2
        Me.lblGridOne.Text = "Grid One:"
        '
        'lblGridTwo
        '
        Me.lblGridTwo.AutoSize = True
        Me.lblGridTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGridTwo.Location = New System.Drawing.Point(340, 29)
        Me.lblGridTwo.Name = "lblGridTwo"
        Me.lblGridTwo.Size = New System.Drawing.Size(69, 17)
        Me.lblGridTwo.TabIndex = 3
        Me.lblGridTwo.Text = "Grid Two:"
        '
        'GridTwoScoresTableAdapter
        '
        Me.GridTwoScoresTableAdapter.ClearBeforeFill = True
        '
        'GridOneScoresTableAdapter
        '
        Me.GridOneScoresTableAdapter.ClearBeforeFill = True
        '
        'GridOneHSDataSetBindingSource
        '
        Me.GridOneHSDataSetBindingSource.DataSource = Me.GridOneHSDataSet
        Me.GridOneHSDataSetBindingSource.Position = 0
        '
        'ColNameGridOne
        '
        Me.ColNameGridOne.DataPropertyName = "Name"
        Me.ColNameGridOne.HeaderText = "Name"
        Me.ColNameGridOne.Name = "ColNameGridOne"
        Me.ColNameGridOne.ReadOnly = True
        Me.ColNameGridOne.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColTimeGridOne
        '
        Me.ColTimeGridOne.DataPropertyName = "Time"
        Me.ColTimeGridOne.HeaderText = "Time"
        Me.ColTimeGridOne.Name = "ColTimeGridOne"
        Me.ColTimeGridOne.ReadOnly = True
        Me.ColTimeGridOne.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'ColNameGridTwo
        '
        Me.ColNameGridTwo.DataPropertyName = "Name"
        Me.ColNameGridTwo.HeaderText = "Name"
        Me.ColNameGridTwo.Name = "ColNameGridTwo"
        Me.ColNameGridTwo.ReadOnly = True
        Me.ColNameGridTwo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColTimeGridTwo
        '
        Me.ColTimeGridTwo.DataPropertyName = "Time"
        Me.ColTimeGridTwo.HeaderText = "Time"
        Me.ColTimeGridTwo.Name = "ColTimeGridTwo"
        Me.ColTimeGridTwo.ReadOnly = True
        Me.ColTimeGridTwo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'HighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 303)
        Me.Controls.Add(Me.lblGridTwo)
        Me.Controls.Add(Me.lblGridOne)
        Me.Controls.Add(Me.dgvGridTwoHighScores)
        Me.Controls.Add(Me.dgvGridOneHighScores)
        Me.Name = "HighScores"
        Me.Text = "High Scores"
        CType(Me.dgvGridOneHighScores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridOneScoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridOneHSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGridTwoHighScores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridTwoScoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HighScoresDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridOneHSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents dgvGridOneHighScores As System.Windows.Forms.DataGridView
    Friend WithEvents dgvGridTwoHighScores As System.Windows.Forms.DataGridView
    Friend WithEvents lblGridOne As System.Windows.Forms.Label
    Friend WithEvents lblGridTwo As System.Windows.Forms.Label
    Friend WithEvents GridOneHSDataSet As Codewords.GridOneHSDataSet
    Friend WithEvents GridOneScoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridOneScoresTableAdapter As Codewords.GridOneHSDataSetTableAdapters.GridOneScoresTableAdapter
    Friend WithEvents HighScoresDataSet As Codewords.HighScoresDataSet
    Friend WithEvents GridTwoScoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridTwoScoresTableAdapter As Codewords.HighScoresDataSetTableAdapters.GridTwoScoresTableAdapter
    Friend WithEvents GridOneHSDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ColNameGridOne As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTimeGridOne As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNameGridTwo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTimeGridTwo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
