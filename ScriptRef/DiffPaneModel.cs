using System.Collections.Generic;

namespace ScriptRef
{
    public class DiffPaneModel
    {
        public List<DiffPiece> Lines { get; }

        public DiffPaneModel()
        {
            Lines = new List<DiffPiece>();
        }
    }
}
