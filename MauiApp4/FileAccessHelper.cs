﻿namespace MauiApp4;

public class FileAccessHelper
{
    public static string GetLocalFilePath(string filename)
    {
        return System.IO.Path.Combine(FileSystem.AppDataDirectory, filename);
    }
}

