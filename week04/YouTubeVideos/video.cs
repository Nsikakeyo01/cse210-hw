// Author: Nsikak Eyo
// Location: Uyo, Akwa Ibom State, Nigeria
// Represents a YouTube video with personal flair

using System;
using System.Collections.Generic;

namespace NsikakYouTubeApp
{
    public class MyVideo
    {
        private string _videoTitle;
        private string _videoAuthor;
        private int _durationSeconds;
        private List<VideoComment> _myComments;

        public MyVideo(string videoTitle, string videoAuthor, int durationSeconds)
        {
            _videoTitle = videoTitle;
            _videoAuthor = videoAuthor;
            _durationSeconds = durationSeconds;
            _myComments = new List<VideoComment>();
        }

        public string VideoTitle { get { return _videoTitle; } }
        public string VideoAuthor { get { return _videoAuthor; } }

        public void AddComment(VideoComment comment)
        {
            _myComments.Add(comment);
        }

        public int GetTotalComments()
        {
            return _myComments.Count;
        }

        public void DisplayVideoDetails()
        {
            Console.WriteLine($"\n🎥 Video: {_videoTitle}");
            Console.WriteLine($"🧑‍💻 By: {_videoAuthor}");
            Console.WriteLine($"⏱ Length: {_durationSeconds} seconds");
            Console.WriteLine($"📝 Total Comments: {GetTotalComments()}");
            foreach (var c in _myComments)
            {
                c.ShowComment();
            }
        }
    }
}
