namespace GUI {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.buttons_panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.save_button = new System.Windows.Forms.Button();
            this.compression_button = new System.Windows.Forms.Button();
            this.results_button = new System.Windows.Forms.Button();
            this.select_video_button = new System.Windows.Forms.Button();
            this.video_picture_box = new System.Windows.Forms.PictureBox();
            this.classification = new System.Windows.Forms.Label();
            this.buttons_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // buttons_panel
            // 
            this.buttons_panel.Controls.Add(this.pictureBox2);
            this.buttons_panel.Controls.Add(this.save_button);
            this.buttons_panel.Controls.Add(this.compression_button);
            this.buttons_panel.Controls.Add(this.results_button);
            this.buttons_panel.Controls.Add(this.select_video_button);
            this.buttons_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttons_panel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons_panel.Location = new System.Drawing.Point(953, 0);
            this.buttons_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttons_panel.Name = "buttons_panel";
            this.buttons_panel.Size = new System.Drawing.Size(257, 749);
            this.buttons_panel.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.nw;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // save_button
            // 
            this.save_button.FlatAppearance.BorderSize = 0;
            this.save_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Century Gothic", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.save_button.Image = global::GUI.Properties.Resources.Webp_net_resizeimage__10_;
            this.save_button.Location = new System.Drawing.Point(0, 579);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(257, 123);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Save\r\n";
            this.save_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.save_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // compression_button
            // 
            this.compression_button.FlatAppearance.BorderSize = 0;
            this.compression_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.compression_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compression_button.Font = new System.Drawing.Font("Century Gothic", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compression_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.compression_button.Image = global::GUI.Properties.Resources.Webp_net_resizeimage__8_;
            this.compression_button.Location = new System.Drawing.Point(0, 450);
            this.compression_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.compression_button.Name = "compression_button";
            this.compression_button.Size = new System.Drawing.Size(257, 123);
            this.compression_button.TabIndex = 3;
            this.compression_button.Text = "Compress\r\n";
            this.compression_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.compression_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.compression_button.UseVisualStyleBackColor = true;
            // 
            // results_button
            // 
            this.results_button.FlatAppearance.BorderSize = 0;
            this.results_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.results_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.results_button.Font = new System.Drawing.Font("Century Gothic", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.results_button.Image = global::GUI.Properties.Resources.Webp_net_resizeimage__7_;
            this.results_button.Location = new System.Drawing.Point(0, 321);
            this.results_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.results_button.Name = "results_button";
            this.results_button.Size = new System.Drawing.Size(257, 123);
            this.results_button.TabIndex = 2;
            this.results_button.Text = "Results\r\n";
            this.results_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.results_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.results_button.UseVisualStyleBackColor = true;
            // 
            // select_video_button
            // 
            this.select_video_button.FlatAppearance.BorderSize = 0;
            this.select_video_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.select_video_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_video_button.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_video_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.select_video_button.Image = global::GUI.Properties.Resources.Webp_net_resizeimage__9_;
            this.select_video_button.Location = new System.Drawing.Point(0, 192);
            this.select_video_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.select_video_button.Name = "select_video_button";
            this.select_video_button.Size = new System.Drawing.Size(257, 123);
            this.select_video_button.TabIndex = 1;
            this.select_video_button.Text = "Select Video";
            this.select_video_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.select_video_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.select_video_button.UseVisualStyleBackColor = true;
            this.select_video_button.Click += new System.EventHandler(this.select_video_Click);
            // 
            // video_picture_box
            // 
            this.video_picture_box.BackColor = System.Drawing.Color.Black;
            this.video_picture_box.Location = new System.Drawing.Point(1, 3);
            this.video_picture_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.video_picture_box.Name = "video_picture_box";
            this.video_picture_box.Size = new System.Drawing.Size(951, 746);
            this.video_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.video_picture_box.TabIndex = 0;
            this.video_picture_box.TabStop = false;
            this.video_picture_box.Resize += new System.EventHandler(this.video_picture_box_Resize);
            // 
            // classification
            // 
            this.classification.AutoSize = true;
            this.classification.BackColor = System.Drawing.Color.Transparent;
            this.classification.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classification.ForeColor = System.Drawing.SystemColors.Control;
            this.classification.Location = new System.Drawing.Point(716, 39);
            this.classification.Name = "classification";
            this.classification.Size = new System.Drawing.Size(160, 27);
            this.classification.TabIndex = 4;
            this.classification.Text = "classification";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1210, 749);
            this.Controls.Add(this.classification);
            this.Controls.Add(this.video_picture_box);
            this.Controls.Add(this.buttons_panel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.buttons_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button select_video_button;
        private System.Windows.Forms.Panel buttons_panel;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button compression_button;
        private System.Windows.Forms.Button results_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox video_picture_box;
        private System.Windows.Forms.Label classification;
    }
}

