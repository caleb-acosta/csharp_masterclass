using System;
using Timer = System.Timers.Timer;

namespace Inheritance
{
    internal class VideoPost:Post
    {
        protected string VideoURL { get; set; }
        protected int Length { get; set; }


        protected bool isPlaying = false;
        protected int duration = 0;
        private Timer _timer;

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}",
                this.ID, this.Title, this.VideoURL, this.Length, this.SendByUsername);
        }

        public void Play()
        {
            if (!isPlaying)
            {
                _timer = new Timer(1000);
                _timer.Elapsed += OnTimedEvent;
                _timer.Enabled = true;
            }
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e) {
            if (duration < Length)
            {
                duration++;
                Console.WriteLine("Video at {0}s", duration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop() {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", duration);
                duration = 0;
                _timer.Dispose();
            }
        }

    }
}
