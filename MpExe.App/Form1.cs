using NAudio.Wave;
using System;
using System.Windows.Forms;
using NAudio.Wave.SampleProviders;
using System.Drawing.Drawing2D;

namespace MpExe.APP
{


    public partial class Form1 : Form
    {
        private IWavePlayer waveOut;
        private AudioFileReader audioFileReader;
        private bool isPlaying = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "MP3 Files|*.mp3|WAV Files|*.wav";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    audioFileReader = new AudioFileReader(openFileDialog.FileName);
                    waveOut = new WaveOutEvent();
                    waveOut.Init(audioFileReader);

                    // TrackBar ayarları
                    trackBarPosition.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;
                    trackBarPosition.Value = 0;

                    // trackBarStart ve trackBarEnd ayarları
                    trackBarStart.Maximum = trackBarEnd.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;

                    numericUpStart.Maximum = numericUpEnd.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;

                    trackBarStart.Value = 0;
                    trackBarEnd.Value = (int)audioFileReader.TotalTime.TotalSeconds;

                    // Zamanı göstermek için bir timer oluşturuyoruz
                    timer = new Timer();
                    timer.Interval = 500; // Yarım saniyede bir güncellenir
                    timer.Tick += Timer_Tick;
                    timer.Start();

                    lblStart.Text = "Start: 00:00";
                    lblEnd.Text = "End: " + FormatTime(audioFileReader.TotalTime);
                    lblCurrentTime.Text = "00:00 / " + FormatTime(audioFileReader.TotalTime);
                    lblSelectedFile.Text = openFileDialog.SafeFileName;

                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (audioFileReader != null && isPlaying)
            {
                trackBarPosition.Value = (int)audioFileReader.CurrentTime.TotalSeconds;
                lblCurrentTime.Text = FormatTime(audioFileReader.CurrentTime) + " / " + FormatTime(audioFileReader.TotalTime);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (audioFileReader != null && !isPlaying)
            {
                waveOut.Play();
                isPlaying = true;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (audioFileReader != null && isPlaying)
            {
                waveOut.Pause();
                isPlaying = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                waveOut.Stop();
                isPlaying = false;
                audioFileReader.Position = 0; // Başa dön
                trackBarPosition.Value = 0;
                lblCurrentTime.Text = "00:00 / " + FormatTime(audioFileReader.TotalTime);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "WAV files (*.wav)|*.wav";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        TimeSpan startTime = TimeSpan.FromSeconds(trackBarStart.Value);
                        TimeSpan endTime = TimeSpan.FromSeconds(trackBarEnd.Value);

                        SaveAudioClip(saveFileDialog.FileName, startTime, endTime);
                    }
                }
            }
        }

        private void SaveAudioClip(string outputFilePath, TimeSpan startTime, TimeSpan endTime)
        {
            using (var reader = new AudioFileReader(audioFileReader.FileName))
            {
                reader.CurrentTime = startTime;
                using (var writer = new WaveFileWriter(outputFilePath, reader.WaveFormat))
                {
                    int bytesPerSecond = reader.WaveFormat.AverageBytesPerSecond;
                    long startPos = (long)startTime.TotalSeconds * bytesPerSecond;
                    long endPos = (long)endTime.TotalSeconds * bytesPerSecond;
                    reader.Position = startPos;
                    byte[] buffer = new byte[1024];
                    while (reader.Position < endPos)
                    {
                        int bytesRequired = (int)Math.Min(endPos - reader.Position, buffer.Length);
                        int bytesRead = reader.Read(buffer, 0, bytesRequired);
                        if (bytesRead == 0) break;
                        writer.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }

        private void trackBarPosition_Scroll(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(trackBarPosition.Value);
                lblCurrentTime.Text = FormatTime(audioFileReader.CurrentTime) + " / " + FormatTime(audioFileReader.TotalTime);
            }
        }

        private string FormatTime(TimeSpan time)
        {
            return string.Format("{0:D2}:{1:D2}", time.Minutes, time.Seconds);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Uygulama kapanırken kaynakları serbest bırakıyoruz
            waveOut?.Dispose();
            audioFileReader?.Dispose();
            timer?.Dispose();
        }

        private void trackBarStart_Scroll(object sender, EventArgs e)
        {
            lblStart.Text = "Start: " + FormatTime(TimeSpan.FromSeconds(trackBarStart.Value));
            numericUpStart.Value = trackBarStart.Value;
        }

        private void trackBarEnd_Scroll(object sender, EventArgs e)
        {
            numericUpEnd.Value = trackBarEnd.Value;
            lblEnd.Text = "End: " + FormatTime(TimeSpan.FromSeconds(trackBarEnd.Value));
        }

        private void numericUpStart_ValueChanged(object sender, EventArgs e)
        {
            trackBarStart.Value = (int)numericUpStart.Value;
            lblStart.Text = "Start: " + FormatTime(TimeSpan.FromSeconds(trackBarStart.Value));
        }
        private void numericUpStart_KeyUp(object sender, KeyEventArgs e)
        {
            trackBarStart.Value = (int)numericUpStart.Value;
            lblStart.Text = "Start: " + FormatTime(TimeSpan.FromSeconds(trackBarStart.Value));
        }
        private void numericUpEnd_ValueChanged(object sender, EventArgs e)
        {
            trackBarEnd.Value = (int)numericUpEnd.Value;
            lblEnd.Text = "End: " + FormatTime(TimeSpan.FromSeconds(trackBarEnd.Value));
        }

        private void numericUpEnd_KeyUp(object sender, KeyEventArgs e)
        {
            trackBarEnd.Value = (int)numericUpEnd.Value;
            lblEnd.Text = "End: " + FormatTime(TimeSpan.FromSeconds(trackBarEnd.Value));
        }

    }

}
