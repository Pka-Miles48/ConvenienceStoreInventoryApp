using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenienceStoreInventoryApp
{
    static class Validator
    {
        /// <summary>
        /// Checks if the Textbox Text property
        /// has a non-empty, non-whitespace string
        /// </summary>
        /// <param name="box">The textbox to validate</param>
        /// <returns>True if textbox contains non_whitespace data</returns>
        public static bool IsPresent(TextBox box)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                return false;
            }
            return true;
        }
    }
}
