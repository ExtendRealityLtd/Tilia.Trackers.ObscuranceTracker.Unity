namespace Tilia.Trackers.ObscuranceTracker.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Trackers/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.trackers.obscurancetracker.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabObscuranceTracker = "Trackers.ObscuranceTracker";

        [MenuItem(menuItemRoot + prefabObscuranceTracker, false, priority)]
        private static void AddObscuranceTracker()
        {
            string prefab = prefabObscuranceTracker + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}