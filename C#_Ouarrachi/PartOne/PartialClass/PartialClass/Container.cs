namespace PartialClass
{
    // The nested type can be partial aven if the type they are nested within in not partial it self:
    public class Container
    {
        partial class NestedClass
        {
            public void Test1()
            {
                // Same statements here ...
            }
        }
        partial class NestedClass
        {
            public void Test2()
            {
                // Some statements here ...
            }
        }
    }

}