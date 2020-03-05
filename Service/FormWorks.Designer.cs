﻿namespace Laundry
{
    partial class FormWorks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorks));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolbtnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbtnComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbtnIncomplete = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.toolbtnSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnRefresh,
            this.toolbtnComplete,
            this.toolbtnIncomplete,
            this.tooltxtSearch,
            this.toolbtnSearch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1212, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolbtnRefresh
            // 
            this.toolbtnRefresh.Name = "toolbtnRefresh";
            this.toolbtnRefresh.Size = new System.Drawing.Size(72, 23);
            this.toolbtnRefresh.Text = "بروز رسانی";
            this.toolbtnRefresh.Click += new System.EventHandler(this.toolbtnRefresh_Click);
            // 
            // toolbtnComplete
            // 
            this.toolbtnComplete.Name = "toolbtnComplete";
            this.toolbtnComplete.Size = new System.Drawing.Size(104, 23);
            this.toolbtnComplete.Text = "کارهای انجام شده";
            this.toolbtnComplete.Click += new System.EventHandler(this.toolbtnComplete_Click);
            // 
            // toolbtnIncomplete
            // 
            this.toolbtnIncomplete.Name = "toolbtnIncomplete";
            this.toolbtnIncomplete.Size = new System.Drawing.Size(108, 23);
            this.toolbtnIncomplete.Text = "کارهای انجام نشده";
            this.toolbtnIncomplete.Click += new System.EventHandler(this.toolbtnIncomplete_Click);
            // 
            // tooltxtSearch
            // 
            this.tooltxtSearch.Name = "tooltxtSearch";
            this.tooltxtSearch.Size = new System.Drawing.Size(100, 23);
            this.tooltxtSearch.Enter += new System.EventHandler(this.tooltxtSearch_Enter);
            this.tooltxtSearch.TextChanged += new System.EventHandler(this.tooltxtSearch_TextChanged);
            // 
            // dgSearch
            // 
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSearch.Location = new System.Drawing.Point(0, 27);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgSearch.Size = new System.Drawing.Size(1212, 542);
            this.dgSearch.TabIndex = 1;
            // 
            // toolbtnSearch
            // 
            this.toolbtnSearch.Name = "toolbtnSearch";
            this.toolbtnSearch.Size = new System.Drawing.Size(53, 23);
            this.toolbtnSearch.Text = "جستجو";
            this.toolbtnSearch.Click += new System.EventHandler(this.toolbtnSearch_Click);
            // 
            // FormWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 569);
            this.Controls.Add(this.dgSearch);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormWorks";
            this.Text = "کارها";
            this.Load += new System.EventHandler(this.FormWorks_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolbtnRefresh;
        private System.Windows.Forms.ToolStripMenuItem toolbtnComplete;
        private System.Windows.Forms.ToolStripMenuItem toolbtnIncomplete;
        private System.Windows.Forms.ToolStripTextBox tooltxtSearch;
        private System.Windows.Forms.DataGridView dgSearch;
        private System.Windows.Forms.ToolStripMenuItem toolbtnSearch;
    }
}