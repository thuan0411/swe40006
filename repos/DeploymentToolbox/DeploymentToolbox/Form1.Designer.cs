namespace DeploymentToolbox
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMathResult = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.lblTextResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblA
            //
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(20, 20);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(60, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Number A:";
            //
            // txtA
            //
            this.txtA.Location = new System.Drawing.Point(140, 17);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(140, 20);
            this.txtA.TabIndex = 1;
            //
            // lblB
            //
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(20, 55);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(60, 13);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Number B:";
            //
            // txtB
            //
            this.txtB.Location = new System.Drawing.Point(140, 52);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(140, 20);
            this.txtB.TabIndex = 3;
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(140, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add (MathEngine.dll)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // lblMathResult
            //
            this.lblMathResult.AutoSize = true;
            this.lblMathResult.Location = new System.Drawing.Point(20, 130);
            this.lblMathResult.Name = "lblMathResult";
            this.lblMathResult.Size = new System.Drawing.Size(46, 13);
            this.lblMathResult.TabIndex = 5;
            this.lblMathResult.Text = "Result:";
            //
            // lblInput
            //
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(20, 175);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(31, 13);
            this.lblInput.TabIndex = 6;
            this.lblInput.Text = "Text:";
            //
            // txtInput
            //
            this.txtInput.Location = new System.Drawing.Point(140, 172);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(240, 20);
            this.txtInput.TabIndex = 7;
            //
            // btnReverse
            //
            this.btnReverse.Location = new System.Drawing.Point(140, 208);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(200, 30);
            this.btnReverse.TabIndex = 8;
            this.btnReverse.Text = "Reverse (TextUtils.dll)";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            //
            // lblTextResult
            //
            this.lblTextResult.AutoSize = true;
            this.lblTextResult.Location = new System.Drawing.Point(20, 250);
            this.lblTextResult.Name = "lblTextResult";
            this.lblTextResult.Size = new System.Drawing.Size(46, 13);
            this.lblTextResult.TabIndex = 9;
            this.lblTextResult.Text = "Result:";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblTextResult);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblMathResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Deployment Toolbox - SWE40006";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMathResult;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Label lblTextResult;
    }
}
