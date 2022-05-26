namespace FileFingerprint
{
    public static class ErrorCodes
    {
        public enum Code
        {
            ARGS_ERROR,
            IO_ERROR
        }

        public static int Winows(Code code)
        {
            if (code == Code.ARGS_ERROR)
            {
                return 0xA0;
            }
            else if (code == Code.IO_ERROR)
            {
                return 0x1D;
            }
            else
            {
                return 1;
            }
        }

        public static int Linux(Code code)
        {
            if (code == Code.ARGS_ERROR)
            {
                return 22;
            }
            else if (code == Code.IO_ERROR)
            {
                return 5;
            }
            else
            {
                return 1;
            }
        }

        public static int Mac(Code code)
        {
            if (code == Code.ARGS_ERROR)
            {
                return -3221;
            }
            else if (code == Code.IO_ERROR)
            {
                return -20;
            }
            else
            {
                return 1;
            }
        }
    }
}
