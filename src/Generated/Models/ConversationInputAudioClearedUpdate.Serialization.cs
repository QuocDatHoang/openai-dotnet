// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationInputAudioClearedUpdate : IJsonModel<ConversationInputAudioClearedUpdate>
    {
        internal ConversationInputAudioClearedUpdate()
        {
        }

        void IJsonModel<ConversationInputAudioClearedUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationInputAudioClearedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationInputAudioClearedUpdate)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
        }

        ConversationInputAudioClearedUpdate IJsonModel<ConversationInputAudioClearedUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (ConversationInputAudioClearedUpdate)JsonModelCreateCore(ref reader, options);

        protected override ConversationUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationInputAudioClearedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationInputAudioClearedUpdate)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationInputAudioClearedUpdate(document.RootElement, options);
        }

        internal static ConversationInputAudioClearedUpdate DeserializeConversationInputAudioClearedUpdate(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string eventId = default;
            ConversationUpdateKind kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("event_id"u8))
                {
                    eventId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("type"u8))
                {
                    kind = prop.Value.GetString().ToConversationUpdateKind();
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new ConversationInputAudioClearedUpdate(eventId, kind, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ConversationInputAudioClearedUpdate>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationInputAudioClearedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationInputAudioClearedUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationInputAudioClearedUpdate IPersistableModel<ConversationInputAudioClearedUpdate>.Create(BinaryData data, ModelReaderWriterOptions options) => (ConversationInputAudioClearedUpdate)PersistableModelCreateCore(data, options);

        protected override ConversationUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationInputAudioClearedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeConversationInputAudioClearedUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationInputAudioClearedUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationInputAudioClearedUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(ConversationInputAudioClearedUpdate conversationInputAudioClearedUpdate)
        {
            if (conversationInputAudioClearedUpdate == null)
            {
                return null;
            }
            return BinaryContent.Create(conversationInputAudioClearedUpdate, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator ConversationInputAudioClearedUpdate(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeConversationInputAudioClearedUpdate(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
