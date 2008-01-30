namespace nu.Utility
{
    using System;
    using System.Collections.Generic;

    public interface IProjectManifest
    {
        IEnumerable<String> Directories { get;}
        IEnumerable<String> Files { get;}
    }
}