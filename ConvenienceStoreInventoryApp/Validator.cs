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
        public static double ValidNumberInTextbox(TextBox box)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                return 0;
            }
            return Convert.ToDouble(box);
        }

        public static bool ValidTextInput (string name, double price, double quantity, string category, string description)
        {
            if (name == null)
            {
                MessageBox.Show("Enter a valid Product Name.");
                return false;
            }
            else if (price <= 0)
            {
                MessageBox.Show("Enter a valid or non negative Product Price.");
                return false;
            }
            else if (quantity <= 0)
            {
                MessageBox.Show("Enter a valid of non negative quantity.");
                return false;
            }
            else if (category == null)
            {
                MessageBox.Show("Enter a valid category name.");
                return false;
            }

            else if (description == null)
            {
                MessageBox.Show("Enter a valid description.");
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
