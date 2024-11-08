using System.Collections.Generic;

namespace CercleRoyalEscrimeTournaisien.Models
{
    public class ModelMainPage
    {
        public ModelMainPage()
        {
            CurrentVideo = 0;
        }

        public List<ClassVideo> VideoUrls 
        {
            get
            {
                return new List<ClassVideo>
                {
                    new ClassVideo() { Url = "https://www.youtube.com/embed/leOP7rWwBpw?enablejsapi=1", Title = "L'escrime" },
                    new ClassVideo() { Url = "https://www.youtube.com/embed/g-P_q5gdvRM?enablejsapi=1", Title = "Le fleuret" },
                    new ClassVideo() { Url = "https://www.youtube.com/embed/88mBQ2u2Wb0?enablejsapi=1", Title = "L'épée" },
                    new ClassVideo() { Url = "https://www.youtube.com/embed/4ipiJFlU_Dg?enablejsapi=1", Title = "Le sabre" },
                    new ClassVideo() { Url = "https://www.youtube.com/embed/BxU0YTpL464?enablejsapi=1", Title = "L'escrime vu par les lapins crétins" },
                };
            }
        }
        public int CurrentVideo { get; set; }
        public bool HasPubAlreadyShowed { get; set; }
    }

    public class ClassVideo
    {
        public ClassVideo()
        {
            Title = string.Empty;
            Url = string.Empty;
        }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
