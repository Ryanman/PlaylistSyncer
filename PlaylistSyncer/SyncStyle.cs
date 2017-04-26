using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistSyncer
{
    public sealed class SyncStyle
    {
        private readonly string _name;

        public static readonly SyncStyle FromZune = new SyncStyle("fromZuneRadio");
        public static readonly SyncStyle FromOther = new SyncStyle("fromOther");
        public static readonly SyncStyle Latest = new SyncStyle("latestMirror");

        private SyncStyle(string name)
        {
            this._name = name;
        }

        public override string ToString()
        {
            return _name;
        }

    }
}
