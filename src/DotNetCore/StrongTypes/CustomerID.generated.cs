using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Herdo.StrongTypes.DotNetCore.StrongTypes
{
	/// <summary>
	/// CustomerID with consistent formatting across all applications.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "1.0.0")]
	[Serializable]
	public partial struct CustomerID : IEquatable<CustomerID>, IComparable<CustomerID>, ISerializable, IXmlSerializable
	{
		/// <summary>
		/// Actual backing field which holds the value.
		/// </summary>
		/// <remarks>This field is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
		private System.Int32 _value;

		[ExcludeFromCodeCoverage]
		private CustomerID(System.Int32 value)
	    {
	        _value = value;
	    }

		[ExcludeFromCodeCoverage]
		private CustomerID(SerializationInfo info, StreamingContext context)
		{
            _value = (System.Int32)info.GetValue("v", typeof(System.Int32));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="CustomerID"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator CustomerID(System.Int32 value)
	    {
	        return new CustomerID(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Int32"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.Int32(CustomerID value)
	    {
	        return value._value;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="CustomerID"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(CustomerID other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return _value == other._value;
		}
		
		/// <summary>
        /// Returns a value indicating whether this instance and a specified object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public override bool Equals(object other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return Equals((CustomerID)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="CustomerID"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, _value))
				return 0;
			return _value.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="CustomerID"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="CustomerID"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(CustomerID other)
		{
			if (Equals(null, _value))
				return 1;
			return _value.CompareTo(other._value);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(CustomerID first, CustomerID second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

	        return first._value == second._value;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(CustomerID first, CustomerID second)
	    {
	        return !(first == second);
	    }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static CustomerID operator ++(CustomerID value)
	    {
	        return (CustomerID) (++value._value);
        }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object) _value == null)
	            return null;
	        return _value.ToString("D5");
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", _value);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
	        return null;
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        _value = (System.Int32)reader.ReadElementContentAs(typeof(System.Int32), null);
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(_value));
	    }
	}
}