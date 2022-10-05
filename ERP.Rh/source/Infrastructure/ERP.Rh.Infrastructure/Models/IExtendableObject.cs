using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Rh.Infrastructure.Models
{
    public interface IExtendableObject
    {
        /// <summary>
        /// A JSON formatted string to extend the containing object.
        /// JSON data can contain properties with arbitrary values (like primitives or complex objects).
        /// Extension methods are available (<see cref="ExtendableObjectExtensions"/>) to manipulate this data.
        /// General format:
        /// <code>
        /// {
        ///   "Property1" : ...
        ///   "Property2" : ...
        /// }
        /// </code>
        /// </summary>
        string ExtensionData { get; set; }

        T GetData<T>(string name, JsonSerializer jsonSerializer);
        void SetData<T>(string name, T? value, JsonSerializer jsonSerializer);
    }
}
