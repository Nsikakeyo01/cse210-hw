// Author: Nsikak Eyo
// Location: Uyo, Akwa Ibom State, Nigeria
// Represents a personal comment on a YouTube video

namespace NsikakYouTubeApp
{
    public class VideoComment
    {
        private string _commenterName;
        private string _commentText;

        public VideoComment(string commenterName, string commentText)
        {
            _commenterName = commenterName;
            _commentText = commentText;
        }

        public string CommenterName { get { return _commenterName; } }
        public string CommentText { get { return _commentText; } }

        public void ShowComment()
        {
            Console.WriteLine($"💬 {CommenterName} says: \"{CommentText}\"");
        }
    }
}
