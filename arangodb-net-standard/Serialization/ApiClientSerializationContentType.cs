namespace ArangoDBNetStandard.Serialization
{
    /// <summary>
    /// The API client content type enum.
    /// </summary>
    public enum ApiClientSerializationContentType
    {
        /// <summary>
        /// The post graph.
        /// </summary>
        PostGraph,
        
        /// <summary>
        /// The post edge.
        /// </summary>
        PostEdge,

        /// <summary>
        /// The put edge.
        /// </summary>
        PutEdge,

        /// <summary>
        /// The patch edge.
        /// </summary>
        PatchEdge,

        /// <summary>
        /// The post vertex.
        /// </summary>
        PostVertex,

        /// <summary>
        /// The patch vertex.
        /// </summary>
        PatchVertex,

        /// <summary>
        /// The put vertex.
        /// </summary>
        PutVertex,

        /// <summary>
        /// The get document.
        /// </summary>
        GetDocument,
        
        /// <summary>
        /// Thep post AQL funtion.
        /// </summary>
        PostAqlFunction,
        
        /// <summary>
        /// Get the JWT token.
        /// </summary>
        GetJwtToken,
        
        /// <summary>
        /// Post collection.
        /// </summary>
        PostCollection,
        
        /// <summary>
        /// Rename collection.
        /// </summary>
        RenameCollection,
        
        /// <summary>
        /// Put collection.
        /// </summary>
        PutCollection,

        /// <summary>
        /// Cursors.
        /// </summary>
        PostCursors,
        
        /// <summary>
        /// The post database.
        /// </summary>
        PostDatabase,
        
        /// <summary>
        /// The post document.
        /// </summary>
        PostDocument,

        /// <summary>
        /// The patch document.
        /// </summary>
        PatchDocument,

        /// <summary>
        /// The put document.
        /// </summary>
        PutDocument,
        
        /// <summary>
        /// The delete document.
        /// </summary>
        DeleteDocument
    }
}
