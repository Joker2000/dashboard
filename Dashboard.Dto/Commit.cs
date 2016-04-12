// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Commit.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Commit type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Dto
{
    using System;

    /// <summary>
    /// The commit.
    /// </summary>
    public class Commit
    {
        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the date time.
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the new file count.
        /// </summary>
        public int NewFileCount { get; set; }

        /// <summary>
        /// Gets or sets the deleted file count.
        /// </summary>
        public int DeletedFileCount { get; set; }

        /// <summary>
        /// Gets or sets the modified file count.
        /// </summary>
        public int ModifiedFileCount { get; set; }
    }
}
