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
            this.btnDeleteFilter = new System.Windows.Forms.Button();
            this.cboA = new System.Windows.Forms.ComboBox();
            this.cboB = new System.Windows.Forms.ComboBox();
            this.cboC = new System.Windows.Forms.ComboBox();
            this.cboD = new System.Windows.Forms.ComboBox();
            this.cboE = new System.Windows.Forms.ComboBox();
            this.cboF = new System.Windows.Forms.ComboBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
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
            this.btnLoadFilter.Location = new System.Drawing.Point(499, 375);
            this.btnLoadFilter.Name = "btnLoadFilter";
            this.btnLoadFilter.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFilter.TabIndex = 1;
            this.btnLoadFilter.Text = "&Load Filter";
            this.btnLoadFilter.UseVisualStyleBackColor = true;
            this.btnLoadFilter.Click += new System.EventHandler(this.btnLoadFilter_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(618, 375);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Location = new System.Drawing.Point(499, 326);
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
            // btnDeleteFilter
            // 
            this.btnDeleteFilter.Location = new System.Drawing.Point(618, 326);
            this.btnDeleteFilter.Name = "btnDeleteFilter";
            this.btnDeleteFilter.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFilter.TabIndex = 5;
            this.btnDeleteFilter.Text = "&Delete Filter";
            this.btnDeleteFilter.UseVisualStyleBackColor = true;
            this.btnDeleteFilter.Click += new System.EventHandler(this.btnDeleteFilter_Click);
            // 
            // cboA
            // 
            this.cboA.FormattingEnabled = true;
            this.cboA.Location = new System.Drawing.Point(66, 53);
            this.cboA.Name = "cboA";
            this.cboA.Size = new System.Drawing.Size(121, 21);
            this.cboA.TabIndex = 6;
            // 
            // cboB
            // 
            this.cboB.FormattingEnabled = true;
            this.cboB.Location = new System.Drawing.Point(66, 107);
            this.cboB.Name = "cboB";
            this.cboB.Size = new System.Drawing.Size(121, 21);
            this.cboB.TabIndex = 7;
            // 
            // cboC
            // 
            this.cboC.FormattingEnabled = true;
            this.cboC.Location = new System.Drawing.Point(66, 166);
            this.cboC.Name = "cboC";
            this.cboC.Size = new System.Drawing.Size(121, 21);
            this.cboC.TabIndex = 8;
            // 
            // cboD
            // 
            this.cboD.FormattingEnabled = true;
            this.cboD.Location = new System.Drawing.Point(235, 53);
            this.cboD.Name = "cboD";
            this.cboD.Size = new System.Drawing.Size(121, 21);
            this.cboD.TabIndex = 9;
            // 
            // cboE
            // 
            this.cboE.FormattingEnabled = true;
            this.cboE.Location = new System.Drawing.Point(235, 107);
            this.cboE.Name = "cboE";
            this.cboE.Size = new System.Drawing.Size(121, 21);
            this.cboE.TabIndex = 10;
            // 
            // cboF
            // 
            this.cboF.FormattingEnabled = true;
            this.cboF.Location = new System.Drawing.Point(235, 166);
            this.cboF.Name = "cboF";
            this.cboF.Size = new System.Drawing.Size(121, 21);
            this.cboF.TabIndex = 11;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(13, 53);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 12;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(13, 107);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 13;
            this.lblB.Text = "B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(12, 169);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(14, 13);
            this.lblC.TabIndex = 14;
            this.lblC.Text = "C";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(382, 53);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(15, 13);
            this.lblD.TabIndex = 15;
            this.lblD.Text = "D";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(382, 110);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(14, 13);
            this.lblE.TabIndex = 16;
            this.lblE.Text = "E";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(382, 169);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(13, 13);
            this.lblF.TabIndex = 17;
            this.lblF.Text = "F";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cboF);
            this.Controls.Add(this.cboE);
            this.Controls.Add(this.cboD);
            this.Controls.Add(this.cboC);
            this.Controls.Add(this.cboB);
            this.Controls.Add(this.cboA);
            this.Controls.Add(this.btnDeleteFilter);
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
        private System.Windows.Forms.Button btnDeleteFilter;
        private System.Windows.Forms.ComboBox cboA;
        private System.Windows.Forms.ComboBox cboB;
        private System.Windows.Forms.ComboBox cboC;
        private System.Windows.Forms.ComboBox cboD;
        private System.Windows.Forms.ComboBox cboE;
        private System.Windows.Forms.ComboBox cboF;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblF;
    }
}

