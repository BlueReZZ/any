namespace Any
{
    internal interface IProvider
    {
        dynamic Any();
        dynamic AnyBetween(dynamic lower, dynamic upper);
        dynamic AnyExcept(dynamic exception);
    }
}
