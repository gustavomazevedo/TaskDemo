namespace TaskDemo
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
            this.imgCover = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtResultJSON = new System.Windows.Forms.TextBox();
            this.btnSearchAsync = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCover)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCover
            // 
            this.imgCover.Location = new System.Drawing.Point(706, 12);
            this.imgCover.Name = "imgCover";
            this.imgCover.Size = new System.Drawing.Size(183, 175);
            this.imgCover.TabIndex = 0;
            this.imgCover.TabStop = false;
            this.imgCover.Click += new System.EventHandler(this.imgCover_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(552, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtResultJSON
            // 
            this.txtResultJSON.Location = new System.Drawing.Point(12, 187);
            this.txtResultJSON.Multiline = true;
            this.txtResultJSON.Name = "txtResultJSON";
            this.txtResultJSON.Size = new System.Drawing.Size(615, 312);
            this.txtResultJSON.TabIndex = 2;
            this.txtResultJSON.TextChanged += new System.EventHandler(this.txtResultJSON_TextChanged);
            // 
            // btnSearchAsync
            // 
            this.btnSearchAsync.Location = new System.Drawing.Point(540, 114);
            this.btnSearchAsync.Name = "btnSearchAsync";
            this.btnSearchAsync.Size = new System.Drawing.Size(86, 23);
            this.btnSearchAsync.TabIndex = 3;
            this.btnSearchAsync.Text = "SearchAsync";
            this.btnSearchAsync.UseVisualStyleBackColor = true;
            this.btnSearchAsync.Click += new System.EventHandler(this.btnSearchAsync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 511);
            this.Controls.Add(this.btnSearchAsync);
            this.Controls.Add(this.txtResultJSON);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.imgCover);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCover;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtResultJSON;
        private System.Windows.Forms.Button btnSearchAsync;
    }
}

