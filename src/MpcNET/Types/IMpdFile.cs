﻿using System.Collections.Generic;

namespace MpcNET.Types
{
    public interface IMpdFilePath
    {
        string Path { get; }
    }

    public interface IMpdFile : IMpdFilePath
    {
        int Time { get; }
        string Album { get; } 
        string Artist { get; }
        string Title { get; }
        string Track { get; }
        string Name { get; }
        string Genre { get; }
        string Date { get; }
        string Composer { get; }
        string Performer { get; }
        string Comment { get; }
        int Disc { get; }
        int Pos { get; }
        int Id { get; }
        IDictionary<string, string> UnknownMetadata { get; }
    }
}