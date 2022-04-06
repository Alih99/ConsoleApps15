using System;
using System.ComponentModel.DataAnnotations;

namespace WebApps.Models
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// modified by: Ali Hassan 23/03/2022
    /// version 0.2
    /// </author>
    public class MessagePost : Post
    {

        // an arbitrarily long, multi-line message
        [StringLength(256), DataType(DataType.MultilineText)]
        public String Message { get; set; }

    }
}