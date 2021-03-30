using System;
using System.Collections.Generic;
using System.Reflection;

namespace ObjectLibrary.CreatedDelegate
{
    public class OurDelegate
    {
        private List<MethodInfo> _catalogMethods;

        public OurDelegate(MethodInfo method)
        {
            if (method == null) throw new ArgumentException("method = null");
            _catalogMethods = new List<MethodInfo> {method};
        }
        
    }
}