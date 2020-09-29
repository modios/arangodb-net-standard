using System.IO;

namespace ArangoDBNetStandard.Serialization
{
    /// <summary>
    /// The Api client serilization abastract class.
    /// Used as a base to implement custom serilizations.
    /// </summary>
    public abstract class ApiClientSerialization : IApiClientSerialization
    {
        /// <summary>
        /// Serializes the specified object to a sequence of bytes,
        /// override this method to implement the custom serializer action the given object.
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize.</typeparam>
        /// <param name="item">The object to serialize.</param>
        /// <param name="options">The serialization content type.</param>
        /// <returns></returns>
        protected abstract byte[] SerializeItem<T>(T item, ApiClientSerializationOptions options);

        /// <summary>
        /// Deserializes the data structure contained by the specified stream
        /// into an instance of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to.</typeparam>
        /// <param name="stream">The stream containing the JSON structure to deserialize.</param>
        /// <returns></returns>
        public abstract T DeserializeFromStream<T>(Stream stream);

        /// <summary>
        /// Gets the serizilzation options for the given contet type.
        /// Override this method in order to implement custom serialization
        /// options, otherwise the default options will be
        /// applied.
        /// </summary>
        /// <param name="contentType">The content type.</param>
        /// <returns></returns>
        protected virtual ApiClientSerializationOptions GetSerializationOptions(ApiClientSerializationContentType contentType)
        {
            switch(contentType){
                case ApiClientSerializationContentType.GetDocument:
                    return new ApiClientSerializationOptions(false, false);
            }

            return null;
        }

        /// <summary>
        /// Serializes the specified object to a sequence of bytes,
        /// following the provided rules for camel case property name and null value handling.
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize.</typeparam>
        /// <param name="item">The object to serialize.</param>
        /// <param name="apiClientSerializationContentType">The serialization content type.</param>
        /// <returns></returns>
        public byte[] Serialize<T>(T item, ApiClientSerializationContentType apiClientSerializationContentType)
        {
            var options = GetSerializationOptions(apiClientSerializationContentType);
            return SerializeItem(item, options);
        }
    }
}
