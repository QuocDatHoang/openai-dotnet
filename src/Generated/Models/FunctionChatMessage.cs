// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    public partial class FunctionChatMessage : ChatMessage
    {
        internal FunctionChatMessage(ChatMessageContent content, Chat.ChatMessageRole role, IDictionary<string, BinaryData> additionalBinaryDataProperties, string functionName) : base(content, role, additionalBinaryDataProperties)
        {
            FunctionName = functionName;
        }
    }
}
