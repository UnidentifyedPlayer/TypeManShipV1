namespace TypeManShip
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Data.DataColumn Password;
            System.Data.DataColumn ExpValue;
            System.Data.DataColumn Dispersion;
            this.pass_enter_textbox = new System.Windows.Forms.TextBox();
            this.logbox = new System.Windows.Forms.TextBox();
            this.pass_set_label = new System.Windows.Forms.Label();
            this.pass_set_textbox = new System.Windows.Forms.TextBox();
            this.pass_enter_label = new System.Windows.Forms.Label();
            this.pass_set_button = new System.Windows.Forms.Button();
            this.pass_entry_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.exp_speed = new System.Windows.Forms.Label();
            this.dispersion_l = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.UserID = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.EntryID = new System.Data.DataColumn();
            this.Speed = new System.Data.DataColumn();
            this.EntryDate = new System.Data.DataColumn();
            this.dataTable3 = new System.Data.DataTable();
            this.PressID = new System.Data.DataColumn();
            this.FKEntryID = new System.Data.DataColumn();
            this.KeyDownTime = new System.Data.DataColumn();
            this.KeyUpTime = new System.Data.DataColumn();
            this.Stats = new System.Windows.Forms.Button();
            this.day_stats_win_button = new System.Windows.Forms.Button();
            Password = new System.Data.DataColumn();
            ExpValue = new System.Data.DataColumn();
            Dispersion = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            Password.ColumnName = "Password";
            // 
            // ExpValue
            // 
            ExpValue.ColumnName = "ExpValue";
            ExpValue.DataType = typeof(double);
            // 
            // Dispersion
            // 
            Dispersion.ColumnName = "Dispersion";
            Dispersion.DataType = typeof(double);
            // 
            // pass_enter_textbox
            // 
            this.pass_enter_textbox.Location = new System.Drawing.Point(24, 129);
            this.pass_enter_textbox.Name = "pass_enter_textbox";
            this.pass_enter_textbox.Size = new System.Drawing.Size(122, 20);
            this.pass_enter_textbox.TabIndex = 0;
            this.pass_enter_textbox.TextChanged += new System.EventHandler(this.pass_enter_textbox_TextChanged);
            this.pass_enter_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_enter_textbox_KeyDown);
            this.pass_enter_textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pass_enter_textbox_KeyUp);
            // 
            // logbox
            // 
            this.logbox.Location = new System.Drawing.Point(521, 12);
            this.logbox.Multiline = true;
            this.logbox.Name = "logbox";
            this.logbox.ReadOnly = true;
            this.logbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logbox.Size = new System.Drawing.Size(183, 237);
            this.logbox.TabIndex = 1;
            this.logbox.TextChanged += new System.EventHandler(this.logbox_TextChanged);
            // 
            // pass_set_label
            // 
            this.pass_set_label.AutoSize = true;
            this.pass_set_label.Location = new System.Drawing.Point(21, 46);
            this.pass_set_label.Name = "pass_set_label";
            this.pass_set_label.Size = new System.Drawing.Size(106, 13);
            this.pass_set_label.TabIndex = 2;
            this.pass_set_label.Text = "Установить пароль";
            // 
            // pass_set_textbox
            // 
            this.pass_set_textbox.Location = new System.Drawing.Point(24, 62);
            this.pass_set_textbox.Name = "pass_set_textbox";
            this.pass_set_textbox.Size = new System.Drawing.Size(122, 20);
            this.pass_set_textbox.TabIndex = 3;
            this.pass_set_textbox.TextChanged += new System.EventHandler(this.pass_set_textbox_TextChanged);
            this.pass_set_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_set_textbox_KeyDown);
            this.pass_set_textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pass_set_textbox_KeyUp);
            // 
            // pass_enter_label
            // 
            this.pass_enter_label.AutoSize = true;
            this.pass_enter_label.Location = new System.Drawing.Point(21, 113);
            this.pass_enter_label.Name = "pass_enter_label";
            this.pass_enter_label.Size = new System.Drawing.Size(82, 13);
            this.pass_enter_label.TabIndex = 4;
            this.pass_enter_label.Text = "Ввести пароль";
            // 
            // pass_set_button
            // 
            this.pass_set_button.Location = new System.Drawing.Point(152, 60);
            this.pass_set_button.Name = "pass_set_button";
            this.pass_set_button.Size = new System.Drawing.Size(75, 23);
            this.pass_set_button.TabIndex = 5;
            this.pass_set_button.Text = "Установить";
            this.pass_set_button.UseVisualStyleBackColor = true;
            this.pass_set_button.Click += new System.EventHandler(this.pass_set_button_Click);
            // 
            // pass_entry_button
            // 
            this.pass_entry_button.Location = new System.Drawing.Point(152, 127);
            this.pass_entry_button.Name = "pass_entry_button";
            this.pass_entry_button.Size = new System.Drawing.Size(75, 23);
            this.pass_entry_button.TabIndex = 6;
            this.pass_entry_button.Text = "Ввести";
            this.pass_entry_button.UseVisualStyleBackColor = true;
            this.pass_entry_button.Click += new System.EventHandler(this.pass_entry_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(233, 12);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 7;
            this.reset_button.Text = "Сбросить";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // exp_speed
            // 
            this.exp_speed.AutoSize = true;
            this.exp_speed.Location = new System.Drawing.Point(388, 113);
            this.exp_speed.Name = "exp_speed";
            this.exp_speed.Size = new System.Drawing.Size(82, 13);
            this.exp_speed.TabIndex = 8;
            this.exp_speed.Text = "exp speed: N/A";
            // 
            // dispersion_l
            // 
            this.dispersion_l.AutoSize = true;
            this.dispersion_l.Location = new System.Drawing.Point(388, 137);
            this.dispersion_l.Name = "dispersion_l";
            this.dispersion_l.Size = new System.Drawing.Size(80, 13);
            this.dispersion_l.TabIndex = 9;
            this.dispersion_l.Text = "dispersion: N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Наложения 1-го рода: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Наложения 2-го рода: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Наложения 3-го рода: 0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Сложность: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Введи 5 раз";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "BaseData";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2,
            this.dataTable3});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.UserID,
            Password,
            ExpValue,
            Dispersion});
            this.dataTable1.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "UserID"}, true)});
            this.dataTable1.PrimaryKey = new System.Data.DataColumn[] {
        this.UserID};
            this.dataTable1.TableName = "Users";
            // 
            // UserID
            // 
            this.UserID.AllowDBNull = false;
            this.UserID.AutoIncrement = true;
            this.UserID.ColumnName = "UserID";
            this.UserID.DataType = typeof(long);
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.EntryID,
            this.Speed,
            this.EntryDate});
            this.dataTable2.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Entry_id"}, true)});
            this.dataTable2.PrimaryKey = new System.Data.DataColumn[] {
        this.EntryID};
            this.dataTable2.TableName = "PhraseEntries";
            // 
            // EntryID
            // 
            this.EntryID.AllowDBNull = false;
            this.EntryID.ColumnName = "Entry_id";
            this.EntryID.DataType = typeof(long);
            // 
            // Speed
            // 
            this.Speed.ColumnName = "Speed";
            this.Speed.DataType = typeof(double);
            // 
            // EntryDate
            // 
            this.EntryDate.Caption = "EntryDate";
            this.EntryDate.ColumnName = "EntryDate";
            this.EntryDate.DataType = typeof(System.DateTime);
            // 
            // dataTable3
            // 
            this.dataTable3.Columns.AddRange(new System.Data.DataColumn[] {
            this.PressID,
            this.FKEntryID,
            this.KeyDownTime,
            this.KeyUpTime});
            this.dataTable3.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "PressID"}, true)});
            this.dataTable3.PrimaryKey = new System.Data.DataColumn[] {
        this.PressID};
            this.dataTable3.TableName = "KeyPresses";
            // 
            // PressID
            // 
            this.PressID.AllowDBNull = false;
            this.PressID.ColumnName = "PressID";
            this.PressID.DataType = typeof(long);
            // 
            // FKEntryID
            // 
            this.FKEntryID.ColumnName = "EntryID";
            // 
            // KeyDownTime
            // 
            this.KeyDownTime.ColumnName = "KeyDownTime";
            this.KeyDownTime.DataType = typeof(int);
            // 
            // KeyUpTime
            // 
            this.KeyUpTime.ColumnName = "KeyUpTime";
            this.KeyUpTime.DataType = typeof(int);
            // 
            // Stats
            // 
            this.Stats.Location = new System.Drawing.Point(406, 181);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(75, 23);
            this.Stats.TabIndex = 18;
            this.Stats.Text = "Stats";
            this.Stats.UseVisualStyleBackColor = true;
            this.Stats.Click += new System.EventHandler(this.Stats_Click);
            // 
            // day_stats_win_button
            // 
            this.day_stats_win_button.Location = new System.Drawing.Point(406, 216);
            this.day_stats_win_button.Name = "day_stats_win_button";
            this.day_stats_win_button.Size = new System.Drawing.Size(90, 23);
            this.day_stats_win_button.TabIndex = 19;
            this.day_stats_win_button.Text = "Day Statistics";
            this.day_stats_win_button.UseVisualStyleBackColor = true;
            this.day_stats_win_button.Click += new System.EventHandler(this.day_stats_win_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 274);
            this.Controls.Add(this.day_stats_win_button);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dispersion_l);
            this.Controls.Add(this.exp_speed);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.pass_entry_button);
            this.Controls.Add(this.pass_set_button);
            this.Controls.Add(this.pass_enter_label);
            this.Controls.Add(this.pass_set_textbox);
            this.Controls.Add(this.pass_set_label);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.pass_enter_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pass_enter_textbox;
        private System.Windows.Forms.TextBox logbox;
        private System.Windows.Forms.Label pass_set_label;
        private System.Windows.Forms.TextBox pass_set_textbox;
        private System.Windows.Forms.Label pass_enter_label;
        private System.Windows.Forms.Button pass_set_button;
        private System.Windows.Forms.Button pass_entry_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Label exp_speed;
        private System.Windows.Forms.Label dispersion_l;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn UserID;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn EntryID;
        private System.Data.DataColumn Speed;
        private System.Data.DataColumn EntryDate;
        private System.Data.DataTable dataTable3;
        private System.Data.DataColumn PressID;
        private System.Data.DataColumn FKEntryID;
        private System.Data.DataColumn KeyDownTime;
        private System.Data.DataColumn KeyUpTime;
        private System.Windows.Forms.Button Stats;
        private System.Windows.Forms.Button day_stats_win_button;
    }
}

