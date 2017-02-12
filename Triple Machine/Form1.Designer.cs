namespace Triple_Machine
{
    partial class frmTriple
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblOuput = new System.Windows.Forms.Label();
            this.btnTriple = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(61, 38);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(78, 16);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "User Input";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(62, 61);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(330, 20);
            this.txtInput.TabIndex = 1;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(61, 117);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(52, 16);
            this.lblOut.TabIndex = 2;
            this.lblOut.Text = "Output";
            // 
            // lblOuput
            // 
            this.lblOuput.BackColor = System.Drawing.Color.Moccasin;
            this.lblOuput.Location = new System.Drawing.Point(62, 137);
            this.lblOuput.Name = "lblOuput";
            this.lblOuput.Size = new System.Drawing.Size(330, 78);
            this.lblOuput.TabIndex = 3;
            // 
            // btnTriple
            // 
            this.btnTriple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriple.Location = new System.Drawing.Point(65, 263);
            this.btnTriple.Name = "btnTriple";
            this.btnTriple.Size = new System.Drawing.Size(109, 79);
            this.btnTriple.TabIndex = 4;
            this.btnTriple.Text = "&Triple";
            this.btnTriple.UseVisualStyleBackColor = true;
            this.btnTriple.Click += new System.EventHandler(this.btnTriple_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(274, 263);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(274, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 24);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTriple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 384);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTriple);
            this.Controls.Add(this.lblOuput);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Name = "frmTriple";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblOuput;
        private System.Windows.Forms.Button btnTriple;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

