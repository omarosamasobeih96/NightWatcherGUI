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
            this.classification = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.play_button = new System.Windows.Forms.Button();
            this.replay_button = new System.Windows.Forms.Button();
            this.pause_button = new System.Windows.Forms.Button();
            this.loading_picture_box = new System.Windows.Forms.PictureBox();
            this.video_picture_box = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.save_button = new System.Windows.Forms.Button();
            this.compression_button = new System.Windows.Forms.Button();
            this.results_button = new System.Windows.Forms.Button();
            this.select_video_button = new System.Windows.Forms.Button();
            this.buttons_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading_picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttons_panel
            // 
            this.buttons_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.buttons_panel.Controls.Add(this.pictureBox2);
            this.buttons_panel.Controls.Add(this.save_button);
            this.buttons_panel.Controls.Add(this.compression_button);
            this.buttons_panel.Controls.Add(this.results_button);
            this.buttons_panel.Controls.Add(this.select_video_button);
            this.buttons_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttons_panel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons_panel.Location = new System.Drawing.Point(961, 0);
            this.buttons_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttons_panel.Name = "buttons_panel";
            this.buttons_panel.Size = new System.Drawing.Size(249, 708);
            this.buttons_panel.TabIndex = 3;
            // 
            // classification
            // 
            this.classification.AutoSize = true;
            this.classification.BackColor = System.Drawing.Color.Transparent;
            this.classification.Font = new System.Drawing.Font("Century Gothic", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classification.ForeColor = System.Drawing.Color.White;
            this.classification.Location = new System.Drawing.Point(60, 58);
            this.classification.Name = "classification";
            this.classification.Size = new System.Drawing.Size(160, 27);
            this.classification.TabIndex = 8;
            this.classification.Text = "classification";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(0, 3);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(952, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.play_button);
            this.panel1.Controls.Add(this.replay_button);
            this.panel1.Controls.Add(this.pause_button);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(2, 559);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 190);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.Transparent;
            this.play_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_button.Image = global::GUI.Properties.Resources.Webp_net_resizeimage__15_;
            this.play_button.Location = new System.Drawing.Point(361, 54);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(75, 66);
            this.play_button.TabIndex = 13;
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // replay_button
            // 
            this.replay_button.BackColor = System.Drawing.Color.Transparent;
            this.replay_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.replay_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.replay_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replay_button.Image = global::GUI.Properties.Resources.Webp_net_resizeimage__11_;
            this.replay_button.Location = new System.Drawing.Point(523, 54);
            this.replay_button.Name = "replay_button";
            this.replay_button.Size = new System.Drawing.Size(75, 66);
            this.replay_button.TabIndex = 12;
            this.replay_button.UseVisualStyleBackColor = false;
            this.replay_button.Click += new System.EventHandler(this.replay_button_Click);
            // 
            // pause_button
            // 
            this.pause_button.BackColor = System.Drawing.Color.Transparent;
            this.pause_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.pause_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause_button.Image = global::GUI.Properties.Resources.Webp_net_resizeimage__16_;
            this.pause_button.Location = new System.Drawing.Point(442, 54);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(75, 66);
            this.pause_button.TabIndex = 11;
            this.pause_button.UseVisualStyleBackColor = false;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // loading_picture_box
            // 
            this.loading_picture_box.BackColor = System.Drawing.Color.Transparent;
            this.loading_picture_box.Image = global::GUI.Properties.Resources.loading;
            this.loading_picture_box.Location = new System.Drawing.Point(381, 254);
            this.loading_picture_box.Name = "loading_picture_box";
            this.loading_picture_box.Size = new System.Drawing.Size(205, 180);
            this.loading_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading_picture_box.TabIndex = 9;
            this.loading_picture_box.TabStop = false;
            this.loading_picture_box.Click += new System.EventHandler(this.loading_picture_box_Click);
            // 
            // video_picture_box
            // 
            this.video_picture_box.BackColor = System.Drawing.Color.Black;
            this.video_picture_box.Location = new System.Drawing.Point(12, 12);
            this.video_picture_box.Name = "video_picture_box";
            this.video_picture_box.Size = new System.Drawing.Size(942, 541);
            this.video_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.video_picture_box.TabIndex = 7;
            this.video_picture_box.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(2, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(966, 582);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.nw;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // save_button
            // 
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // compression_button
            // 
            this.compression_button.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.compression_button.Click += new System.EventHandler(this.compression_button_Click);
            // 
            // results_button
            // 
            this.results_button.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.results_button.Click += new System.EventHandler(this.results_button_Click);
            // 
            // select_video_button
            // 
            this.select_video_button.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1210, 708);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loading_picture_box);
            this.Controls.Add(this.classification);
            this.Controls.Add(this.video_picture_box);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttons_panel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.buttons_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading_picture_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_picture_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox video_picture_box;
		private System.Windows.Forms.PictureBox loading_picture_box;
		private System.Windows.Forms.Label classification;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.Button replay_button;
        private System.Windows.Forms.Button play_button;
    }
}

