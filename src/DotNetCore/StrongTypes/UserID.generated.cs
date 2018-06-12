﻿using System;
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
	/// Implements the strong type <see cref="UserID" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "1.0.0")]
	[Serializable]
	public partial struct UserID : IEquatable<UserID>, IComparable<UserID>, ISerializable, IXmlSerializable
	{
		/// <summary>
		/// Actual backing field which holds the value.
		/// </summary>
		/// <remarks>This field is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
		private System.Int32 _value;

		[ExcludeFromCodeCoverage]
		private UserID(System.Int32 value)
	    {
	        _value = value;
	    }

		[ExcludeFromCodeCoverage]
		private UserID(SerializationInfo info, StreamingContext context)
		{
            _value = (System.Int32)info.GetValue("v", typeof(System.Int32));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="UserID"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator UserID(System.Int32 value)
	    {
	        return new UserID(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Int32"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.Int32(UserID value)
	    {
	        return value._value;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="UserID"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(UserID other)
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
			return Equals((UserID)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="UserID"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, _value))
				return 0;
			return _value.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="UserID"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="UserID"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(UserID other)
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
        public static bool operator ==(UserID first, UserID second)
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
        public static bool operator !=(UserID first, UserID second)
	    {
	        return !(first == second);
	    }
		
	    /// <summary>
	    /// Checks if the first operand is less than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator <(UserID first, UserID second)
	    {
	        return first._value < second._value;
	    }

	    /// <summary>
	    /// Checks if the first operand is greater than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >(UserID first, UserID second)
	    {
	        return first._value > second._value;
	    }

	    /// <summary>
	    /// Checks if the first operand is less than or equal to the second operand.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator <=(UserID first, UserID second)
	    {
	        return first._value <= second._value;
	    }

        /// <summary>
        /// Checks if the first operand is greater than or equal to the second operand.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >=(UserID first, UserID second)
	    {
	        return first._value >= second._value;
        }

        /// <summary>
        /// Adds the two summands.
        /// </summary>
        /// <param name="summand1">The left operand.</param>
        /// <param name="summand2">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the sum failed.</exception>
        /// <returns>The sum.</returns>
        [ExcludeFromCodeCoverage]
        public static UserID operator +(UserID summand1, UserID summand2)
        {
            return (UserID) (summand1._value + summand2._value);
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
        [ExcludeFromCodeCoverage]
        public static UserID operator -(UserID minuend, UserID subtrahend)
        {
            return (UserID)(minuend._value - subtrahend._value);
        }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static UserID operator ++(UserID value)
	    {
	        return (UserID) (++value._value);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static UserID operator --(UserID value)
	    {
	        return (UserID) (--value._value);
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
	        return _value.ToString();
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