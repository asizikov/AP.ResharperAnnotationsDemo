using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace Annotations.Demo
{
    public class UsedPublicApi
    {
        //might be used via reflection, from "Spring like magic" ect
//        [UsedImplicitly]
        public Version Version
        {
            get { return new Version(1,1,1,1); }
        }

        //this method is used by other applications
//        [PublicAPI]
        public void LogError(string parameter)
        {
            Debug.WriteLine(parameter);
        }

        //read from outside, write from everywhere
//        [UsedImplicitly(ImplicitUseKindFlags.Access)]
        public bool Value { get; set; }

        public UsedPublicApi(bool value)
        {
            Value = value;
        }
    }
}