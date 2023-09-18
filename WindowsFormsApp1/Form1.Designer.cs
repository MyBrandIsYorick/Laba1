namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.Marka = new System.Windows.Forms.TextBox();
            this.Tec_Year = new System.Windows.Forms.TextBox();
            this.Rel_Year = new System.Windows.Forms.TextBox();
            this.Owner1 = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.L = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.Enter_Car = new System.Windows.Forms.Button();
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.getBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getRelYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTecYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Get_Fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Fine_Box = new System.Windows.Forms.TextBox();
            this.Fine_Enter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Pay_Fine = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.New_Owner = new System.Windows.Forms.TextBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Tech_Box = new System.Windows.Forms.TextBox();
            this.Button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Marka
            // 
            this.Marka.Location = new System.Drawing.Point(234, 53);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(100, 26);
            this.Marka.TabIndex = 0;
            this.Marka.Text = "Марка";
            // 
            // Tec_Year
            // 
            this.Tec_Year.Location = new System.Drawing.Point(658, 53);
            this.Tec_Year.Name = "Tec_Year";
            this.Tec_Year.Size = new System.Drawing.Size(100, 26);
            this.Tec_Year.TabIndex = 1;
            this.Tec_Year.Text = "Год ТО";
            // 
            // Rel_Year
            // 
            this.Rel_Year.Location = new System.Drawing.Point(552, 53);
            this.Rel_Year.Name = "Rel_Year";
            this.Rel_Year.Size = new System.Drawing.Size(100, 26);
            this.Rel_Year.TabIndex = 2;
            this.Rel_Year.Text = "Год выпуска";
            // 
            // Owner1
            // 
            this.Owner1.Location = new System.Drawing.Point(446, 53);
            this.Owner1.Name = "Owner1";
            this.Owner1.Size = new System.Drawing.Size(100, 26);
            this.Owner1.TabIndex = 3;
            this.Owner1.Text = "Владелец";
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(340, 53);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(100, 26);
            this.Model.TabIndex = 4;
            this.Model.Text = "Модель";
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.BackColor = System.Drawing.Color.Lime;
            this.L.Location = new System.Drawing.Point(256, 9);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(57, 20);
            this.L.TabIndex = 6;
            this.L.Text = "Марка";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.BackColor = System.Drawing.Color.Lime;
            this.A.Location = new System.Drawing.Point(352, 9);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(70, 20);
            this.A.TabIndex = 7;
            this.A.Text = "Модель";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.BackColor = System.Drawing.Color.Lime;
            this.B.Location = new System.Drawing.Point(456, 9);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(87, 20);
            this.B.TabIndex = 8;
            this.B.Text = "Владелец";
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.BackColor = System.Drawing.Color.Lime;
            this.E.Location = new System.Drawing.Point(549, 9);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(103, 20);
            this.E.TabIndex = 9;
            this.E.Text = "Год выпуска";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.BackColor = System.Drawing.Color.Lime;
            this.L2.Location = new System.Drawing.Point(670, 9);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(63, 20);
            this.L2.TabIndex = 10;
            this.L2.Text = "Год ТО";
            // 
            // Enter_Car
            // 
            this.Enter_Car.Location = new System.Drawing.Point(413, 89);
            this.Enter_Car.Name = "Enter_Car";
            this.Enter_Car.Size = new System.Drawing.Size(95, 54);
            this.Enter_Car.TabIndex = 12;
            this.Enter_Car.Text = "Ввести!";
            this.Enter_Car.UseVisualStyleBackColor = true;
            this.Enter_Car.Click += new System.EventHandler(this.Enter_Click);
            // 
            // dataGridCars
            // 
            this.dataGridCars.AutoGenerateColumns = false;
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getBrandDataGridViewTextBoxColumn,
            this.getModelDataGridViewTextBoxColumn,
            this.getOwnerDataGridViewTextBoxColumn,
            this.getRelYearDataGridViewTextBoxColumn,
            this.getTecYearDataGridViewTextBoxColumn,
            this.Get_Fine});
            this.dataGridCars.DataSource = this.autoBindingSource;
            this.dataGridCars.Location = new System.Drawing.Point(47, 149);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.RowHeadersWidth = 62;
            this.dataGridCars.RowTemplate.Height = 28;
            this.dataGridCars.Size = new System.Drawing.Size(965, 150);
            this.dataGridCars.TabIndex = 14;
            // 
            // getBrandDataGridViewTextBoxColumn
            // 
            this.getBrandDataGridViewTextBoxColumn.DataPropertyName = "Get_Brand";
            this.getBrandDataGridViewTextBoxColumn.HeaderText = "Get_Brand";
            this.getBrandDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.getBrandDataGridViewTextBoxColumn.Name = "getBrandDataGridViewTextBoxColumn";
            this.getBrandDataGridViewTextBoxColumn.ReadOnly = true;
            this.getBrandDataGridViewTextBoxColumn.Width = 150;
            // 
            // getModelDataGridViewTextBoxColumn
            // 
            this.getModelDataGridViewTextBoxColumn.DataPropertyName = "Get_Model";
            this.getModelDataGridViewTextBoxColumn.HeaderText = "Get_Model";
            this.getModelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.getModelDataGridViewTextBoxColumn.Name = "getModelDataGridViewTextBoxColumn";
            this.getModelDataGridViewTextBoxColumn.ReadOnly = true;
            this.getModelDataGridViewTextBoxColumn.Width = 150;
            // 
            // getOwnerDataGridViewTextBoxColumn
            // 
            this.getOwnerDataGridViewTextBoxColumn.DataPropertyName = "Get_Owner";
            this.getOwnerDataGridViewTextBoxColumn.HeaderText = "Get_Owner";
            this.getOwnerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.getOwnerDataGridViewTextBoxColumn.Name = "getOwnerDataGridViewTextBoxColumn";
            this.getOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.getOwnerDataGridViewTextBoxColumn.Width = 150;
            // 
            // getRelYearDataGridViewTextBoxColumn
            // 
            this.getRelYearDataGridViewTextBoxColumn.DataPropertyName = "Get_Rel_Year";
            this.getRelYearDataGridViewTextBoxColumn.HeaderText = "Get_Rel_Year";
            this.getRelYearDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.getRelYearDataGridViewTextBoxColumn.Name = "getRelYearDataGridViewTextBoxColumn";
            this.getRelYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.getRelYearDataGridViewTextBoxColumn.Width = 150;
            // 
            // getTecYearDataGridViewTextBoxColumn
            // 
            this.getTecYearDataGridViewTextBoxColumn.DataPropertyName = "Get_Tec_Year";
            this.getTecYearDataGridViewTextBoxColumn.HeaderText = "Get_Tec_Year";
            this.getTecYearDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.getTecYearDataGridViewTextBoxColumn.Name = "getTecYearDataGridViewTextBoxColumn";
            this.getTecYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.getTecYearDataGridViewTextBoxColumn.Width = 150;
            // 
            // Get_Fine
            // 
            this.Get_Fine.DataPropertyName = "Get_Fine";
            this.Get_Fine.HeaderText = "Get_Fine";
            this.Get_Fine.MinimumWidth = 8;
            this.Get_Fine.Name = "Get_Fine";
            this.Get_Fine.ReadOnly = true;
            this.Get_Fine.Width = 150;
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataSource = typeof(ClassLibrary1.Auto);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(87, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Введите штраф";
            // 
            // Fine_Box
            // 
            this.Fine_Box.Location = new System.Drawing.Point(91, 366);
            this.Fine_Box.Name = "Fine_Box";
            this.Fine_Box.Size = new System.Drawing.Size(131, 26);
            this.Fine_Box.TabIndex = 16;
            // 
            // Fine_Enter
            // 
            this.Fine_Enter.Location = new System.Drawing.Point(74, 418);
            this.Fine_Enter.Name = "Fine_Enter";
            this.Fine_Enter.Size = new System.Drawing.Size(167, 49);
            this.Fine_Enter.TabIndex = 17;
            this.Fine_Enter.Text = "Выписать штраф";
            this.Fine_Enter.UseVisualStyleBackColor = true;
            this.Fine_Enter.Click += new System.EventHandler(this.Fine_Enter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(309, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Введите сумму";
            // 
            // Pay_Fine
            // 
            this.Pay_Fine.Location = new System.Drawing.Point(304, 366);
            this.Pay_Fine.Name = "Pay_Fine";
            this.Pay_Fine.Size = new System.Drawing.Size(140, 26);
            this.Pay_Fine.TabIndex = 19;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(295, 418);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(167, 49);
            this.Button1.TabIndex = 20;
            this.Button1.Text = "Оплатить штраф";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(552, 89);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(161, 54);
            this.Button2.TabIndex = 21;
            this.Button2.Text = "Удалить машину";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(529, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Продать авто";
            // 
            // New_Owner
            // 
            this.New_Owner.Location = new System.Drawing.Point(500, 366);
            this.New_Owner.Name = "New_Owner";
            this.New_Owner.Size = new System.Drawing.Size(187, 26);
            this.New_Owner.TabIndex = 23;
            this.New_Owner.Text = "Имя нового владельца";
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(515, 418);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(149, 49);
            this.Button3.TabIndex = 24;
            this.Button3.Text = "Продать";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Введите год ТО";
            // 
            // Tech_Box
            // 
            this.Tech_Box.Location = new System.Drawing.Point(738, 366);
            this.Tech_Box.Name = "Tech_Box";
            this.Tech_Box.Size = new System.Drawing.Size(140, 26);
            this.Tech_Box.TabIndex = 26;
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(738, 418);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(140, 49);
            this.Button4.TabIndex = 27;
            this.Button4.Text = "Обновить ТО";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 481);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Tech_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.New_Owner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Pay_Fine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fine_Enter);
            this.Controls.Add(this.Fine_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridCars);
            this.Controls.Add(this.Enter_Car);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.E);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.L);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Owner1);
            this.Controls.Add(this.Rel_Year);
            this.Controls.Add(this.Tec_Year);
            this.Controls.Add(this.Marka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Marka;
        private System.Windows.Forms.TextBox Tec_Year;
        private System.Windows.Forms.TextBox Rel_Year;
        private System.Windows.Forms.TextBox Owner1;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Button Enter_Car;
        private System.Windows.Forms.DataGridView dataGridCars;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn getBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getRelYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTecYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Get_Fine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fine_Box;
        private System.Windows.Forms.Button Fine_Enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pay_Fine;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox New_Owner;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tech_Box;
        private System.Windows.Forms.Button Button4;
    }
}

