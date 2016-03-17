namespace GDTB.EditorPrefsEditor
{
    [System.Serializable]
    public class Pref: System.Object
    {
        public PrefType Type;
        public string Key;
        public string Value;

        public Pref (PrefType aType, string aKey, string aValue)
        {
            this.Type = aType;
            this.Key = aKey;
            this.Value = aValue;
        }
    }
}