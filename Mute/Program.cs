using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Threading;

namespace Mute
{
    class Program
    {
        static void Main(string[] args)
        {
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            defaultPlaybackDevice.Mute(true);
            Console.WriteLine($"Muted: {defaultPlaybackDevice.IsMuted}");
            Thread.Sleep(60000);
            defaultPlaybackDevice.Mute(false);
            Console.WriteLine($"Muted: {defaultPlaybackDevice.IsMuted}");
        }
    }
}
