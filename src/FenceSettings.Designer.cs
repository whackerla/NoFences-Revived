namespace NoFences
{
    partial class FenceSettings
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
            this.chkLocked = new System.Windows.Forms.CheckBox();
            this.chkMinify = new System.Windows.Forms.CheckBox();
            this.FenceName = new System.Windows.Forms.Label();
            this.TitleHeight = new System.Windows.Forms.Label();
            this.txtFenceName = new System.Windows.Forms.TextBox();
            this.numTitleHeight = new System.Windows.Forms.NumericUpDown();
            this.btnNewFence = new System.Windows.Forms.Button();
            this.btnDeleteFence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTitleHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // chkLocked
            // 
            this.chkLocked.AccessibleName = "Lock";
            this.chkLocked.AutoSize = true;
            this.chkLocked.Location = new System.Drawing.Point(8, 14);
            this.chkLocked.Name = "chkLocked";
            this.chkLocked.Size = new System.Drawing.Size(95, 20);
            this.chkLocked.TabIndex = 0;
            this.chkLocked.Text = "checkBox1";
            this.chkLocked.UseVisualStyleBackColor = true;
            // 
            // chkMinify
            // 
            this.chkMinify.AccessibleName = "Minimise";
            this.chkMinify.AutoSize = true;
            this.chkMinify.Location = new System.Drawing.Point(8, 40);
            this.chkMinify.Name = "chkMinify";
            this.chkMinify.Size = new System.Drawing.Size(95, 20);
            this.chkMinify.TabIndex = 1;
            this.chkMinify.Text = "checkBox2";
            this.chkMinify.UseVisualStyleBackColor = true;
            // 
            // FenceName
            // 
            this.FenceName.AccessibleName = "Fence Name";
            this.FenceName.AutoSize = true;
            this.FenceName.Location = new System.Drawing.Point(5, 63);
            this.FenceName.Name = "FenceName";
            this.FenceName.Size = new System.Drawing.Size(44, 16);
            this.FenceName.TabIndex = 2;
            this.FenceName.Text = "label1";
            // 
            // TitleHeight
            // 
            this.TitleHeight.AccessibleName = "Title height";
            this.TitleHeight.AutoSize = true;
            this.TitleHeight.Location = new System.Drawing.Point(5, 107);
            this.TitleHeight.Name = "TitleHeight";
            this.TitleHeight.Size = new System.Drawing.Size(44, 16);
            this.TitleHeight.TabIndex = 3;
            this.TitleHeight.Text = "label2";
            // 
            // txtFenceName
            // 
            this.txtFenceName.AccessibleDescription = "Fence Name";
            this.txtFenceName.Location = new System.Drawing.Point(8, 82);
            this.txtFenceName.Name = "txtFenceName";
            this.txtFenceName.Size = new System.Drawing.Size(100, 22);
            this.txtFenceName.TabIndex = 4;
            // 
            // numTitleHeight
            // 
            this.numTitleHeight.AccessibleName = "Title text height";
            this.numTitleHeight.Location = new System.Drawing.Point(8, 126);
            this.numTitleHeight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numTitleHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTitleHeight.Name = "numTitleHeight";
            this.numTitleHeight.Size = new System.Drawing.Size(120, 22);
            this.numTitleHeight.TabIndex = 5;
            this.numTitleHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnNewFence
            // 
            this.btnNewFence.AccessibleName = "New Fence";
            this.btnNewFence.Location = new System.Drawing.Point(8, 154);
            this.btnNewFence.Name = "btnNewFence";
            this.btnNewFence.Size = new System.Drawing.Size(75, 23);
            this.btnNewFence.TabIndex = 6;
            this.btnNewFence.Text = "button1";
            this.btnNewFence.UseVisualStyleBackColor = true;
            this.btnNewFence.Click += new System.EventHandler(this.btnNewFence_Click);
            // 
            // btnDeleteFence
            // 
            this.btnDeleteFence.AccessibleName = "Delete Fence";
            this.btnDeleteFence.Location = new System.Drawing.Point(8, 183);
            this.btnDeleteFence.Name = "btnDeleteFence";
            this.btnDeleteFence.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFence.TabIndex = 7;
            this.btnDeleteFence.Text = "button1";
            this.btnDeleteFence.UseVisualStyleBackColor = true;
            this.btnDeleteFence.Click += new System.EventHandler(this.btnDeleteFence_Click);
            // 
            // FenceSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteFence);
            this.Controls.Add(this.btnNewFence);
            this.Controls.Add(this.numTitleHeight);
            this.Controls.Add(this.txtFenceName);
            this.Controls.Add(this.TitleHeight);
            this.Controls.Add(this.FenceName);
            this.Controls.Add(this.chkMinify);
            this.Controls.Add(this.chkLocked);
            this.Name = "FenceSettings";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numTitleHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLocked;
        private System.Windows.Forms.CheckBox chkMinify;
        private System.Windows.Forms.Label FenceName;
        private System.Windows.Forms.Label TitleHeight;
        private System.Windows.Forms.TextBox txtFenceName;
        private System.Windows.Forms.NumericUpDown numTitleHeight;
        private System.Windows.Forms.Button btnNewFence;
        private System.Windows.Forms.Button btnDeleteFence;
    }
}