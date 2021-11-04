/*
 * Continous Food Delievery
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Cfd.Converters;

namespace Cfd.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class MenuItem : IEquatable<MenuItem>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [Required]
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [Required]
        //[Column(TypeName = "decimal(18,2)")]
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double Price { get; set; }

        /// <summary>
        /// URL to an image of the menu item.  This should be the image from the /image endpoint 
        /// </summary>
        /// <value>URL to an image of the menu item.  This should be the image from the /image endpoint </value>
        [Required]
        [DataMember(Name="imageId", EmitDefaultValue=false)]
        public int ImageId { get; set; }
        public Image Image { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenuItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((MenuItem)obj);
        }

        /// <summary>
        /// Returns true if MenuItem instances are equal
        /// </summary>
        /// <param name="other">Instance of MenuItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuItem other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Price == other.Price ||
                    
                    Price.Equals(other.Price)
                ) && 
                (
                    ImageId == other.ImageId ||
                    
                    ImageId.Equals(other.ImageId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    
                    hashCode = hashCode * 59 + Price.GetHashCode();
                    
                    hashCode = hashCode * 59 + ImageId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MenuItem left, MenuItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MenuItem left, MenuItem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}