using System;

namespace DeploymentToolbox.TextUtils
{
    /// <summary>
    /// Simple text helper operations used by the main application.
    /// This class lives in its own Class Library project so it compiles
    /// to its own file, DeploymentToolbox.TextUtils.dll - the second
    /// external DLL dependency the WiX installer needs to package for
    /// the Distinction level of Task 1.
    /// </summary>
    public static class StringTools
    {
        public static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static int WordCount(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            return input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
