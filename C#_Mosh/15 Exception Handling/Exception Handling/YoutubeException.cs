﻿using System.Runtime.Serialization;

namespace Exception_Handling
{
    public class YoutubeException : Exception
    {
        public YoutubeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
