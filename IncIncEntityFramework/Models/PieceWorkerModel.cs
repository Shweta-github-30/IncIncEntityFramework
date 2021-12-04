//PieceWorkerModel.cs
//Author: Shweta Patel [Reference: Kyle chapman]
//created: November 20
//model to  desescribing data for a piece worker for INC
//Includes DataAnotation for validation and intened to be used with entity Framework

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IncIncEntityFramework.Models
{
    public class PieceWorkerModel
    {
        /// <summary>
        /// Arbitrary ID for use with Entity Framework. 
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// worker's First name
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must enter a first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// worker's Last name
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must enter a last name")]
        [Display(Name = "last Name")]
        public string LastName { get; set; }
        /// <summary>
        /// Message
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must enter a Message")]
        [Range(1, 15000, ErrorMessage = "The message is must be between 1 to 15000")]
        [Display(Name = "Message")]
        public int Message { get; set; }

        /// <summary>
        /// Is worker is senior or not? 
        /// </summary>
        [Display(Name ="Senior Worker")]
        public bool IsSenior { get; set; }
        /// <summary>
        /// To display last updated date
        /// </summary>
        [Display(Name = "Last Updated Date")]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// The Getpay() method is used to calculate a worker's pay using their pay rate and Message sent.
        /// </summary>
        /// <returns></returns>
        public virtual decimal Getpay()
        {

            decimal employeePay = 0M;

            // Arrays used for comparisons to determine the pay rate.
            int[] messageThresholds = new int[] { 1250, 2500, 3750, 5000 };
            decimal[] payRates = new decimal[] { 0.025M, 0.03M, 0.035M, 0.041M, 0.048M };

            // Comparisons to determine the pay rate.
            if (Message < messageThresholds[0])
            {
                employeePay = Message * payRates[0];
            }
            else if (Message < messageThresholds[1])
            {
                employeePay = Message * payRates[1];
            }
            else if (Message < messageThresholds[2])
            {
                employeePay = Message * payRates[2];
            }
            else if (Message < messageThresholds[3])
            {
                employeePay = Message * payRates[3];
            }
            else
            {
                employeePay = Message * payRates[4];
            }

            return employeePay;
        }
    }
}
