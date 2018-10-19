namespace DieuChinhEHostpital
{
    partial class SaveBenhAn
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
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            this.bFix = new System.Windows.Forms.Button();
            this.bShow = new System.Windows.Forms.Button();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bFix
            // 
            this.bFix.Enabled = false;
            this.bFix.Location = new System.Drawing.Point(464, 297);
            this.bFix.Name = "bFix";
            this.bFix.Size = new System.Drawing.Size(112, 45);
            this.bFix.TabIndex = 0;
            this.bFix.Text = "Điều chỉnh";
            this.bFix.UseVisualStyleBackColor = true;
            this.bFix.Click += new System.EventHandler(this.bFix_Click);
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(279, 297);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(112, 45);
            this.bShow.TabIndex = 1;
            this.bShow.Text = "Xem Data";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // ultraGrid1
            // 
            appearance13.BackColor = System.Drawing.Color.White;
            appearance13.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal;
            this.ultraGrid1.DisplayLayout.Appearance = appearance13;
            this.ultraGrid1.DisplayLayout.InterBandSpacing = 10;
            this.ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance14;
            this.ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            appearance15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance15.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance15.ForeColor = System.Drawing.Color.Black;
            appearance15.TextHAlignAsString = "Left";
            appearance15.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance15;
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle;
            appearance16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.ultraGrid1.DisplayLayout.Override.RowAppearance = appearance16;
            appearance17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance17.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGrid1.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraGrid1.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement;
            this.ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid1.DisplayLayout.Override.RowSelectorWidth = 24;
            appearance18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance18.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance18.ForeColor = System.Drawing.Color.Black;
            this.ultraGrid1.DisplayLayout.Override.SelectedRowAppearance = appearance18;
            this.ultraGrid1.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.ultraGrid1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ultraGrid1.Location = new System.Drawing.Point(6, 25);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(830, 255);
            this.ultraGrid1.TabIndex = 2;
            this.ultraGrid1.Text = "ĐIỀU CHỈNH BUG: Không save được bệnh án";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(866, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ultraGrid1);
            this.groupBox1.Controls.Add(this.bFix);
            this.groupBox1.Controls.Add(this.bShow);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 362);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "EHospital Bug Fixing ";
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFix;
        private System.Windows.Forms.Button bShow;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

