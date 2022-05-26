namespace FileFingerprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "File Fingerprint";
            Console.WriteLine("Welcome to File Fingerprint");
            Console.WriteLine("The future is in the skies.");
            Console.WriteLine();

            if (!args.Any())
            {
                ARGS_ERROR();
            }

            HtmlBuilder builder = new HtmlBuilder();

            foreach (string file in args)
            {
                FileInfo fi = new FileInfo(file);
                if (fi.Exists)
                {
                    string filename = fi.Name;
                    string filesize = FileSize.GetString(fi.Length);
                    string creation = fi.CreationTime.ToString();
                    string fingerprint = Fingerprint.GetHash(File.ReadAllBytes(fi.FullName));
                    builder.Add(new string[] { filename, filesize, creation, fingerprint });
                    Console.WriteLine();
                    Console.WriteLine("---------------");
                    Console.WriteLine("File Name: {0}", filename);
                    Console.WriteLine("Fingerprint: {0}", fingerprint);
                    Console.WriteLine("---------------");
                }
                else
                {
                    Error("File not found!: " + fi.Name);
                }
            }

            Console.WriteLine();
            question:
            Console.Write("Would you like to save the report?(y|n)");
            string? answer = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(answer))
            {
                if (answer.Equals("y") || answer.Equals("Y"))
                {
                    try
                    {
                        int i = 0;
                        bool save = true;
                        while (save)
                        {
                            if (!File.Exists("report" + i.ToString() + ".html"))
                            {
                                File.WriteAllText("report" + i.ToString() + ".html", builder.Build(), System.Text.Encoding.UTF8);
                                Console.WriteLine("File saved as {0}", Path.GetFullPath("report" + i.ToString() + ".html"));
                                save = false;
                            }
                            else
                            {
                                i++;
                            }
                        }
                        Exit(0);
                    }
                    catch (Exception ex)
                    {
                        IO_ERROR(ex);
                    }
                }
                else if (answer.Equals("n") || answer.Equals("N"))
                {
                    Exit(0);
                }
                else
                {
                    goto question;
                }
            }
            else
            {
                goto question;
            }
        }

        static void ARGS_ERROR()
        {
            Error("Empty argument error.");
            if (OperatingSystem.IsWindows())
            {
                Exit(ErrorCodes.Winows(ErrorCodes.Code.ARGS_ERROR));
            }
            else if (OperatingSystem.IsLinux())
            {
                Exit(ErrorCodes.Linux(ErrorCodes.Code.ARGS_ERROR));
            }
            else if (OperatingSystem.IsMacOS())
            {
                Exit(ErrorCodes.Mac(ErrorCodes.Code.ARGS_ERROR));
            }
            else
            {
                Exit(1);
            }
        }

        static void IO_ERROR(Exception exception)
        {
            Error("Error: " + exception.Message);
            if (OperatingSystem.IsWindows())
            {
                Exit(ErrorCodes.Winows(ErrorCodes.Code.IO_ERROR));
            }
            else if (OperatingSystem.IsLinux())
            {
                Exit(ErrorCodes.Linux(ErrorCodes.Code.IO_ERROR));
            }
            else if (OperatingSystem.IsMacOS())
            {
                Exit(ErrorCodes.Mac(ErrorCodes.Code.IO_ERROR));
            }
            else
            {
                Exit(1);
            }
        }

        static void Error(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        static void Exit(int ExitCode)
        {
            Console.Write("Press enter to exit...");
            Console.ReadLine();
            Environment.Exit(ExitCode);
        }
    }
}