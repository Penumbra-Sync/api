using System;

namespace MareSynchronos.API
{
    public class MareAuth
    {

        public const string Auth = "/auth";
        public const string Auth_CreateIdent = "createWithIdent";
        public static Uri AuthFullPath(Uri baseUri) => new Uri(baseUri, Auth + "/" + Auth_CreateIdent);
    }
}