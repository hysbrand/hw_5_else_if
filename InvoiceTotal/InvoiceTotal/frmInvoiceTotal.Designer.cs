namespace InvoiceTotal
{
    partial class frmInvoiceTotal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSubtotal = new TextBox();
            txtDiscountPercent = new TextBox();
            txtDiscountAmount = new TextBox();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 55);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "&Subtotal:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 91);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 1;
            label2.Text = "Discount percent:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 127);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 2;
            label3.Text = "Discount amount:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 160);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Total:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(259, 55);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(125, 27);
            txtSubtotal.TabIndex = 1;
            // 
            // txtDiscountPercent
            // 
            txtDiscountPercent.Location = new Point(259, 87);
            txtDiscountPercent.Name = "txtDiscountPercent";
            txtDiscountPercent.ReadOnly = true;
            txtDiscountPercent.Size = new Size(125, 27);
            txtDiscountPercent.TabIndex = 5;
            txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new Point(259, 120);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.ReadOnly = true;
            txtDiscountAmount.Size = new Size(125, 27);
            txtDiscountAmount.TabIndex = 6;
            txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(259, 153);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 7;
            txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(126, 213);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(290, 213);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(543, 309);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(txtDiscountAmount);
            Controls.Add(txtDiscountPercent);
            Controls.Add(txtSubtotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInvoiceTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSubtotal;
        private TextBox txtDiscountPercent;
        private TextBox txtDiscountAmount;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Button btnExit;
    }
}
