using System;

namespace ProcessStringRC
{
    public class ProcessString
    {
        /// <summary>
        /// Main entry function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Print  greeting and instructions
            Console.WriteLine("Lets begin!");
            string userInput = "";
            while (userInput != "exit")
            {
                //Ask user to type string
                userInput = Console.ReadLine();
                if (userInput != "exit")
                {
                    ProcessString processString = new ProcessString();
                    processString.FormatString(userInput, out string outputVal);
                    Console.WriteLine($"Processed string is:{outputVal}");
                }
            }
        }


        /// <summary>
        /// this method is used to format input string
        /// </summary>
        /// <param name="inputVal">string input by user </param>
        /// <param name="processedVal">output paramter that contains processed string</param>
        public void FormatString(string inputVal, out string processedVal)
        {
            // strip out Contigous duplicate characters in same case to single char in same case
            processedVal = RemoveContigousDuplicates(inputVal);

            if (processedVal.Length >= 1)
            {
                // Replace $ with £
                processedVal = processedVal.Replace("$", "£");

                // strip out underscore(_)
                processedVal = processedVal.Length > 1? processedVal.Replace("_", ""): processedVal;

                // strip out number 4
                processedVal = processedVal.Length > 1 ? processedVal.Replace("4", "") : processedVal;

                // Truncate string to maxlength 15
                var maxlength = 15;
                processedVal = processedVal.Length <= maxlength ? processedVal : processedVal.Substring(0, maxlength);
            }
        }

        /// <summary>
        /// Method to remove duplicates that are contigous in same case.
        /// </summary>
        /// <param name="input">this is input string passed</param>
        /// <returns></returns>
        public static string RemoveContigousDuplicates(string input)
        {
            if (input.Length <= 1)
                return input;
            if (input[0] == input[1])
                return RemoveContigousDuplicates(input.Substring(1));
            else
                return input[0] + RemoveContigousDuplicates(input.Substring(1));
        }
    }
}
