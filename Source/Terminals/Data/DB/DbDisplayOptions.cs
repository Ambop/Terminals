//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Terminals.Data.DB
{
    using System;
    using System.Collections.Generic;
    
    internal partial class DbDisplayOptions
    {
        public int FavoriteId { get; set; }
        public Nullable<int> Height { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<byte> Size { get; set; }
        public Nullable<byte> Colors { get; set; }
    
        public virtual DbFavorite Favorite { get; set; }
    }
}
