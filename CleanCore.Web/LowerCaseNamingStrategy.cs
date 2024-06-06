using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCore.Web
{
    public class LowerCaseNamingStrategy : NamingStrategy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LowerCaseNamingStrategy"/> class.
        /// </summary>
        /// <param name="processDictionaryKeys">if set to <c>true</c> [process dictionary keys].</param>
        /// <param name="overrideSpecifiedNames">if set to <c>true</c> [override specified names].</param>
        public LowerCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
        {
            ProcessDictionaryKeys = processDictionaryKeys;
            OverrideSpecifiedNames = overrideSpecifiedNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LowerCaseNamingStrategy"/> class.
        /// </summary>
        /// <param name="processDictionaryKeys">if set to <c>true</c> [process dictionary keys].</param>
        /// <param name="overrideSpecifiedNames">if set to <c>true</c> [override specified names].</param>
        /// <param name="processExtensionDataNames">if set to <c>true</c> [process extension data names].</param>
        public LowerCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
            : this(processDictionaryKeys, overrideSpecifiedNames)
        {
            ProcessExtensionDataNames = processExtensionDataNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LowerCaseNamingStrategy"/> class.
        /// </summary>
        public LowerCaseNamingStrategy() { }

        /// <summary>
        /// Resolves the specified property name.
        /// </summary>
        /// <param name="name">The property name to resolve.</param>
        /// <returns>
        /// The resolved property name.
        /// </returns>
        protected override string ResolvePropertyName(string name) => name.ToLower();
    }

}
