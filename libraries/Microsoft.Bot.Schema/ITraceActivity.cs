﻿using System;
using System.Linq;

namespace Microsoft.Bot.Schema
{
    /// <summary>
    /// An activity by which a bot can log internal information into a logged conversation transcript
    /// </summary>
    public interface ITraceActivity : IActivity
    {
        /// <summary>
        /// Name of the trace activity 
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Open-ended value
        /// </summary>
        object Value { get; set; }

        /// <summary>
        /// Reference to another conversation or activity
        /// </summary>
        ConversationReference RelatesTo { get; set; }
    }
}
