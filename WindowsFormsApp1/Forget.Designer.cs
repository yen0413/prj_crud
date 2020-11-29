namespace WindowsFormsApp1
{
    partial class Forget
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
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.dateTimePicker_birth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtAcc
            // 
            this.txtAcc.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtAcc.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAcc.Location = new System.Drawing.Point(140, 66);
            this.txtAcc.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(185, 33);
            this.txtAcc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(48, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(79, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birth:";
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Orange;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSub.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSub.Location = new System.Drawing.Point(140, 197);
            this.btnSub.Margin = new System.Windows.Forms.Padding(2);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(96, 34);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "Submit";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // dateTimePicker_birth
            // 
            this.dateTimePicker_birth.CalendarTitleBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dateTimePicker_birth.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_birth.Location = new System.Drawing.Point(140, 121);
            this.dateTimePicker_birth.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_birth.Name = "dateTimePicker_birth";
            this.dateTimePicker_birth.Size = new System.Drawing.Size(185, 33);
            this.dateTimePicker_birth.TabIndex = 5;
            // 
            // Forget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(395, 268);
            this.Controls.Add(this.dateTimePicker_birth);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAcc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Forget";
            this.Text = "Forget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birth;
    }
}