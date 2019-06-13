using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace GUI {
	public partial class Form1 : Form {

		private const int FRAMES_PER_SEGMENT = 16;
		private const int SEGMENTS_PER_FILE = 32;
		private VideoCapture capture = null;
		private bool is_playing = false;
		private int frame_count;
		private int running_frame_index;
		private int frame_rate;
		private Mat running_frame;
		private Mat frame;
		private bool[] predictions;
		private double[] val_predictions;
		private int segment_size;
		private int running_segment_index;
        private const double THRESHOLD = 0.5;
        private const string ANOMALY = "Anomaly";
        private const string NORMAL = "Normal";
        private float x_ratio;
        private float y_ratio;
        Rectangle select_video_button_rect;
        Rectangle results_video_button_rect;
        Rectangle compress_video_button_rect;
        Rectangle save_video_button_rect;
        Rectangle buttons_panel_rect;
        Rectangle video_picture_box_rect;
        Rectangle classification_label_rect;
        Size form_original_size;
        private void ProcessFrame(object sender, EventArgs e) {
			if (capture != null && capture.Ptr != IntPtr.Zero) {
				capture.Retrieve(frame, 0);
				video_picture_box.Image = frame.Bitmap;
			}
		}

		private async void play_video() {
			if (capture == null) return;
			capture.ImageGrabbed += ProcessFrame;
			frame = new Mat();
			try {
				while (is_playing == true && running_frame_index < frame_count) {
					capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, running_frame_index);
					capture.Read(running_frame);
					video_picture_box.Image = running_frame.Bitmap;

					if (predictions[running_segment_index])
                    {
						//classification.Text = ANOMALY;
						classification.Text = ANOMALY + "\n" + (1 + running_segment_index).ToString() + " " + val_predictions[running_segment_index].ToString();
						classification.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
						//classification.Text = NORMAL;
						classification.Text = NORMAL + "\n" + (1 + running_segment_index).ToString() + " " + val_predictions[running_segment_index].ToString();
                        classification.ForeColor = System.Drawing.Color.Green;
                   
                    }
					// await Task.Delay(350);
					await Task.Delay(1000 / frame_rate);
					running_frame_index += 1;
					if (running_frame_index % FRAMES_PER_SEGMENT == 0) running_segment_index += 1;
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private String get_prediction_filename(String video_filename) {
			String prediction_filename = "";
			int len = video_filename.Length;
			for(int i = len - 1; i >= 0; --i) {
				if(video_filename[i] == '.') {
					for (int j = 0; j < i; ++j)
						prediction_filename += video_filename[j];
					break;
				}
			}
			return prediction_filename;
		}

		public Form1() {
			InitializeComponent();
            classification.Visible = false;
            
            classification.Parent = video_picture_box;
         
            classification.BackColor = Color.Transparent;
        }

		private void select_video_Click(object sender, EventArgs e) {
			classification.Visible = false;
			is_playing = false;
			OpenFileDialog open_file_dialogue = new OpenFileDialog();
			open_file_dialogue.Filter = "Video Files (*.mp4, *.flv)| *.mp4;*.flv";
			if (open_file_dialogue.ShowDialog() == DialogResult.OK) {
				capture = new VideoCapture(open_file_dialogue.FileName);
				frame_count = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount));
				segment_size = (frame_count + SEGMENTS_PER_FILE - 1) / SEGMENTS_PER_FILE;
				frame_rate = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps));
				is_playing = true;
				running_frame = new Mat();
				running_frame_index = 0;
				running_segment_index = 0;

				String prediction_filename = get_prediction_filename(open_file_dialogue.FileName);
				int segments_cnt = (frame_count + FRAMES_PER_SEGMENT - 1) / FRAMES_PER_SEGMENT;
				int files_cnt = (segments_cnt + SEGMENTS_PER_FILE - 1) / SEGMENTS_PER_FILE;
				predictions = new bool[segments_cnt];
				val_predictions = new double[segments_cnt];
				int al = 0;
				for (int file_it = 0; file_it < files_cnt; ++file_it) {
					String[] reader = System.IO.File.ReadAllLines(prediction_filename + "/" + file_it.ToString() + "_C.mat");
					for (int i = 0; al < segments_cnt && i < SEGMENTS_PER_FILE; ++i) {
						if (file_it + 1 == files_cnt && i > 0 && Convert.ToDouble(reader[i]) == Convert.ToDouble(reader[i - 1]))
							continue;
						val_predictions[al] = Convert.ToDouble(reader[i]);
						predictions[al] = val_predictions[al] > THRESHOLD;
						al++;
					}
				}
				for(int i = 0; i < segments_cnt; ++i) {
					bool cur = predictions[i];
					bool pre = cur, nxt = cur;
					if (i > 0 && predictions[i - 1] != cur) pre = !pre;
					if (i + 1 < predictions.Length && predictions[i + 1] != cur) nxt = !nxt;
					if (cur != pre && cur != nxt) predictions[i] = !cur;
				}
				play_video();
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            form_original_size = this.Size;
            select_video_button_rect = new Rectangle(select_video_button.Location.X, select_video_button.Location.Y, select_video_button.Width, select_video_button.Height);
            results_video_button_rect = new Rectangle(results_button.Location.X, results_button.Location.Y,  results_button.Width, results_button.Height);
            compress_video_button_rect = new Rectangle(compression_button.Location.X, compression_button.Location.Y, compression_button.Width, compression_button.Height);
            save_video_button_rect = new Rectangle(save_button.Location.X, save_button.Location.Y, save_button.Width, save_button.Height);
            buttons_panel_rect = new Rectangle(buttons_panel.Location.X, buttons_panel.Location.Y, buttons_panel.Width, buttons_panel.Height);
            video_picture_box_rect = new Rectangle(video_picture_box.Location.X, video_picture_box.Location.Y, video_picture_box.Width, video_picture_box.Height);
            classification_label_rect = new Rectangle(classification.Location.X, classification.Location.Y, classification.Width, classification.Height);
        }

        private void classification_Click(object sender, EventArgs e)
        {

        }

        private void resize_children()
        {
             x_ratio = (float)this.Width / (float)form_original_size.Width;
             y_ratio = (float)this.Height / (float)form_original_size.Height;
            resize_control(select_video_button_rect, select_video_button);
            
            resize_control(results_video_button_rect, results_button);
            resize_control(compress_video_button_rect, compression_button);
            resize_control(save_video_button_rect, save_button);
            resize_control(buttons_panel_rect, buttons_panel);
            resize_control(video_picture_box_rect, video_picture_box);
            resize_control(classification_label_rect, classification);
        }
        private void resize_control(Rectangle rect, Control control)
        {
            
            int new_x = (int)(rect.X * x_ratio);
            int new_y = (int)(rect.Y * y_ratio);
            int new_width = (int)(rect.Width * x_ratio);
            int new_height = (int)(rect.Height * y_ratio);
            control.Location = new Point(new_x, new_y);
            control.Size = new Size(new_width, new_height);
           
            
        }

        private void video_picture_box_Resize(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_children();
        }

		private void results_button_Click(object sender, EventArgs e) {
			classification.Visible = true;
			running_frame_index = 0;
			running_segment_index = 0;
		}
	}
}
