using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class PackageResult
    {
        public Guid PackagingId;
        public Double Width;
        public Double Height;
        public Double Depth;
        public Decimal ItemWeight;
        public Decimal PackagingWeight;
        public IList<Face> Faces;
        public IList<PackedItem> Items;
        public Int32 LayerCount;
        public IDictionary<Int32, Face> LayerFace;
        public Boolean IsManualPackage;
    }
}