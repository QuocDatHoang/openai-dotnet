// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionFunctionCallOption
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalChatCompletionFunctionCallOption(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        internal InternalChatCompletionFunctionCallOption(string name, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Name = name;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Name { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
