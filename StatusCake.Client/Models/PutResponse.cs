﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusCake.Client.Models
{
    /// <summary>
    /// Contains response data from a PUT request
    /// </summary>
    public class PutResponse
    {
        /// <summary>
        /// A list of human readable reasons returned by the API
        /// </summary>
        public Dictionary<string,string> Issues { get; set; }

        /// <summary>
        /// True if the update was successful
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// A human readable response message from the API
        /// </summary>
        public string Message { get; set; }
    }
}
