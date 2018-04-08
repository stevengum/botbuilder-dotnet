// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Schema
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Activity is the basic communication type for the Bot Framework 3.0
    /// protocol
    /// </summary>
    public partial class Activity
    {
        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        public Activity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        /// <param name="type">The type of the activity. Possible values
        /// include: 'message', 'contactRelationUpdate', 'conversationUpdate',
        /// 'typing', 'ping', 'endOfConversation', 'event', 'invoke',
        /// 'deleteUserData', 'messageUpdate', 'messageDelete',
        /// 'installationUpdate', 'messageReaction', 'suggestion',
        /// 'trace'</param>
        /// <param name="id">ID of this activity</param>
        /// <param name="timestamp">UTC Time when message was sent (set by
        /// service)</param>
        /// <param name="localTimestamp">Local time when message was sent (set
        /// by client, Ex: 2016-09-23T13:07:49.4714686-07:00)</param>
        /// <param name="serviceUrl">Service endpoint where operations
        /// concerning the activity may be performed</param>
        /// <param name="channelId">ID of the channel where the activity was
        /// sent</param>
        /// <param name="from">Sender address</param>
        /// <param name="conversation">Conversation</param>
        /// <param name="recipient">(Outbound to bot only) Bot's address that
        /// received the message</param>
        /// <param name="textFormat">Format of text fields Default:markdown.
        /// Possible values include: 'markdown', 'plain', 'xml'</param>
        /// <param name="attachmentLayout">Hint for how to deal with multiple
        /// attachments. Default:list. Possible values include: 'list',
        /// 'carousel'</param>
        /// <param name="membersAdded">Members added to the
        /// conversation</param>
        /// <param name="membersRemoved">Members removed from the
        /// conversation</param>
        /// <param name="reactionsAdded">Reactions added to the
        /// activity</param>
        /// <param name="reactionsRemoved">Reactions removed from the
        /// activity</param>
        /// <param name="topicName">The conversation's updated topic
        /// name</param>
        /// <param name="historyDisclosed">True if prior history of the channel
        /// is disclosed</param>
        /// <param name="locale">The language code of the Text field</param>
        /// <param name="text">Content for the message</param>
        /// <param name="speak">SSML Speak for TTS audio response</param>
        /// <param name="inputHint">Input hint to the channel on what the bot
        /// is expecting. Possible values include: 'acceptingInput',
        /// 'ignoringInput', 'expectingInput'</param>
        /// <param name="summary">Text to display if the channel cannot render
        /// cards</param>
        /// <param name="suggestedActions">SuggestedActions are used to provide
        /// keyboard/quickreply like behavior in many clients</param>
        /// <param name="attachments">Attachments</param>
        /// <param name="entities">Collection of Entity objects, each of which
        /// contains metadata about this activity. Each Entity object is
        /// typed.</param>
        /// <param name="channelData">Channel-specific payload</param>
        /// <param name="action">ContactAdded/Removed action</param>
        /// <param name="replyToId">The original ID this message is a response
        /// to</param>
        /// <param name="value">Open-ended value</param>
        /// <param name="name">Name of the operation to invoke or the name of
        /// the event</param>
        /// <param name="relatesTo">Reference to another conversation or
        /// activity</param>
        /// <param name="code">Code indicating why the conversation has ended.
        /// Possible values include: 'unknown', 'completedSuccessfully',
        /// 'userCancelled', 'botTimedOut', 'botIssuedInvalidMessage',
        /// 'channelFailed'</param>
        /// <param name="expiration">DateTime to expire the activity as ISO
        /// 8601 encoded datetime</param>
        /// <param name="importance">Importance of this activity
        /// {Low|Normal|High}, null value indicates Normal importance see
        /// ActivityImportance)</param>
        /// <param name="deliveryMode">Hint to describe how this activity
        /// should be delivered.
        /// Currently: null or "Default" = default delivery
        /// "Notification" = notification semantics</param>
        /// <param name="textHighlights">TextHighlight in the activity
        /// represented in the ReplyToId property</param>
        public Activity(string type = default(string), string id = default(string), System.DateTimeOffset? timestamp = default(System.DateTimeOffset?), System.DateTimeOffset? localTimestamp = default(System.DateTimeOffset?), string serviceUrl = default(string), string channelId = default(string), ChannelAccount from = default(ChannelAccount), ConversationAccount conversation = default(ConversationAccount), ChannelAccount recipient = default(ChannelAccount), string textFormat = default(string), string attachmentLayout = default(string), IList<ChannelAccount> membersAdded = default(IList<ChannelAccount>), IList<ChannelAccount> membersRemoved = default(IList<ChannelAccount>), IList<MessageReaction> reactionsAdded = default(IList<MessageReaction>), IList<MessageReaction> reactionsRemoved = default(IList<MessageReaction>), string topicName = default(string), bool? historyDisclosed = default(bool?), string locale = default(string), string text = default(string), string speak = default(string), string inputHint = default(string), string summary = default(string), SuggestedActions suggestedActions = default(SuggestedActions), IList<Attachment> attachments = default(IList<Attachment>), IList<Entity> entities = default(IList<Entity>), object channelData = default(object), string action = default(string), string replyToId = default(string), object value = default(object), string name = default(string), ConversationReference relatesTo = default(ConversationReference), string code = default(string), System.DateTimeOffset? expiration = default(System.DateTimeOffset?), string importance = default(string), string deliveryMode = default(string), IList<TextHighlight> textHighlights = default(IList<TextHighlight>))
        {
            Type = type;
            Id = id;
            Timestamp = timestamp;
            LocalTimestamp = localTimestamp;
            ServiceUrl = serviceUrl;
            ChannelId = channelId;
            From = from;
            Conversation = conversation;
            Recipient = recipient;
            TextFormat = textFormat;
            AttachmentLayout = attachmentLayout;
            MembersAdded = membersAdded;
            MembersRemoved = membersRemoved;
            ReactionsAdded = reactionsAdded;
            ReactionsRemoved = reactionsRemoved;
            TopicName = topicName;
            HistoryDisclosed = historyDisclosed;
            Locale = locale;
            Text = text;
            Speak = speak;
            InputHint = inputHint;
            Summary = summary;
            SuggestedActions = suggestedActions;
            Attachments = attachments;
            Entities = entities;
            ChannelData = channelData;
            Action = action;
            ReplyToId = replyToId;
            Value = value;
            Name = name;
            RelatesTo = relatesTo;
            Code = code;
            Expiration = expiration;
            Importance = importance;
            DeliveryMode = deliveryMode;
            TextHighlights = textHighlights;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of the activity. Possible values include:
        /// 'message', 'contactRelationUpdate', 'conversationUpdate', 'typing',
        /// 'ping', 'endOfConversation', 'event', 'invoke', 'deleteUserData',
        /// 'messageUpdate', 'messageDelete', 'installationUpdate',
        /// 'messageReaction', 'suggestion', 'trace'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets ID of this activity
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets UTC Time when message was sent (set by service)
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTimeOffset? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets local time when message was sent (set by client, Ex:
        /// 2016-09-23T13:07:49.4714686-07:00)
        /// </summary>
        [JsonProperty(PropertyName = "localTimestamp")]
        public System.DateTimeOffset? LocalTimestamp { get; set; }

        /// <summary>
        /// Gets or sets service endpoint where operations concerning the
        /// activity may be performed
        /// </summary>
        [JsonProperty(PropertyName = "serviceUrl")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Gets or sets ID of the channel where the activity was sent
        /// </summary>
        [JsonProperty(PropertyName = "channelId")]
        public string ChannelId { get; set; }

        /// <summary>
        /// Gets or sets sender address
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public ChannelAccount From { get; set; }

        /// <summary>
        /// Gets or sets conversation
        /// </summary>
        [JsonProperty(PropertyName = "conversation")]
        public ConversationAccount Conversation { get; set; }

        /// <summary>
        /// Gets or sets (Outbound to bot only) Bot's address that received the
        /// message
        /// </summary>
        [JsonProperty(PropertyName = "recipient")]
        public ChannelAccount Recipient { get; set; }

        /// <summary>
        /// Gets or sets format of text fields Default:markdown. Possible
        /// values include: 'markdown', 'plain', 'xml'
        /// </summary>
        [JsonProperty(PropertyName = "textFormat")]
        public string TextFormat { get; set; }

        /// <summary>
        /// Gets or sets hint for how to deal with multiple attachments.
        /// Default:list. Possible values include: 'list', 'carousel'
        /// </summary>
        [JsonProperty(PropertyName = "attachmentLayout")]
        public string AttachmentLayout { get; set; }

        /// <summary>
        /// Gets or sets members added to the conversation
        /// </summary>
        [JsonProperty(PropertyName = "membersAdded")]
        public IList<ChannelAccount> MembersAdded { get; set; }

        /// <summary>
        /// Gets or sets members removed from the conversation
        /// </summary>
        [JsonProperty(PropertyName = "membersRemoved")]
        public IList<ChannelAccount> MembersRemoved { get; set; }

        /// <summary>
        /// Gets or sets reactions added to the activity
        /// </summary>
        [JsonProperty(PropertyName = "reactionsAdded")]
        public IList<MessageReaction> ReactionsAdded { get; set; }

        /// <summary>
        /// Gets or sets reactions removed from the activity
        /// </summary>
        [JsonProperty(PropertyName = "reactionsRemoved")]
        public IList<MessageReaction> ReactionsRemoved { get; set; }

        /// <summary>
        /// Gets or sets the conversation's updated topic name
        /// </summary>
        [JsonProperty(PropertyName = "topicName")]
        public string TopicName { get; set; }

        /// <summary>
        /// Gets or sets true if prior history of the channel is disclosed
        /// </summary>
        [JsonProperty(PropertyName = "historyDisclosed")]
        public bool? HistoryDisclosed { get; set; }

        /// <summary>
        /// Gets or sets the language code of the Text field
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets content for the message
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets SSML Speak for TTS audio response
        /// </summary>
        [JsonProperty(PropertyName = "speak")]
        public string Speak { get; set; }

        /// <summary>
        /// Gets or sets input hint to the channel on what the bot is
        /// expecting. Possible values include: 'acceptingInput',
        /// 'ignoringInput', 'expectingInput'
        /// </summary>
        [JsonProperty(PropertyName = "inputHint")]
        public string InputHint { get; set; }

        /// <summary>
        /// Gets or sets text to display if the channel cannot render cards
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets suggestedActions are used to provide
        /// keyboard/quickreply like behavior in many clients
        /// </summary>
        [JsonProperty(PropertyName = "suggestedActions")]
        public SuggestedActions SuggestedActions { get; set; }

        /// <summary>
        /// Gets or sets attachments
        /// </summary>
        [JsonProperty(PropertyName = "attachments")]
        public IList<Attachment> Attachments { get; set; }

        /// <summary>
        /// Gets or sets collection of Entity objects, each of which contains
        /// metadata about this activity. Each Entity object is typed.
        /// </summary>
        [JsonProperty(PropertyName = "entities")]
        public IList<Entity> Entities { get; set; }

        /// <summary>
        /// Gets or sets channel-specific payload
        /// </summary>
        [JsonProperty(PropertyName = "channelData")]
        public object ChannelData { get; set; }

        /// <summary>
        /// Gets or sets contactAdded/Removed action
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets the original ID this message is a response to
        /// </summary>
        [JsonProperty(PropertyName = "replyToId")]
        public string ReplyToId { get; set; }

        /// <summary>
        /// Gets or sets open-ended value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets name of the operation to invoke or the name of the
        /// event
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets reference to another conversation or activity
        /// </summary>
        [JsonProperty(PropertyName = "relatesTo")]
        public ConversationReference RelatesTo { get; set; }

        /// <summary>
        /// Gets or sets code indicating why the conversation has ended.
        /// Possible values include: 'unknown', 'completedSuccessfully',
        /// 'userCancelled', 'botTimedOut', 'botIssuedInvalidMessage',
        /// 'channelFailed'
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets dateTime to expire the activity as ISO 8601 encoded
        /// datetime
        /// </summary>
        [JsonProperty(PropertyName = "expiration")]
        public System.DateTimeOffset? Expiration { get; set; }

        /// <summary>
        /// Gets or sets importance of this activity
        /// {Low|Normal|High}, null value indicates Normal importance see
        /// ActivityImportance)
        /// </summary>
        [JsonProperty(PropertyName = "importance")]
        public string Importance { get; set; }

        /// <summary>
        /// Gets or sets hint to describe how this activity should be
        /// delivered.
        /// Currently: null or "Default" = default delivery
        /// "Notification" = notification semantics
        /// </summary>
        [JsonProperty(PropertyName = "deliveryMode")]
        public string DeliveryMode { get; set; }

        /// <summary>
        /// Gets or sets textHighlight in the activity represented in the
        /// ReplyToId property
        /// </summary>
        [JsonProperty(PropertyName = "textHighlights")]
        public IList<TextHighlight> TextHighlights { get; set; }

    }
}
