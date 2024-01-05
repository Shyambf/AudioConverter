
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Converter
{
    internal class Converter
    {   
        public Converter() { }
        public void convert(string output, string file_name)
        {
            int type = 0;
            if (output == "amr") type = 1;
            else if (output == "ogg") type = 2;
            else type = 0;
            universal(file_name, output, type);
        }

        private void universal(string filenames, string output, int type)
        {
            Process process;
            process = new Process();
            process.StartInfo.FileName = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\ffmpeg\ffmpeg.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            string output_file_name = $"{filenames.Substring(0, filenames.Length - 4)}.{output}".Replace("..", ".");
            switch (type)
            {
                case 0:
                    process.StartInfo.Arguments = $"-y -i {filenames} {output_file_name}";
                    break;
                case 1:
                    process.StartInfo.Arguments = $"-y -i {filenames} -ar 8000 -ac 1 {output_file_name}";
                    break;
                case 2:
                    process.StartInfo.Arguments = $"-y -i {filenames} -c:a libvorbis -q:a 4 {output_file_name}";
                    break;

            }
            process.Start();
            while (process.HasExited == false)
            {
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}
