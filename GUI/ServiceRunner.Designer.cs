namespace WindowsFormsApp1
{
    partial class ServiceRunnerForm
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
            this.runBtn = new System.Windows.Forms.Button();
            this.serviceStatusLbl = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(450, 474);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(102, 34);
            this.runBtn.TabIndex = 0;
            this.runBtn.Text = "Kør";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // serviceStatusLbl
            // 
            this.serviceStatusLbl.AutoSize = true;
            this.serviceStatusLbl.Location = new System.Drawing.Point(13, 474);
            this.serviceStatusLbl.Name = "serviceStatusLbl";
            this.serviceStatusLbl.Size = new System.Drawing.Size(0, 13);
            this.serviceStatusLbl.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(34, 29);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(455, 421);
            this.MainPanel.TabIndex = 2;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(373, 474);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(71, 34);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ServiceRunnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 520);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.serviceStatusLbl);
            this.Controls.Add(this.runBtn);
            this.Name = "ServiceRunnerForm";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.ServiceRunnerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Label serviceStatusLbl;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button AddBtn;
    }
}

