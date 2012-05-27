using System;
using System.Collections.Generic;
using System.Dynamic;
using Any.Providers;

namespace Any.Framework
{
    public class AnyGenerator : DynamicObject
    {
        private const string BETWEEN = "Between";
        private const string EXCEPT = "Except";

        private readonly Dictionary<string, IAnyProvider> _providers = 
            new Dictionary<string, IAnyProvider>()
            {
                {"Int", new IntProvider()}
            }; 

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            var name = binder.Name;
            if (name.EndsWith(BETWEEN, StringComparison.InvariantCultureIgnoreCase))
            {
                name = name.Replace(BETWEEN, "");
                result = _providers[name].AnyBetween(args[0], args[1]);
            }
            else if (name.EndsWith(EXCEPT, StringComparison.InvariantCultureIgnoreCase))
            {
                name = name.Replace(EXCEPT, "");
                result = _providers[name].AnyExcept(args[0]);
            }
            else
            {
                result = _providers[name].Any();
            }
            
            return  result != null;
        }
    }
}