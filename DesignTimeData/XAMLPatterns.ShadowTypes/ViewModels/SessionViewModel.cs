using System;
using System.Windows.Media;
using XAMLPatterns.ShadowTypes.Models;

namespace XAMLPatterns.ShadowTypes.ViewModels
{
    public class SessionViewModel
    {
        private readonly Session _session;
        private readonly ImageCache _imageCache;
        
        public SessionViewModel(Session session, ImageCache imageCache)
        {
            _session = session;
            _imageCache = imageCache;
        }

        public string Title
        {
            get { return _session.Title; }
        }

        public string Speaker
        {
            get { return _session.Speaker.Name; }
        }

        public ImageSource SpeakerImage
        {
            get { return _imageCache.GetImage(_session.Speaker); }
        }

        public DateTime Time
        {
            get { return _session.Time; }
        }

        public string Room
        {
            get { return "Room: " + _session.Room.Name; }
        }

        public string Description
        {
            get { return _session.Description; }
        }
    }
}
