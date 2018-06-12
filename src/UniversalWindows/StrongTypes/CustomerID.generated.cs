using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;
#if (WINDOWS_UWP == false)
using System.Diagnostics.CodeAnalysis;
using System.Security.Permissions;
#endif
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Herdo.StrongTypes.UniversalWindows.StrongTypes
{
	/// <summary>
	/// CustomerID with consistent formatting across all applications.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "1.0.0")]
#if (WINDOWS_UWP == false)
	[Serializable]
#endif
	public partial struct CustomerID : 
        IEquatable<CustomerID>,
        IComparable<CustomerID>,
#if (WINDOWS_UWP == false)
        ISerializable,
#endif
        IXmlSerializable
	{
		/// <summary>
		/// Actual backing field which holds the value.
		/// </summary>
		/// <remarks>This field is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
		private System.Int32 _value;

#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
		private CustomerID(System.Int32 value)
	    {
	        _value = value;
	    }

#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
#if (WINDOWS_UWP == false)
		private CustomerID(SerializationInfo info, StreamingContext context)
		{
            _value = (System.Int32)info.GetValue("v", typeof(System.Int32));
		}
#endif

	    /// <summary>
	    /// Converts the weak type into a <see cref="CustomerID"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
	    public static explicit operator CustomerID(System.Int32 value)
	    {
	        return new CustomerID(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Int32"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
	    public static explicit operator System.Int32(CustomerID value)
	    {
	        return value._value;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="CustomerID"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
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
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
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
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
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
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
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
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
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
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
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
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
        public static CustomerID operator ++(CustomerID value)
	    {
	        return (CustomerID) (++value._value);
        }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
	    public override string ToString()
	    {
	        if ((object) _value == null)
	            return null;
	        return _value.ToString("D5");
	    }
				
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
#if (WINDOWS_UWP == false)
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", _value);
		}
#endif
		
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
		XmlSchema IXmlSerializable.GetSchema()
	    {
	        return null;
	    }
		
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        _value = (System.Int32)reader.ReadElementContentAs(typeof(System.Int32), null);
	    }
		
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(_value));
	    }
	}
}