﻿using System;
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
	/// Implements the strong type <see cref="Year" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "1.0.0")]
#if (WINDOWS_UWP == false)
	[Serializable]
#endif
	public partial struct Year : 
        IEquatable<Year>,
        IComparable<Year>,
#if (WINDOWS_UWP == false)
        ISerializable,
#endif
        IXmlSerializable
	{
		/// <summary>
		/// Actual backing field which holds the value.
		/// </summary>
		/// <remarks>This field is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
		private System.Int16 _value;

#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
		private Year(System.Int16 value)
	    {
	        _value = Validate(value);
	    }

#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
#if (WINDOWS_UWP == false)
		private Year(SerializationInfo info, StreamingContext context)
		{
            _value = Validate((System.Int16)info.GetValue("v", typeof(System.Int16)));
		}
#endif

	    /// <summary>
	    /// Converts the weak type into a <see cref="Year"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
	    public static explicit operator Year(System.Int16 value)
	    {
	        return new Year(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Int16"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
	    public static explicit operator System.Int16(Year value)
	    {
	        return value._value;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="Year"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
		public bool Equals(Year other)
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
			return Equals((Year)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="Year"/>.</returns>
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
        /// Compares this instance to a specified <see cref="Year"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="Year"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
		public int CompareTo(Year other)
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
        public static bool operator ==(Year first, Year second)
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
        public static bool operator !=(Year first, Year second)
	    {
	        return !(first == second);
	    }
		
	    /// <summary>
	    /// Checks if the first operand is less than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
        public static bool operator <(Year first, Year second)
	    {
	        return first._value < second._value;
	    }

	    /// <summary>
	    /// Checks if the first operand is greater than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
        public static bool operator >(Year first, Year second)
	    {
	        return first._value > second._value;
	    }

	    /// <summary>
	    /// Checks if the first operand is less than or equal to the second operand.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
        public static bool operator <=(Year first, Year second)
	    {
	        return first._value <= second._value;
	    }

        /// <summary>
        /// Checks if the first operand is greater than or equal to the second operand.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
        public static bool operator >=(Year first, Year second)
	    {
	        return first._value >= second._value;
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
        public static Year operator -(Year minuend, Year subtrahend)
        {
            return (Year)(minuend._value - subtrahend._value);
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
        public static Year operator ++(Year value)
	    {
	        return (Year) (++value._value);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
        public static Year operator --(Year value)
	    {
	        return (Year) (--value._value);
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
	        return _value.ToString();
	    }
				
#if (WINDOWS_UWP == false)
		[ExcludeFromCodeCoverage]
#endif
		private static System.Int16 Validate(System.Int16 value)
		{
			string validationError;
			if (!IsValid(value, out validationError))
				throw new InvalidCastException("Invalid cast into the strong type. The validation failed. Error: " + validationError ?? "<null>");
			return value;
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
	        _value = Validate((System.Int16)reader.ReadElementContentAs(typeof(System.Int16), null));
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