//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.4.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Properties;
using Elements.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements.Geometry
{
    #pragma warning disable // Disable all warnings

    /// <summary>A right-handed coordinate system with +Z up.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Transform 
    {
        [Newtonsoft.Json.JsonConstructor]
        public Transform(Matrix @matrix)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Transform>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @matrix});
            }
        
            this.Matrix = @matrix;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>The transform's matrix.</summary>
        [Newtonsoft.Json.JsonProperty("Matrix", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Matrix Matrix { get; set; } = new Matrix();
    
    
    }
}