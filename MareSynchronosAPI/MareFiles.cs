using System;

namespace MareSynchronos.API
{
    public class MareFiles
    {
        public const string Cache = "/cache";
        public const string Cache_Get = "get";
        public static Uri CacheGetFullPath(Uri baseUri, Guid requestId) => new(baseUri, Cache + "/" + Cache_Get + "?requestId=" + requestId.ToString());

        public const string ServerFiles = "/files";
        public const string ServerFiles_Get = "get";
        public static Uri ServerFilesGetFullPath(Uri baseUri, string hash) => new(baseUri, ServerFiles + "/" + ServerFiles_Get + "/" + hash);

        public const string Request = "/request";
        public const string Request_Enqueue = "enqueue";
        public const string Request_RequestFile = "file";
        public const string Request_CheckQueue = "status";

        public static Uri RequestEnqueueFullPath(Uri baseUri) => new(baseUri, Request + "/" + Request_Enqueue);
        public static Uri RequestRequestFileFullPath(Uri baseUri, string hash) => new(baseUri, Request + "/" + Request_RequestFile + "?file=" + hash);
        public static Uri RequestCheckQueueFullPath(Uri baseUri, Guid requestId) => new(baseUri, Request + "/" + Request_CheckQueue + "?requestId=" + requestId.ToString());
    }
}