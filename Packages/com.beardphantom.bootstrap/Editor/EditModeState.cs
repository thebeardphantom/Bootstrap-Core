#if UNITY_EDITOR
using System;
using System.Collections.Generic;

namespace BeardPhantom.Bootstrap.Core.Editor
{
    [Serializable]
    public class EditModeState
    {
        public List<string> LoadedScenes { get; set; } = new();

        public SelectedObjectPath[] SelectedObjects { get; set; } = Array.Empty<SelectedObjectPath>();
    }
}
#endif