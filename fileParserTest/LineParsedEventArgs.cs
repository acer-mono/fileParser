using System;

namespace fileParserTest
{
    public class BlockParsedEventArgs : EventArgs
    {
        public readonly int lineSize;

        public BlockParsedEventArgs(int size)
        {
            lineSize = size;
        }
    }
}
