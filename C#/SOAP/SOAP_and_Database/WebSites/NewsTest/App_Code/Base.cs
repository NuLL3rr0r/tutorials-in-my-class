using System;
using System.Collections.Generic;
using System.Web;

using System.IO;

/// <summary>
/// Summary description for Base
/// </summary>
public static class Base
{
    public static string dbFile = @"db\news.mdb";
    public static string dbPw = "123";
    public static string path;
    public static string cnnStr;

    static Base()
	{
        System.Web.Services.WebService ws = new System.Web.Services.WebService();

        path = ws.Server.MapPath("~");
        path += path.EndsWith(Path.DirectorySeparatorChar.ToString()) ? string.Empty : Path.DirectorySeparatorChar.ToString();

        dbFile = String.Concat(path, dbFile);

        cnnStr = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1};", dbFile, dbPw);
	}
}