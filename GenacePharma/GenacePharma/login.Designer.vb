<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAdminName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.txtAdminPass = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuest = New System.Windows.Forms.Button()
        Me.txtGuestUser = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Users.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     Users"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection2
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\GenacePharma.accdb;" &
    "Jet OLEDB:Database Password=GPDadmin"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `Users` (`User_ID`, `Employee_Name`, `Password`, `UserLevel`) VALUES " &
    "(?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("User_ID", System.Data.OleDb.OleDbType.VarWChar, 0, "User_ID"), New System.Data.OleDb.OleDbParameter("Employee_Name", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Employee_Name"), New System.Data.OleDb.OleDbParameter("Password", System.Data.OleDb.OleDbType.VarWChar, 0, "Password"), New System.Data.OleDb.OleDbParameter("UserLevel", System.Data.OleDb.OleDbType.VarWChar, 0, "UserLevel")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("User_ID", System.Data.OleDb.OleDbType.VarWChar, 0, "User_ID"), New System.Data.OleDb.OleDbParameter("Employee_Name", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Employee_Name"), New System.Data.OleDb.OleDbParameter("Password", System.Data.OleDb.OleDbType.VarWChar, 0, "Password"), New System.Data.OleDb.OleDbParameter("UserLevel", System.Data.OleDb.OleDbType.VarWChar, 0, "UserLevel"), New System.Data.OleDb.OleDbParameter("Original_User_ID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "User_ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Password", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Password", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Password", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Password", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_UserLevel", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UserLevel", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_UserLevel", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserLevel", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM `Users` WHERE ((`User_ID` = ?) AND ((? = 1 AND `Password` IS NULL) OR" &
    " (`Password` = ?)) AND ((? = 1 AND `UserLevel` IS NULL) OR (`UserLevel` = ?)))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection2
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_User_ID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "User_ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Password", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Password", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Password", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Password", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_UserLevel", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UserLevel", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_UserLevel", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserLevel", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Users", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("User_ID", "User_ID"), New System.Data.Common.DataColumnMapping("Employee_Name", "Employee_Name"), New System.Data.Common.DataColumnMapping("Password", "Password"), New System.Data.Common.DataColumnMapping("UserLevel", "UserLevel")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(702, 362)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.tbPass)
        Me.TabPage1.Controls.Add(Me.btnLog)
        Me.TabPage1.Controls.Add(Me.tbUser)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 37)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(694, 321)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "HOME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Couture", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(325, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "PASSWORD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Couture", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(326, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "USER ID"
        '
        'tbPass
        '
        Me.tbPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPass.Location = New System.Drawing.Point(469, 183)
        Me.tbPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.tbPass.Size = New System.Drawing.Size(214, 30)
        Me.tbPass.TabIndex = 2
        '
        'btnLog
        '
        Me.btnLog.BackColor = System.Drawing.Color.SeaGreen
        Me.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLog.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnLog.Location = New System.Drawing.Point(364, 242)
        Me.btnLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(289, 61)
        Me.btnLog.TabIndex = 3
        Me.btnLog.Text = "Sign In"
        Me.btnLog.UseVisualStyleBackColor = False
        '
        'tbUser
        '
        Me.tbUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbUser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUser.ForeColor = System.Drawing.Color.Black
        Me.tbUser.Location = New System.Drawing.Point(469, 124)
        Me.tbUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(214, 30)
        Me.tbUser.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Couture", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label4.Location = New System.Drawing.Point(561, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "SYSTEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Couture", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label3.Location = New System.Drawing.Point(354, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(299, 60)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "GENACE PHARMA " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   DISTRIBUTOR"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.SlateGray
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtAdminName)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.btnAdmin)
        Me.TabPage2.Controls.Add(Me.txtAdminPass)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 37)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(694, 321)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ADMIN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Couture", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(408, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 20)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "ADMIN ID"
        '
        'txtAdminName
        '
        Me.txtAdminName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdminName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminName.ForeColor = System.Drawing.Color.Black
        Me.txtAdminName.Location = New System.Drawing.Point(405, 106)
        Me.txtAdminName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAdminName.Name = "txtAdminName"
        Me.txtAdminName.Size = New System.Drawing.Size(214, 30)
        Me.txtAdminName.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Couture", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(400, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(229, 30)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "ADMIN LOG-IN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Couture", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(408, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "PASSWORD"
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.RosyBrown
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmin.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnAdmin.Location = New System.Drawing.Point(368, 238)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(289, 61)
        Me.btnAdmin.TabIndex = 3
        Me.btnAdmin.Text = "Sign In"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'txtAdminPass
        '
        Me.txtAdminPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminPass.ForeColor = System.Drawing.Color.Black
        Me.txtAdminPass.Location = New System.Drawing.Point(405, 184)
        Me.txtAdminPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAdminPass.Name = "txtAdminPass"
        Me.txtAdminPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtAdminPass.Size = New System.Drawing.Size(214, 30)
        Me.txtAdminPass.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.TextBox1)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.btnGuest)
        Me.TabPage4.Controls.Add(Me.txtGuestUser)
        Me.TabPage4.Controls.Add(Me.PictureBox3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 37)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(694, 321)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "GUEST"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(330, 65)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(345, 34)
        Me.TextBox1.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Couture", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(393, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "* NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Couture", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label1.Location = New System.Drawing.Point(391, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 30)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "GUEST LOG-IN"
        '
        'btnGuest
        '
        Me.btnGuest.BackColor = System.Drawing.Color.SeaGreen
        Me.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuest.Font = New System.Drawing.Font("Mont ExtraLight DEMO", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuest.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnGuest.Location = New System.Drawing.Point(397, 239)
        Me.btnGuest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.Size = New System.Drawing.Size(223, 61)
        Me.btnGuest.TabIndex = 2
        Me.btnGuest.Text = "Sign In"
        Me.btnGuest.UseVisualStyleBackColor = False
        '
        'txtGuestUser
        '
        Me.txtGuestUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuestUser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestUser.ForeColor = System.Drawing.Color.Black
        Me.txtGuestUser.Location = New System.Drawing.Point(396, 176)
        Me.txtGuestUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGuestUser.Name = "txtGuestUser"
        Me.txtGuestUser.Size = New System.Drawing.Size(223, 30)
        Me.txtGuestUser.TabIndex = 1
        '
        'Timer1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.GenacePharma.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(5, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(321, 310)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.GenacePharma.My.Resources.Resources.genace_05
        Me.PictureBox1.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(310, 310)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.GenacePharma.My.Resources.Resources.logo
        Me.PictureBox3.Location = New System.Drawing.Point(0, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(324, 310)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 360)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome User!"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection2 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbPass As TextBox
    Friend WithEvents btnLog As Button
    Friend WithEvents tbUser As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAdminName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAdmin As Button
    Friend WithEvents txtAdminPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuest As Button
    Friend WithEvents txtGuestUser As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
End Class
