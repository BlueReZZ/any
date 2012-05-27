namespace Any.Framework
{
    internal interface IAnyProvider
    {
        dynamic Any();
        dynamic AnyBetween(dynamic lower, dynamic upper);
        dynamic AnyExcept(dynamic exception);
    }
}
