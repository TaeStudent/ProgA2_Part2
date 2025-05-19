using System;
using System.Runtime.InteropServices;
using NAudio.Wave;

class AudioWelcome
{
    public static void PlayGreeting()
    {
        // First path to the file (assuming welcome.wav is in the project folder)
        string primaryPath = @"Prog_Part1\welcome.wav";
        // Second path to the file (assuming welcome.wav is in the bin directory)
        string fallbackPath = @"C:\Users\RC_Student_lab\source\repos\Prog_Part1\welcome.wav";

        // Attempt to play from the first path, if it fails, try the fallback path
        string[] paths = { primaryPath, fallbackPath };

        foreach (string filePath in paths)
        {
            if (System.IO.File.Exists(filePath))
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    try
                    {
                        using (WaveOutEvent outputDevice = new WaveOutEvent())
                        using (AudioFileReader audioFile = new AudioFileReader(filePath))
                        {
                            outputDevice.Init(audioFile);
                            outputDevice.Play();

                            while (outputDevice.PlaybackState == PlaybackState.Playing)
                            {
                                System.Threading.Thread.Sleep(100);
                            }
                        }
                        Console.WriteLine($"Audio played successfully from: {filePath}");
                        break; // Exit loop once audio is successfully played
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error playing audio from {filePath}: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Audio playback is only supported on Windows at the moment.");
                }
            }
            else
            {
                Console.WriteLine($"Audio file not found at {filePath}");
            }
        }
    }
}
