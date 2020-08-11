using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileParserTest
{
    public class FileOpenedEventArgs : EventArgs
    {
        public readonly int fileSize;

        public FileOpenedEventArgs(int size)
        {
            fileSize = size;
        }
    }
}
