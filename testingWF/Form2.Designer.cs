namespace testingWF
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addItemButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.actualСostInt = new System.Windows.Forms.MaskedTextBox();
            this.notExactCostInt = new System.Windows.Forms.MaskedTextBox();
            this.quantityStr = new System.Windows.Forms.MaskedTextBox();
            this.buyNameStr = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(388, 261);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(118, 23);
            this.addItemButton.TabIndex = 6;
            this.addItemButton.Text = "Отредактировать";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.VisibleChanged += new System.EventHandler(this.AddItemButton_VisibleChanged);
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(426, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // actualСostInt
            // 
            this.actualСostInt.Location = new System.Drawing.Point(83, 204);
            this.actualСostInt.Mask = "000000000";
            this.actualСostInt.Name = "actualСostInt";
            this.actualСostInt.Size = new System.Drawing.Size(217, 20);
            this.actualСostInt.TabIndex = 3;
            this.actualСostInt.Enter += new System.EventHandler(this.Enter_Event);
            this.actualСostInt.Leave += new System.EventHandler(this.Leave_Event);
            // 
            // notExactCostInt
            // 
            this.notExactCostInt.Location = new System.Drawing.Point(83, 261);
            this.notExactCostInt.Mask = "000000000";
            this.notExactCostInt.Name = "notExactCostInt";
            this.notExactCostInt.Size = new System.Drawing.Size(217, 20);
            this.notExactCostInt.TabIndex = 4;
            this.notExactCostInt.Enter += new System.EventHandler(this.Enter_Event);
            this.notExactCostInt.Leave += new System.EventHandler(this.Leave_Event);
            // 
            // quantityStr
            // 
            this.quantityStr.Location = new System.Drawing.Point(83, 142);
            this.quantityStr.Mask = "00000000";
            this.quantityStr.Name = "quantityStr";
            this.quantityStr.ResetOnPrompt = false;
            this.quantityStr.ResetOnSpace = false;
            this.quantityStr.Size = new System.Drawing.Size(217, 20);
            this.quantityStr.TabIndex = 2;
            this.quantityStr.Enter += new System.EventHandler(this.Enter_Event);
            this.quantityStr.Leave += new System.EventHandler(this.Leave_Event);
            // 
            // buyNameStr
            // 
            this.buyNameStr.Location = new System.Drawing.Point(83, 86);
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
            this.label5.Location = new System.Drawing.Point(254, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Заполните поля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Приблизительная стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Фактическая мтоимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Наименование покупки";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buyNameStr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.quantityStr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.notExactCostInt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.actualСostInt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.addItemButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 332);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 356);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox actualСostInt;
        private System.Windows.Forms.MaskedTextBox notExactCostInt;
        private System.Windows.Forms.MaskedTextBox quantityStr;
        private System.Windows.Forms.MaskedTextBox buyNameStr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}