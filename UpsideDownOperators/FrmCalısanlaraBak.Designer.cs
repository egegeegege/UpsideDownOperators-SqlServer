namespace UpsideDownOperators
{
    partial class FrmCalısanlaraBak
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
            this.dgv_PersonelListesi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PersonelListesi
            // 
            this.dgv_PersonelListesi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_PersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PersonelListesi.Location = new System.Drawing.Point(140, 115);
            this.dgv_PersonelListesi.Name = "dgv_PersonelListesi";
            this.dgv_PersonelListesi.Size = new System.Drawing.Size(806, 431);
            this.dgv_PersonelListesi.TabIndex = 0;
            this.dgv_PersonelListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PersonelListesi_CellContentClick);
            this.dgv_PersonelListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_PersonelListesi_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(451, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personeller";
            // 
            // FrmCalısanlaraBak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_PersonelListesi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.29F);
            this.Name = "FrmCalısanlaraBak";
            this.Text = "FrmCalısanlaraBak";
            this.Load += new System.EventHandler(this.FrmCalısanlaraBak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PersonelListesi;
        private System.Windows.Forms.Label label1;
    }
}