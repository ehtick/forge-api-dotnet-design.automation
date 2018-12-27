/* 
 * Forge Design Automation
 *
 * Generated by [Forge Swagger Codegen](https://git.autodesk.com/design-automation/forge-rsdk-codegen)
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Autodesk.Forge.DesignAutomation.Model
{
    /// <summary>
    /// Alias
    /// </summary>
    [DataContract]
    public partial class Alias 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Alias" /> class.
        /// </summary>
        public Alias()
        {
        }
        
        /// <summary>
        /// The version that this alias refers to.
        /// </summary>
        /// <value>The version that this alias refers to.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int Version { get; set; }

        /// <summary>
        /// The user to share the alias with.
        /// </summary>
        /// <value>The user to share the alias with.</value>
        [DataMember(Name="receiver", EmitDefaultValue=false)]
        public string Receiver { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

}
