// Author: Nsikak Eyo
// Location: Uyo, Akwa Ibom State, Nigeria
// Main program for my unique YouTube Video Program

using System;
using NsikakYouTubeApp;

namespace NsikakYouTubeAppMain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create my personalized videos
            MyVideo video1 = new MyVideo("Nsikak's C# Adventures 🌍", "Nsikak Eyo", 430);
            MyVideo video2 = new MyVideo("Coding Life in Uyo 💻", "Nsikak Eyo", 520);
            MyVideo video3 = new MyVideo("Encapsulation Unlocked 🔑", "Nsikak Eyo", 460);
            MyVideo video4 = new MyVideo("Abstraction Made Simple ✨", "Nsikak Eyo", 380);

            // Add unique and culturally relevant comments
            video1.AddComment(new VideoComment("Ada", "This C# guide is amazing, Nsikak!"));
            video1.AddComment(new VideoComment("Chinedu", "Finally understood classes thanks to you!"));
            video1.AddComment(new VideoComment("Uduak", "Love seeing programming from Uyo!"));

            video2.AddComment(new VideoComment("Emmanuel", "Your examples are really practical!"));
            video2.AddComment(new VideoComment("Peace", "I appreciate the Nigerian references."));
            video2.AddComment(new VideoComment("Ini", "This helped me code my first small project."));

            video3.AddComment(new VideoComment("David", "Encapsulation now makes perfect sense!"));
            video3.AddComment(new VideoComment("Joy", "Can you explain polymorphism next?"));
            video3.AddComment(new VideoComment("Victor", "The examples are super easy to follow."));

            video4.AddComment(new VideoComment("Linda", "Abstraction finally clicks for me."));
            video4.AddComment(new VideoComment("Mark", "I like how unnecessary details are hidden."));
            video4.AddComment(new VideoComment("Esther", "The examples are so relatable!"));

            // Store videos in an array
            MyVideo[] myVideos = { video1, video2, video3, video4 };

            // Display details for each video
            foreach (var v in myVideos)
            {
                v.DisplayVideoDetails();
            }
        }
    }
}
