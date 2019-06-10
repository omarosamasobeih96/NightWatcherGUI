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

		private VideoCapture capture = null;
		private bool is_playing = false;
		private int frame_count;
		private int running_frame_index;
		private int frame_rate;
		private Mat running_frame;
		private Mat frame;
		private double[] predictions;
		private int segment_size;
		private int running_segment_index;

		private void ProcessFrame(object sender, EventArgs e) {
			if (capture != null && capture.Ptr != IntPtr.Zero) {
				capture.Retrieve(frame, 0);
				pictureBox1.Image = frame.Bitmap;
			}
		}

		private async void play_video() {
			if (capture == null) return;
			capture.ImageGrabbed += ProcessFrame;
			frame = new Mat();
			try {
				while (is_playing == true && running_frame_index < frame_count) {
					if (running_frame_index == segment_size * (1 + running_segment_index)) running_segment_index += 1;
					capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, running_frame_index);
					capture.Read(running_frame);
					pictureBox1.Image = running_frame.Bitmap;
					running_frame_index += 1;
					classification.Text = predictions[running_segment_index].ToString();
					await Task.Delay(500 / frame_rate);
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
			return prediction_filename + ".mat";
		}

		public Form1() {
			InitializeComponent();
		}

		private void select_video_Click(object sender, EventArgs e) {
			is_playing = false;
			OpenFileDialog open_file_dialogue = new OpenFileDialog();
			open_file_dialogue.Filter = "Video Files (*.mp4, *.flv)| *.mp4;*.flv";
			if (open_file_dialogue.ShowDialog() == DialogResult.OK) {
				String prediction_filename = get_prediction_filename(open_file_dialogue.FileName);
				String[] reader = System.IO.File.ReadAllLines(prediction_filename);
				predictions = new double[32];
				for (int i = 0; i < 32; ++i) predictions[i] = Convert.ToDouble(reader[i]);
				capture = new VideoCapture(open_file_dialogue.FileName);
				frame_count = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount));
				segment_size = (frame_count + 31) / 32;
				frame_rate = Convert.ToInt32(capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps));
				is_playing = true;
				running_frame = new Mat();
				running_frame_index = 0;
				running_segment_index = 0;
				play_video();
			}
		}
	}
}
