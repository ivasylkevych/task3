// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace ParseJsonInterface
{
    /// <summary>
    /// The main class for running parser.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Runs parser.
        /// </summary>
        /// <param name="args">
        /// Basic parameter for main method.
        /// </param>
        static void Main(string[] args)
        {
            ParseJsonInterface parser = new ParseJsonInterface();
            parser.ParseJson("JSON.json");
        }
    }
}
