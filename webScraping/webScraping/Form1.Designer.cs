namespace webScraping
{
    partial class fmWebScraping
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
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.buSearch = new System.Windows.Forms.Button();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.laSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(127, 97);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(553, 154);
            this.dgvResult.TabIndex = 0;
            // 
            // buSearch
            // 
            this.buSearch.Location = new System.Drawing.Point(127, 296);
            this.buSearch.Name = "buSearch";
            this.buSearch.Size = new System.Drawing.Size(75, 23);
            this.buSearch.TabIndex = 1;
            this.buSearch.Text = "Buscar";
            this.buSearch.UseVisualStyleBackColor = true;
            this.buSearch.Click += new System.EventHandler(this.buSearch_Click);
            // 
            // txSearch
            // 
            this.txSearch.Location = new System.Drawing.Point(299, 50);
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(268, 22);
            this.txSearch.TabIndex = 2;
            // 
            // laSearch
            // 
            this.laSearch.AutoSize = true;
            this.laSearch.Location = new System.Drawing.Point(124, 53);
            this.laSearch.Name = "laSearch";
            this.laSearch.Size = new System.Drawing.Size(159, 17);
            this.laSearch.TabIndex = 3;
            this.laSearch.Text = "Enter the text to search:";
            // 
            // fmWebScraping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laSearch);
            this.Controls.Add(this.txSearch);
            this.Controls.Add(this.buSearch);
            this.Controls.Add(this.dgvResult);
            this.Name = "fmWebScraping";
            this.Text = "Web Scraping";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button buSearch;
        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.Label laSearch;
    }
}

