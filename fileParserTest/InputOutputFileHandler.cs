using System;
using System.IO;
using System.Threading.Tasks;

namespace fileParserTest
{
    public class InputOutputFileHandler
    {
        private const int BlockSize = 128;
        private readonly StringParser stringParser;
        public event EventHandler<BlockParsedEventArgs> BlockParsed;
        public event EventHandler<FileOpenedEventArgs> FileOpened;

        public InputOutputFileHandler(uint minWordLength, bool removePunctuation)
        {
            stringParser = new StringParser(minWordLength, removePunctuation);
        }

        public async Task<bool> Handle(string inputPath, string outputPath)
        {
            EnsureFilesExist(new[] { inputPath, outputPath });

            using (StreamReader sr = new StreamReader(inputPath))
            {
                FileInfo fileInfo = new FileInfo(inputPath);

                FileOpened?.Invoke(this, new FileOpenedEventArgs((int) fileInfo.Length));

                using (StreamWriter sw = new StreamWriter(outputPath))
                {
                    char[] block = new char[BlockSize];
                    int blockStatus = 0;

                    while ((blockStatus = await sr.ReadBlockAsync(block, 0, block.Length)) >= 0)
                    {
                        string output = stringParser.Parse(block, blockStatus == 0);

                        if (output != "")
                        {
                            await sw.WriteAsync(output);
                        }

                        BlockParsed?.Invoke(this, new BlockParsedEventArgs(BlockSize * sizeof(char)));

                        Array.Clear(block, 0, block.Length);

                        if (blockStatus == 0)
                        {
                            break;
                        }
                    }
                }
            }

            return true;
        }

        private static void EnsureFilesExist(string[] paths)
        {
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException($"File {path} not found");
                }
            }
        }
    }
}
