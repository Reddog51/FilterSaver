namespace FilterSaver
{
    partial class Form1
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
            this.lbSavedBongoFilters = new System.Windows.Forms.ListBox();
            this.btnLoadFilter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.tbAddFilter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSavedBongoFilters
            // 
            this.lbSavedBongoFilters.FormattingEnabled = true;
            this.lbSavedBongoFilters.Location = new System.Drawing.Point(573, 189);
            this.lbSavedBongoFilters.Name = "lbSavedBongoFilters";
            this.lbSavedBongoFilters.Size = new System.Drawing.Size(120, 95);
            this.lbSavedBongoFilters.TabIndex = 0;
            this.lbSavedBongoFilters.Visible = false;
            // 
            // btnLoadFilter
            // 
            this.btnLoadFilter.Location = new System.Drawing.Point(573, 377);
            this.btnLoadFilter.Name = "btnLoadFilter";
            this.btnLoadFilter.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFilter.TabIndex = 1;
            this.btnLoadFilter.Text = "&Load Filter";
            this.btnLoadFilter.UseVisualStyleBackColor = true;
            this.btnLoadFilter.Click += new System.EventHandler(this.btnLoadFilter_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(573, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Location = new System.Drawing.Point(573, 337);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(75, 23);
            this.btnAddFilter.TabIndex = 3;
            this.btnAddFilter.Text = "&Add Filter";
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click);
            // 
            // tbAddFilter
            // 
            this.tbAddFilter.Location = new System.Drawing.Point(573, 290);
            this.tbAddFilter.Name = "tbAddFilter";
            this.tbAddFilter.Size = new System.Drawing.Size(120, 20);
            this.tbAddFilter.TabIndex = 4;
            this.tbAddFilter.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAddFilter);
            this.Controls.Add(this.btnAddFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoadFilter);
            this.Controls.Add(this.lbSavedBongoFilters);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSavedBongoFilters;
        private System.Windows.Forms.Button btnLoadFilter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.TextBox tbAddFilter;
    }
}

