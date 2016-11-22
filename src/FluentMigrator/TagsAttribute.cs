using System;

namespace FluentMigrator
{
    public enum TagBehavior
    {
        Any,
        All
    }

    ///<summary>
    /// Used to filter which migrations are run.
    ///</summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    [CLSCompliant(false)]
    public class TagsAttribute : Attribute
    {
        public TagBehavior TagBehavior { get; set; }

        public string[] TagNames { get; private set; }

        protected TagsAttribute(TagBehavior tagBehavior)
        {
            TagBehavior = tagBehavior;
        }

        [CLSCompliant(false)]
        public TagsAttribute(params string[] tagNames) : this(TagBehavior.All, tagNames)
        {
        }

        public TagsAttribute(TagBehavior tagBehavior, params string[] tagNames) : this(tagBehavior)
        {
            TagNames = tagNames;
        }

        public TagsAttribute(string tagName1)
            : this(new[] { tagName1 })
        {
        }

        public TagsAttribute(TagBehavior tagBehavior, string tagName1)
            : this(tagBehavior, new[] { tagName1 })
        {
        }

        public TagsAttribute(string tagName1, string tagName2)
            : this(new[] { tagName1, tagName2 })
        {
        }

        public TagsAttribute(TagBehavior tagBehavior, string tagName1, string tagName2)
            : this(tagBehavior, new[] {tagName1, tagName2})
        {
        }

        public TagsAttribute(string tagName1, string tagName2, string tagName3)
            : this(new[] { tagName1, tagName2, tagName3 })
        {
        }

        public TagsAttribute(TagBehavior tagBehavior, string tagName1, string tagName2, string tagName3)
            : this(tagBehavior, new[] { tagName1, tagName2, tagName3 })
        {
        }

        public TagsAttribute(string tagName1, string tagName2, string tagName3, string tagName4)
            : this(new[] { tagName1, tagName2, tagName3, tagName4 })
        {
        }

        public TagsAttribute(TagBehavior tagBehavior, string tagName1, string tagName2, string tagName3, string tagName4)
            : this(tagBehavior, new[] { tagName1, tagName2, tagName3, tagName4 })
        {
        }
    }
}
