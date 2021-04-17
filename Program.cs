using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = "";
            var isWindows=System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            Console.WriteLine("                    https://t.me/zoomermorb");
            Console.WriteLine("                    https://groyper.me");
            Console.WriteLine("Date of VOD YYYY-MM-DD");
            date = Console.ReadLine();
            if(isWindows)
            {
                Console.WriteLine("ok i download " + date + " VOD now :D\n");
                System.Diagnostics.Process process = new System.Diagnostics.Process();
			    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			    startInfo.FileName = "yt-dlp.exe";
			    startInfo.Arguments = "-i --prefer-ffmpeg --merge-output-format mp4 --add-metadata --write-thumbnail --verbose --force-ipv4 --ignore-errors --no-continue --no-overwrites --embed-thumbnail -o " + date + " --no-check-certificate --force-generic-extractor https://cdn2.foxtrotstream.xyz/vod_local/af/" + date + "/index.m3u8";
			    process.StartInfo = startInfo;
			    process.Start();
            }
            else
            {
                Console.WriteLine("copy and paste this line into your terminal vvv (must have yt-dlp and ffmpeg installed)");
                Console.WriteLine("yt-dlp -i --prefer-ffmpeg --merge-output-format mp4 --add-metadata --write-thumbnail --verbose --force-ipv4 --ignore-errors --no-continue --no-overwrites --embed-thumbnail --no-check-certificate --force-generic-extractor https://cdn2.foxtrotstream.xyz/vod_local/af/" + date + "/index.m3u8");
            }
			Console.ReadLine();
			Environment.Exit(0);
        }
    }
}