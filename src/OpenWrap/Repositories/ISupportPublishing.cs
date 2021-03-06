﻿using System;
using System.IO;
using OpenWrap.PackageModel;

namespace OpenWrap.Repositories
{
    public interface ISupportPublishing : IPackageRepository
    {
        IPackagePublisher Publisher();
    }
    public interface IPackagePublisher : IDisposable
    {
        IPackageInfo Publish(string packageFileName, Stream packageStream);        
    }
}