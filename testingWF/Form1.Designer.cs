﻿namespace testingWF
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
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buyNameStr = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.actualСostInt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.notExactCostInt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityStr = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(44, 26);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 0;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Button);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(153, 26);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 1;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(264, 26);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(92, 23);
            this.edit_button.TabIndex = 2;
            this.edit_button.Text = "Редактировать";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.Edit_Button);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(35, 111);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(720, 274);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView1_ColumnWidthChanging);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наименование покупки";
            this.columnHeader1.Width = 141;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Количество";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Приблизительная стоимость";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Фактическая стоимость";
            this.columnHeader4.Width = 138;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Разница";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Статус покупки";
            this.columnHeader6.Width = 155;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buyNameStr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.addItemButton);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.actualСostInt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.notExactCostInt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.quantityStr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(174, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 274);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            this.groupBox1.VisibleChanged += new System.EventHandler(this.GroupBox1_VisibleChanged);
            // 
            // buyNameStr
            // 
            this.buyNameStr.Location = new System.Drawing.Point(20, 64);
            this.buyNameStr.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.buyNameStr.Name = "buyNameStr";
            this.buyNameStr.Size = new System.Drawing.Size(217, 20);
            this.buyNameStr.TabIndex = 1;
            this.buyNameStr.Enter += new System.EventHandler(this.Enter_Event);
            this.buyNameStr.Leave += new System.EventHandler(this.Leave_Event);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(188, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Заполните поля";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Info;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(372, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 44);
            this.button6.TabIndex = 12;
            this.button6.TabStop = false;
            this.button6.Text = "Очистить и добавить еще";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Location = new System.Drawing.Point(486, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 23);
            this.button5.TabIndex = 10;
            this.button5.TabStop = false;
            this.button5.Text = "Х";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(372, 237);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(118, 23);
            this.addItemButton.TabIndex = 9;
            this.addItemButton.Text = "Добавить";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.VisibleChanged += new System.EventHandler(this.AddItemButton_VisibleChanged);
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(410, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Куплено?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Приблизительная стоимость";
            // 
            // actualСostInt
            // 
            this.actualСostInt.Location = new System.Drawing.Point(20, 182);
            this.actualСostInt.Mask = "000000000";
            this.actualСostInt.Name = "actualСostInt";
            this.actualСostInt.Size = new System.Drawing.Size(217, 20);
            this.actualСostInt.TabIndex = 3;
            this.actualСostInt.Enter += new System.EventHandler(this.Enter_Event);
            this.actualСostInt.Leave += new System.EventHandler(this.Leave_Event);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Фактическая мтоимость";
            // 
            // notExactCostInt
            // 
            this.notExactCostInt.Location = new System.Drawing.Point(20, 239);
            this.notExactCostInt.Mask = "000000000";
            this.notExactCostInt.Name = "notExactCostInt";
            this.notExactCostInt.Size = new System.Drawing.Size(217, 20);
            this.notExactCostInt.TabIndex = 4;
            this.notExactCostInt.Enter += new System.EventHandler(this.Enter_Event);
            this.notExactCostInt.Leave += new System.EventHandler(this.Leave_Event);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество";
            // 
            // quantityStr
            // 
            this.quantityStr.Location = new System.Drawing.Point(20, 120);
            this.quantityStr.Mask = "00000000";
            this.quantityStr.Name = "quantityStr";
            this.quantityStr.ResetOnPrompt = false;
            this.quantityStr.ResetOnSpace = false;
            this.quantityStr.Size = new System.Drawing.Size(217, 20);
            this.quantityStr.TabIndex = 2;
            this.quantityStr.Enter += new System.EventHandler(this.Enter_Event);
            this.quantityStr.Leave += new System.EventHandler(this.Leave_Event);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование покупки";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(32, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Выберете элемент удаления";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 420);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox actualСostInt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox notExactCostInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox quantityStr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox buyNameStr;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

