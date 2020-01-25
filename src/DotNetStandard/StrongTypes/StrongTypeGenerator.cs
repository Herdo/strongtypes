// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable InheritdocConsiderUsage
// ReSharper disable RedundantNameQualifier
// ReSharper disable HeuristicUnreachableCode
// ReSharper disable ReferenceEqualsWithValueType
// ReSharper disable ConditionIsAlwaysTrueOrFalse
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable RedundantCast
// ReSharper disable RedundantCast.0
// ReSharper disable SpecifyACultureInStringConversionExplicitly
// ReSharper disable ArrangeThisQualifier
// ReSharper disable StringCompareToIsCultureSpecific
// ReSharper disable RedundantToStringCall

using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using JetBrains.Annotations;

namespace Herdo.StrongTypes.DotNetStandard.StrongTypes
{
	/// <summary>
	/// Implements the strong type <see cref="BooleanStrongType" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(BooleanStrongType.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(BooleanStrongType.SystemTextJsonConverter))]
	public partial struct BooleanStrongType : IEquatable<BooleanStrongType>, IComparable<BooleanStrongType>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.Boolean V { get; set; }

		[ExcludeFromCodeCoverage]
		private BooleanStrongType(System.Boolean value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private BooleanStrongType(SerializationInfo info, StreamingContext context)
		{
            V = (System.Boolean)info.GetValue("v", typeof(System.Boolean));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="BooleanStrongType"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator BooleanStrongType(System.Boolean value)
	    {
	        return new BooleanStrongType(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Boolean"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.Boolean(BooleanStrongType value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="BooleanStrongType"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(BooleanStrongType other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return this.V == other.V;
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
			return Equals((BooleanStrongType)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="BooleanStrongType"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="BooleanStrongType"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="BooleanStrongType"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(BooleanStrongType other)
		{
			if (Equals(null, V))
				return 1;
			return V.CompareTo(other.V);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(BooleanStrongType first, BooleanStrongType second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

			return first.V == second.V;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(BooleanStrongType first, BooleanStrongType second)
	    {
	        return !(first == second);
	    }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object)V == null)
#pragma warning disable CS8603 // Possible null reference return.
	            return null;
#pragma warning restore CS8603 // Possible null reference return.
	        return V.ToString();
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", V);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
#pragma warning disable CS8603 // Possible null reference return.
	        return null;
#pragma warning restore CS8603 // Possible null reference return.
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        V = (System.Boolean)reader.ReadElementContentAs(typeof(System.Boolean), null);
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(V));
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (BooleanStrongType)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(BooleanStrongType);
                instance.V = (System.Boolean) Convert.ChangeType(reader.Value, typeof(System.Boolean));
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(BooleanStrongType);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<BooleanStrongType>
        {
		    [ExcludeFromCodeCoverage]
            public override BooleanStrongType Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
            {
                return (BooleanStrongType)reader.GetBoolean();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer, BooleanStrongType value, System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteBooleanValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="ByteStrongType" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(ByteStrongType.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(ByteStrongType.SystemTextJsonConverter))]
	public partial struct ByteStrongType : IEquatable<ByteStrongType>, IComparable<ByteStrongType>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.Byte V { get; set; }

		[ExcludeFromCodeCoverage]
		private ByteStrongType(System.Byte value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private ByteStrongType(SerializationInfo info, StreamingContext context)
		{
            V = (System.Byte)info.GetValue("v", typeof(System.Byte));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="ByteStrongType"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator ByteStrongType(System.Byte value)
	    {
	        return new ByteStrongType(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Byte"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.Byte(ByteStrongType value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="ByteStrongType"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(ByteStrongType other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return this.V == other.V;
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
			return Equals((ByteStrongType)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="ByteStrongType"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="ByteStrongType"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="ByteStrongType"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(ByteStrongType other)
		{
			if (Equals(null, V))
				return 1;
			return V.CompareTo(other.V);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(ByteStrongType first, ByteStrongType second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

			return first.V == second.V;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(ByteStrongType first, ByteStrongType second)
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
        public static bool operator <(ByteStrongType first, ByteStrongType second)
	    {
	        return first.V < second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is greater than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >(ByteStrongType first, ByteStrongType second)
	    {
	        return first.V > second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is less than or equal to the second operand.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator <=(ByteStrongType first, ByteStrongType second)
	    {
	        return first.V <= second.V;
	    }

        /// <summary>
        /// Checks if the first operand is greater than or equal to the second operand.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >=(ByteStrongType first, ByteStrongType second)
	    {
	        return first.V >= second.V;
        }

        /// <summary>
        /// Adds the two summands.
        /// </summary>
        /// <param name="summand1">The left operand.</param>
        /// <param name="summand2">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the sum failed.</exception>
        /// <returns>The sum.</returns>
        [ExcludeFromCodeCoverage]
        public static ByteStrongType operator +(ByteStrongType summand1, ByteStrongType summand2)
        {
            return (ByteStrongType) (summand1.V + summand2.V);
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
        [ExcludeFromCodeCoverage]
        public static ByteStrongType operator -(ByteStrongType minuend, ByteStrongType subtrahend)
        {
            return (ByteStrongType)(minuend.V - subtrahend.V);
        }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static ByteStrongType operator ++(ByteStrongType value)
	    {
	        return (ByteStrongType) (++value.V);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static ByteStrongType operator --(ByteStrongType value)
	    {
	        return (ByteStrongType) (--value.V);
        }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object)V == null)
#pragma warning disable CS8603 // Possible null reference return.
	            return null;
#pragma warning restore CS8603 // Possible null reference return.
	        return V.ToString();
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", V);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
#pragma warning disable CS8603 // Possible null reference return.
	        return null;
#pragma warning restore CS8603 // Possible null reference return.
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        V = (System.Byte)reader.ReadElementContentAs(typeof(System.Byte), null);
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(V));
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (ByteStrongType)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(ByteStrongType);
                instance.V = (System.Byte) Convert.ChangeType(reader.Value, typeof(System.Byte));
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(ByteStrongType);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<ByteStrongType>
        {
		    [ExcludeFromCodeCoverage]
            public override ByteStrongType Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
            {
                return (ByteStrongType)reader.GetByte();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer, ByteStrongType value, System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="DecimalStrongType" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(DecimalStrongType.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(DecimalStrongType.SystemTextJsonConverter))]
	public partial struct DecimalStrongType : IEquatable<DecimalStrongType>, IComparable<DecimalStrongType>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.Decimal V { get; set; }

		[ExcludeFromCodeCoverage]
		private DecimalStrongType(System.Decimal value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private DecimalStrongType(SerializationInfo info, StreamingContext context)
		{
            V = (System.Decimal)info.GetValue("v", typeof(System.Decimal));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="DecimalStrongType"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator DecimalStrongType(System.Decimal value)
	    {
	        return new DecimalStrongType(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Decimal"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.Decimal(DecimalStrongType value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="DecimalStrongType"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(DecimalStrongType other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return this.V == other.V;
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
			return Equals((DecimalStrongType)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="DecimalStrongType"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="DecimalStrongType"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="DecimalStrongType"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(DecimalStrongType other)
		{
			if (Equals(null, V))
				return 1;
			return V.CompareTo(other.V);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(DecimalStrongType first, DecimalStrongType second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

			return first.V == second.V;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(DecimalStrongType first, DecimalStrongType second)
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
        public static bool operator <(DecimalStrongType first, DecimalStrongType second)
	    {
	        return first.V < second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is greater than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >(DecimalStrongType first, DecimalStrongType second)
	    {
	        return first.V > second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is less than or equal to the second operand.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator <=(DecimalStrongType first, DecimalStrongType second)
	    {
	        return first.V <= second.V;
	    }

        /// <summary>
        /// Checks if the first operand is greater than or equal to the second operand.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >=(DecimalStrongType first, DecimalStrongType second)
	    {
	        return first.V >= second.V;
        }

        /// <summary>
        /// Adds the two summands.
        /// </summary>
        /// <param name="summand1">The left operand.</param>
        /// <param name="summand2">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the sum failed.</exception>
        /// <returns>The sum.</returns>
        [ExcludeFromCodeCoverage]
        public static DecimalStrongType operator +(DecimalStrongType summand1, DecimalStrongType summand2)
        {
            return (DecimalStrongType) (summand1.V + summand2.V);
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
        [ExcludeFromCodeCoverage]
        public static DecimalStrongType operator -(DecimalStrongType minuend, DecimalStrongType subtrahend)
        {
            return (DecimalStrongType)(minuend.V - subtrahend.V);
        }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static DecimalStrongType operator ++(DecimalStrongType value)
	    {
	        return (DecimalStrongType) (++value.V);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static DecimalStrongType operator --(DecimalStrongType value)
	    {
	        return (DecimalStrongType) (--value.V);
        }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object)V == null)
#pragma warning disable CS8603 // Possible null reference return.
	            return null;
#pragma warning restore CS8603 // Possible null reference return.
	        return V.ToString();
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", V);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
#pragma warning disable CS8603 // Possible null reference return.
	        return null;
#pragma warning restore CS8603 // Possible null reference return.
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        V = (System.Decimal)reader.ReadElementContentAs(typeof(System.Decimal), null);
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(V));
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (DecimalStrongType)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(DecimalStrongType);
                instance.V = (System.Decimal) Convert.ChangeType(reader.Value, typeof(System.Decimal));
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(DecimalStrongType);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<DecimalStrongType>
        {
		    [ExcludeFromCodeCoverage]
            public override DecimalStrongType Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
            {
                return (DecimalStrongType)reader.GetDecimal();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer, DecimalStrongType value, System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="DoubleStrongType" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(DoubleStrongType.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(DoubleStrongType.SystemTextJsonConverter))]
	public partial struct DoubleStrongType : IEquatable<DoubleStrongType>, IComparable<DoubleStrongType>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.Double V { get; set; }

		[ExcludeFromCodeCoverage]
		private DoubleStrongType(System.Double value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private DoubleStrongType(SerializationInfo info, StreamingContext context)
		{
            V = (System.Double)info.GetValue("v", typeof(System.Double));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="DoubleStrongType"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator DoubleStrongType(System.Double value)
	    {
	        return new DoubleStrongType(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Double"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.Double(DoubleStrongType value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="DoubleStrongType"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(DoubleStrongType other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return Math.Abs(this.V - this.V) < System.Double.Epsilon;
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
			return Equals((DoubleStrongType)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="DoubleStrongType"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="DoubleStrongType"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="DoubleStrongType"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(DoubleStrongType other)
		{
			if (Equals(null, V))
				return 1;
			return V.CompareTo(other.V);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(DoubleStrongType first, DoubleStrongType second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

			return Math.Abs(first.V - first.V) < System.Double.Epsilon;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(DoubleStrongType first, DoubleStrongType second)
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
        public static bool operator <(DoubleStrongType first, DoubleStrongType second)
	    {
	        return first.V < second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is greater than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >(DoubleStrongType first, DoubleStrongType second)
	    {
	        return first.V > second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is less than or equal to the second operand.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator <=(DoubleStrongType first, DoubleStrongType second)
	    {
	        return first.V <= second.V;
	    }

        /// <summary>
        /// Checks if the first operand is greater than or equal to the second operand.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >=(DoubleStrongType first, DoubleStrongType second)
	    {
	        return first.V >= second.V;
        }

        /// <summary>
        /// Adds the two summands.
        /// </summary>
        /// <param name="summand1">The left operand.</param>
        /// <param name="summand2">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the sum failed.</exception>
        /// <returns>The sum.</returns>
        [ExcludeFromCodeCoverage]
        public static DoubleStrongType operator +(DoubleStrongType summand1, DoubleStrongType summand2)
        {
            return (DoubleStrongType) (summand1.V + summand2.V);
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
        [ExcludeFromCodeCoverage]
        public static DoubleStrongType operator -(DoubleStrongType minuend, DoubleStrongType subtrahend)
        {
            return (DoubleStrongType)(minuend.V - subtrahend.V);
        }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static DoubleStrongType operator ++(DoubleStrongType value)
	    {
	        return (DoubleStrongType) (++value.V);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static DoubleStrongType operator --(DoubleStrongType value)
	    {
	        return (DoubleStrongType) (--value.V);
        }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object)V == null)
#pragma warning disable CS8603 // Possible null reference return.
	            return null;
#pragma warning restore CS8603 // Possible null reference return.
	        return V.ToString();
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", V);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
#pragma warning disable CS8603 // Possible null reference return.
	        return null;
#pragma warning restore CS8603 // Possible null reference return.
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        V = (System.Double)reader.ReadElementContentAs(typeof(System.Double), null);
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(V));
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (DoubleStrongType)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(DoubleStrongType);
                instance.V = (System.Double) Convert.ChangeType(reader.Value, typeof(System.Double));
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(DoubleStrongType);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<DoubleStrongType>
        {
		    [ExcludeFromCodeCoverage]
            public override DoubleStrongType Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
            {
                return (DoubleStrongType)reader.GetDouble();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer, DoubleStrongType value, System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="GuidStrongType" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(GuidStrongType.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(GuidStrongType.SystemTextJsonConverter))]
	public partial struct GuidStrongType : IEquatable<GuidStrongType>, IComparable<GuidStrongType>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.Guid V { get; set; }

		[ExcludeFromCodeCoverage]
		private GuidStrongType(System.Guid value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private GuidStrongType(SerializationInfo info, StreamingContext context)
		{
            V = (System.Guid)info.GetValue("v", typeof(System.Guid));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="GuidStrongType"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator GuidStrongType(System.Guid value)
	    {
	        return new GuidStrongType(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Guid"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.Guid(GuidStrongType value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="GuidStrongType"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(GuidStrongType other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return this.V == other.V;
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
			return Equals((GuidStrongType)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="GuidStrongType"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="GuidStrongType"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="GuidStrongType"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(GuidStrongType other)
		{
			if (Equals(null, V))
				return 1;
			return V.CompareTo(other.V);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(GuidStrongType first, GuidStrongType second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

			return first.V == second.V;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(GuidStrongType first, GuidStrongType second)
	    {
	        return !(first == second);
	    }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object)V == null)
#pragma warning disable CS8603 // Possible null reference return.
	            return null;
#pragma warning restore CS8603 // Possible null reference return.
	        return V.ToString();
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", V);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
#pragma warning disable CS8603 // Possible null reference return.
	        return null;
#pragma warning restore CS8603 // Possible null reference return.
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        V = Guid.Parse((System.String)reader.ReadElementContentAs(typeof(System.String), null));
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(V));
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (GuidStrongType)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(GuidStrongType);
                instance.V = reader.Value == null ? default : Guid.Parse((string) reader.Value);
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(GuidStrongType);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<GuidStrongType>
        {
		    [ExcludeFromCodeCoverage]
            public override GuidStrongType Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
            {
                return (GuidStrongType)reader.GetGuid();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer, GuidStrongType value, System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteStringValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="Int16StrongType" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(Int16StrongType.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(Int16StrongType.SystemTextJsonConverter))]
	public partial struct Int16StrongType : IEquatable<Int16StrongType>, IComparable<Int16StrongType>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.Int16 V { get; set; }

		[ExcludeFromCodeCoverage]
		private Int16StrongType(System.Int16 value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private Int16StrongType(SerializationInfo info, StreamingContext context)
		{
            V = (System.Int16)info.GetValue("v", typeof(System.Int16));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="Int16StrongType"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator Int16StrongType(System.Int16 value)
	    {
	        return new Int16StrongType(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Int16"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.Int16(Int16StrongType value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="Int16StrongType"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(Int16StrongType other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return this.V == other.V;
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
			return Equals((Int16StrongType)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="Int16StrongType"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="Int16StrongType"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="Int16StrongType"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(Int16StrongType other)
		{
			if (Equals(null, V))
				return 1;
			return V.CompareTo(other.V);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(Int16StrongType first, Int16StrongType second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

			return first.V == second.V;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(Int16StrongType first, Int16StrongType second)
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
        public static bool operator <(Int16StrongType first, Int16StrongType second)
	    {
	        return first.V < second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is greater than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >(Int16StrongType first, Int16StrongType second)
	    {
	        return first.V > second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is less than or equal to the second operand.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator <=(Int16StrongType first, Int16StrongType second)
	    {
	        return first.V <= second.V;
	    }

        /// <summary>
        /// Checks if the first operand is greater than or equal to the second operand.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >=(Int16StrongType first, Int16StrongType second)
	    {
	        return first.V >= second.V;
        }

        /// <summary>
        /// Adds the two summands.
        /// </summary>
        /// <param name="summand1">The left operand.</param>
        /// <param name="summand2">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the sum failed.</exception>
        /// <returns>The sum.</returns>
        [ExcludeFromCodeCoverage]
        public static Int16StrongType operator +(Int16StrongType summand1, Int16StrongType summand2)
        {
            return (Int16StrongType) (summand1.V + summand2.V);
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
        [ExcludeFromCodeCoverage]
        public static Int16StrongType operator -(Int16StrongType minuend, Int16StrongType subtrahend)
        {
            return (Int16StrongType)(minuend.V - subtrahend.V);
        }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static Int16StrongType operator ++(Int16StrongType value)
	    {
	        return (Int16StrongType) (++value.V);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static Int16StrongType operator --(Int16StrongType value)
	    {
	        return (Int16StrongType) (--value.V);
        }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object)V == null)
#pragma warning disable CS8603 // Possible null reference return.
	            return null;
#pragma warning restore CS8603 // Possible null reference return.
	        return V.ToString();
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", V);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
#pragma warning disable CS8603 // Possible null reference return.
	        return null;
#pragma warning restore CS8603 // Possible null reference return.
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        V = (System.Int16)reader.ReadElementContentAs(typeof(System.Int16), null);
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(V));
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (Int16StrongType)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(Int16StrongType);
                instance.V = (System.Int16) Convert.ChangeType(reader.Value, typeof(System.Int16));
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(Int16StrongType);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<Int16StrongType>
        {
		    [ExcludeFromCodeCoverage]
            public override Int16StrongType Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
            {
                return (Int16StrongType)reader.GetInt16();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer, Int16StrongType value, System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="Int32StrongType" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(Int32StrongType.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(Int32StrongType.SystemTextJsonConverter))]
	public partial struct Int32StrongType : IEquatable<Int32StrongType>, IComparable<Int32StrongType>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.Int32 V { get; set; }

		[ExcludeFromCodeCoverage]
		private Int32StrongType(System.Int32 value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private Int32StrongType(SerializationInfo info, StreamingContext context)
		{
            V = (System.Int32)info.GetValue("v", typeof(System.Int32));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="Int32StrongType"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator Int32StrongType(System.Int32 value)
	    {
	        return new Int32StrongType(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Int32"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.Int32(Int32StrongType value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="Int32StrongType"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(Int32StrongType other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return this.V == other.V;
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
			return Equals((Int32StrongType)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="Int32StrongType"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="Int32StrongType"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="Int32StrongType"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(Int32StrongType other)
		{
			if (Equals(null, V))
				return 1;
			return V.CompareTo(other.V);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(Int32StrongType first, Int32StrongType second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

			return first.V == second.V;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(Int32StrongType first, Int32StrongType second)
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
        public static bool operator <(Int32StrongType first, Int32StrongType second)
	    {
	        return first.V < second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is greater than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >(Int32StrongType first, Int32StrongType second)
	    {
	        return first.V > second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is less than or equal to the second operand.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator <=(Int32StrongType first, Int32StrongType second)
	    {
	        return first.V <= second.V;
	    }

        /// <summary>
        /// Checks if the first operand is greater than or equal to the second operand.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >=(Int32StrongType first, Int32StrongType second)
	    {
	        return first.V >= second.V;
        }

        /// <summary>
        /// Adds the two summands.
        /// </summary>
        /// <param name="summand1">The left operand.</param>
        /// <param name="summand2">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the sum failed.</exception>
        /// <returns>The sum.</returns>
        [ExcludeFromCodeCoverage]
        public static Int32StrongType operator +(Int32StrongType summand1, Int32StrongType summand2)
        {
            return (Int32StrongType) (summand1.V + summand2.V);
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
        [ExcludeFromCodeCoverage]
        public static Int32StrongType operator -(Int32StrongType minuend, Int32StrongType subtrahend)
        {
            return (Int32StrongType)(minuend.V - subtrahend.V);
        }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static Int32StrongType operator ++(Int32StrongType value)
	    {
	        return (Int32StrongType) (++value.V);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static Int32StrongType operator --(Int32StrongType value)
	    {
	        return (Int32StrongType) (--value.V);
        }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object)V == null)
#pragma warning disable CS8603 // Possible null reference return.
	            return null;
#pragma warning restore CS8603 // Possible null reference return.
	        return V.ToString();
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", V);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
#pragma warning disable CS8603 // Possible null reference return.
	        return null;
#pragma warning restore CS8603 // Possible null reference return.
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        V = (System.Int32)reader.ReadElementContentAs(typeof(System.Int32), null);
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(V));
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (Int32StrongType)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(Int32StrongType);
                instance.V = (System.Int32) Convert.ChangeType(reader.Value, typeof(System.Int32));
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(Int32StrongType);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<Int32StrongType>
        {
		    [ExcludeFromCodeCoverage]
            public override Int32StrongType Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
            {
                return (Int32StrongType)reader.GetInt32();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer, Int32StrongType value, System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="Int64StrongType" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(Int64StrongType.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(Int64StrongType.SystemTextJsonConverter))]
	public partial struct Int64StrongType : IEquatable<Int64StrongType>, IComparable<Int64StrongType>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.Int64 V { get; set; }

		[ExcludeFromCodeCoverage]
		private Int64StrongType(System.Int64 value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private Int64StrongType(SerializationInfo info, StreamingContext context)
		{
            V = (System.Int64)info.GetValue("v", typeof(System.Int64));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="Int64StrongType"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator Int64StrongType(System.Int64 value)
	    {
	        return new Int64StrongType(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Int64"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.Int64(Int64StrongType value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="Int64StrongType"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(Int64StrongType other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return this.V == other.V;
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
			return Equals((Int64StrongType)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="Int64StrongType"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="Int64StrongType"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="Int64StrongType"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(Int64StrongType other)
		{
			if (Equals(null, V))
				return 1;
			return V.CompareTo(other.V);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(Int64StrongType first, Int64StrongType second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

			return first.V == second.V;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(Int64StrongType first, Int64StrongType second)
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
        public static bool operator <(Int64StrongType first, Int64StrongType second)
	    {
	        return first.V < second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is greater than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >(Int64StrongType first, Int64StrongType second)
	    {
	        return first.V > second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is less than or equal to the second operand.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator <=(Int64StrongType first, Int64StrongType second)
	    {
	        return first.V <= second.V;
	    }

        /// <summary>
        /// Checks if the first operand is greater than or equal to the second operand.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >=(Int64StrongType first, Int64StrongType second)
	    {
	        return first.V >= second.V;
        }

        /// <summary>
        /// Adds the two summands.
        /// </summary>
        /// <param name="summand1">The left operand.</param>
        /// <param name="summand2">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the sum failed.</exception>
        /// <returns>The sum.</returns>
        [ExcludeFromCodeCoverage]
        public static Int64StrongType operator +(Int64StrongType summand1, Int64StrongType summand2)
        {
            return (Int64StrongType) (summand1.V + summand2.V);
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
        [ExcludeFromCodeCoverage]
        public static Int64StrongType operator -(Int64StrongType minuend, Int64StrongType subtrahend)
        {
            return (Int64StrongType)(minuend.V - subtrahend.V);
        }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static Int64StrongType operator ++(Int64StrongType value)
	    {
	        return (Int64StrongType) (++value.V);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static Int64StrongType operator --(Int64StrongType value)
	    {
	        return (Int64StrongType) (--value.V);
        }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object)V == null)
#pragma warning disable CS8603 // Possible null reference return.
	            return null;
#pragma warning restore CS8603 // Possible null reference return.
	        return V.ToString();
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", V);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
#pragma warning disable CS8603 // Possible null reference return.
	        return null;
#pragma warning restore CS8603 // Possible null reference return.
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        V = (System.Int64)reader.ReadElementContentAs(typeof(System.Int64), null);
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(V));
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (Int64StrongType)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(Int64StrongType);
                instance.V = (System.Int64) Convert.ChangeType(reader.Value, typeof(System.Int64));
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(Int64StrongType);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<Int64StrongType>
        {
		    [ExcludeFromCodeCoverage]
            public override Int64StrongType Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
            {
                return (Int64StrongType)reader.GetInt64();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer, Int64StrongType value, System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="SByteStrongType" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(SByteStrongType.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(SByteStrongType.SystemTextJsonConverter))]
	public partial struct SByteStrongType : IEquatable<SByteStrongType>, IComparable<SByteStrongType>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.SByte V { get; set; }

		[ExcludeFromCodeCoverage]
		private SByteStrongType(System.SByte value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private SByteStrongType(SerializationInfo info, StreamingContext context)
		{
            V = (System.SByte)info.GetValue("v", typeof(System.SByte));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="SByteStrongType"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator SByteStrongType(System.SByte value)
	    {
	        return new SByteStrongType(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.SByte"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.SByte(SByteStrongType value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="SByteStrongType"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(SByteStrongType other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return this.V == other.V;
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
			return Equals((SByteStrongType)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="SByteStrongType"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="SByteStrongType"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="SByteStrongType"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(SByteStrongType other)
		{
			if (Equals(null, V))
				return 1;
			return V.CompareTo(other.V);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(SByteStrongType first, SByteStrongType second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

			return first.V == second.V;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(SByteStrongType first, SByteStrongType second)
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
        public static bool operator <(SByteStrongType first, SByteStrongType second)
	    {
	        return first.V < second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is greater than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >(SByteStrongType first, SByteStrongType second)
	    {
	        return first.V > second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is less than or equal to the second operand.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator <=(SByteStrongType first, SByteStrongType second)
	    {
	        return first.V <= second.V;
	    }

        /// <summary>
        /// Checks if the first operand is greater than or equal to the second operand.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >=(SByteStrongType first, SByteStrongType second)
	    {
	        return first.V >= second.V;
        }

        /// <summary>
        /// Adds the two summands.
        /// </summary>
        /// <param name="summand1">The left operand.</param>
        /// <param name="summand2">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the sum failed.</exception>
        /// <returns>The sum.</returns>
        [ExcludeFromCodeCoverage]
        public static SByteStrongType operator +(SByteStrongType summand1, SByteStrongType summand2)
        {
            return (SByteStrongType) (summand1.V + summand2.V);
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
        [ExcludeFromCodeCoverage]
        public static SByteStrongType operator -(SByteStrongType minuend, SByteStrongType subtrahend)
        {
            return (SByteStrongType)(minuend.V - subtrahend.V);
        }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static SByteStrongType operator ++(SByteStrongType value)
	    {
	        return (SByteStrongType) (++value.V);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static SByteStrongType operator --(SByteStrongType value)
	    {
	        return (SByteStrongType) (--value.V);
        }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object)V == null)
#pragma warning disable CS8603 // Possible null reference return.
	            return null;
#pragma warning restore CS8603 // Possible null reference return.
	        return V.ToString();
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", V);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
#pragma warning disable CS8603 // Possible null reference return.
	        return null;
#pragma warning restore CS8603 // Possible null reference return.
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        V = (System.SByte)reader.ReadElementContentAs(typeof(System.SByte), null);
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(V));
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (SByteStrongType)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(SByteStrongType);
                instance.V = (System.SByte) Convert.ChangeType(reader.Value, typeof(System.SByte));
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(SByteStrongType);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<SByteStrongType>
        {
		    [ExcludeFromCodeCoverage]
            public override SByteStrongType Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
            {
                return (SByteStrongType)reader.GetSByte();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer, SByteStrongType value, System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="SingleStrongType" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(SingleStrongType.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(SingleStrongType.SystemTextJsonConverter))]
	public partial struct SingleStrongType : IEquatable<SingleStrongType>, IComparable<SingleStrongType>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.Single V { get; set; }

		[ExcludeFromCodeCoverage]
		private SingleStrongType(System.Single value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private SingleStrongType(SerializationInfo info, StreamingContext context)
		{
            V = (System.Single)info.GetValue("v", typeof(System.Single));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="SingleStrongType"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator SingleStrongType(System.Single value)
	    {
	        return new SingleStrongType(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Single"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.Single(SingleStrongType value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="SingleStrongType"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(SingleStrongType other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return Math.Abs(this.V - this.V) < System.Single.Epsilon;
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
			return Equals((SingleStrongType)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="SingleStrongType"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="SingleStrongType"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="SingleStrongType"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(SingleStrongType other)
		{
			if (Equals(null, V))
				return 1;
			return V.CompareTo(other.V);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(SingleStrongType first, SingleStrongType second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

			return Math.Abs(first.V - first.V) < System.Single.Epsilon;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(SingleStrongType first, SingleStrongType second)
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
        public static bool operator <(SingleStrongType first, SingleStrongType second)
	    {
	        return first.V < second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is greater than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >(SingleStrongType first, SingleStrongType second)
	    {
	        return first.V > second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is less than or equal to the second operand.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator <=(SingleStrongType first, SingleStrongType second)
	    {
	        return first.V <= second.V;
	    }

        /// <summary>
        /// Checks if the first operand is greater than or equal to the second operand.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >=(SingleStrongType first, SingleStrongType second)
	    {
	        return first.V >= second.V;
        }

        /// <summary>
        /// Adds the two summands.
        /// </summary>
        /// <param name="summand1">The left operand.</param>
        /// <param name="summand2">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the sum failed.</exception>
        /// <returns>The sum.</returns>
        [ExcludeFromCodeCoverage]
        public static SingleStrongType operator +(SingleStrongType summand1, SingleStrongType summand2)
        {
            return (SingleStrongType) (summand1.V + summand2.V);
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
        [ExcludeFromCodeCoverage]
        public static SingleStrongType operator -(SingleStrongType minuend, SingleStrongType subtrahend)
        {
            return (SingleStrongType)(minuend.V - subtrahend.V);
        }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static SingleStrongType operator ++(SingleStrongType value)
	    {
	        return (SingleStrongType) (++value.V);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static SingleStrongType operator --(SingleStrongType value)
	    {
	        return (SingleStrongType) (--value.V);
        }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object)V == null)
#pragma warning disable CS8603 // Possible null reference return.
	            return null;
#pragma warning restore CS8603 // Possible null reference return.
	        return V.ToString();
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", V);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
#pragma warning disable CS8603 // Possible null reference return.
	        return null;
#pragma warning restore CS8603 // Possible null reference return.
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        V = (System.Single)reader.ReadElementContentAs(typeof(System.Single), null);
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(V));
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (SingleStrongType)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(SingleStrongType);
                instance.V = (System.Single) Convert.ChangeType(reader.Value, typeof(System.Single));
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(SingleStrongType);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<SingleStrongType>
        {
		    [ExcludeFromCodeCoverage]
            public override SingleStrongType Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
            {
                return (SingleStrongType)reader.GetSingle();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer, SingleStrongType value, System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="StringStrongType" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(StringStrongType.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(StringStrongType.SystemTextJsonConverter))]
	public partial struct StringStrongType : IEquatable<StringStrongType>, IComparable<StringStrongType>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.String V { get; set; }

		[ExcludeFromCodeCoverage]
		private StringStrongType(System.String value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private StringStrongType(SerializationInfo info, StreamingContext context)
		{
            V = (System.String)info.GetValue("v", typeof(System.String));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="StringStrongType"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator StringStrongType(System.String value)
	    {
	        return new StringStrongType(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.String"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.String(StringStrongType value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="StringStrongType"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(StringStrongType other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return this.V == other.V;
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
			return Equals((StringStrongType)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="StringStrongType"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="StringStrongType"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="StringStrongType"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(StringStrongType other)
		{
			if (Equals(null, V))
				return 1;
			return V.CompareTo(other.V);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(StringStrongType first, StringStrongType second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

			return first.V == second.V;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(StringStrongType first, StringStrongType second)
	    {
	        return !(first == second);
	    }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object)V == null)
#pragma warning disable CS8603 // Possible null reference return.
	            return null;
#pragma warning restore CS8603 // Possible null reference return.
	        return V.ToString();
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", V);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
#pragma warning disable CS8603 // Possible null reference return.
	        return null;
#pragma warning restore CS8603 // Possible null reference return.
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        V = (System.String)reader.ReadElementContentAs(typeof(System.String), null);
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(V);
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (StringStrongType)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(StringStrongType);
                instance.V = (System.String) Convert.ChangeType(reader.Value, typeof(System.String));
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(StringStrongType);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<StringStrongType>
        {
		    [ExcludeFromCodeCoverage]
            public override StringStrongType Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
            {
                return (StringStrongType)reader.GetString();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer, StringStrongType value, System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteStringValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="UInt16StrongType" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(UInt16StrongType.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(UInt16StrongType.SystemTextJsonConverter))]
	public partial struct UInt16StrongType : IEquatable<UInt16StrongType>, IComparable<UInt16StrongType>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.UInt16 V { get; set; }

		[ExcludeFromCodeCoverage]
		private UInt16StrongType(System.UInt16 value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private UInt16StrongType(SerializationInfo info, StreamingContext context)
		{
            V = (System.UInt16)info.GetValue("v", typeof(System.UInt16));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="UInt16StrongType"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator UInt16StrongType(System.UInt16 value)
	    {
	        return new UInt16StrongType(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.UInt16"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.UInt16(UInt16StrongType value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="UInt16StrongType"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(UInt16StrongType other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return this.V == other.V;
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
			return Equals((UInt16StrongType)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="UInt16StrongType"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="UInt16StrongType"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="UInt16StrongType"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(UInt16StrongType other)
		{
			if (Equals(null, V))
				return 1;
			return V.CompareTo(other.V);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(UInt16StrongType first, UInt16StrongType second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

			return first.V == second.V;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(UInt16StrongType first, UInt16StrongType second)
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
        public static bool operator <(UInt16StrongType first, UInt16StrongType second)
	    {
	        return first.V < second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is greater than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >(UInt16StrongType first, UInt16StrongType second)
	    {
	        return first.V > second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is less than or equal to the second operand.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator <=(UInt16StrongType first, UInt16StrongType second)
	    {
	        return first.V <= second.V;
	    }

        /// <summary>
        /// Checks if the first operand is greater than or equal to the second operand.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >=(UInt16StrongType first, UInt16StrongType second)
	    {
	        return first.V >= second.V;
        }

        /// <summary>
        /// Adds the two summands.
        /// </summary>
        /// <param name="summand1">The left operand.</param>
        /// <param name="summand2">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the sum failed.</exception>
        /// <returns>The sum.</returns>
        [ExcludeFromCodeCoverage]
        public static UInt16StrongType operator +(UInt16StrongType summand1, UInt16StrongType summand2)
        {
            return (UInt16StrongType) (summand1.V + summand2.V);
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
        [ExcludeFromCodeCoverage]
        public static UInt16StrongType operator -(UInt16StrongType minuend, UInt16StrongType subtrahend)
        {
            return (UInt16StrongType)(minuend.V - subtrahend.V);
        }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static UInt16StrongType operator ++(UInt16StrongType value)
	    {
	        return (UInt16StrongType) (++value.V);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static UInt16StrongType operator --(UInt16StrongType value)
	    {
	        return (UInt16StrongType) (--value.V);
        }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object)V == null)
#pragma warning disable CS8603 // Possible null reference return.
	            return null;
#pragma warning restore CS8603 // Possible null reference return.
	        return V.ToString();
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", V);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
#pragma warning disable CS8603 // Possible null reference return.
	        return null;
#pragma warning restore CS8603 // Possible null reference return.
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        V = (System.UInt16)reader.ReadElementContentAs(typeof(System.UInt16), null);
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(V));
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (UInt16StrongType)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(UInt16StrongType);
                instance.V = (System.UInt16) Convert.ChangeType(reader.Value, typeof(System.UInt16));
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(UInt16StrongType);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<UInt16StrongType>
        {
		    [ExcludeFromCodeCoverage]
            public override UInt16StrongType Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
            {
                return (UInt16StrongType)reader.GetUInt16();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer, UInt16StrongType value, System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="UInt32StrongType" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(UInt32StrongType.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(UInt32StrongType.SystemTextJsonConverter))]
	public partial struct UInt32StrongType : IEquatable<UInt32StrongType>, IComparable<UInt32StrongType>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.UInt32 V { get; set; }

		[ExcludeFromCodeCoverage]
		private UInt32StrongType(System.UInt32 value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private UInt32StrongType(SerializationInfo info, StreamingContext context)
		{
            V = (System.UInt32)info.GetValue("v", typeof(System.UInt32));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="UInt32StrongType"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator UInt32StrongType(System.UInt32 value)
	    {
	        return new UInt32StrongType(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.UInt32"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.UInt32(UInt32StrongType value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="UInt32StrongType"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(UInt32StrongType other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return this.V == other.V;
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
			return Equals((UInt32StrongType)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="UInt32StrongType"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="UInt32StrongType"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="UInt32StrongType"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(UInt32StrongType other)
		{
			if (Equals(null, V))
				return 1;
			return V.CompareTo(other.V);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(UInt32StrongType first, UInt32StrongType second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

			return first.V == second.V;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(UInt32StrongType first, UInt32StrongType second)
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
        public static bool operator <(UInt32StrongType first, UInt32StrongType second)
	    {
	        return first.V < second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is greater than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >(UInt32StrongType first, UInt32StrongType second)
	    {
	        return first.V > second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is less than or equal to the second operand.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator <=(UInt32StrongType first, UInt32StrongType second)
	    {
	        return first.V <= second.V;
	    }

        /// <summary>
        /// Checks if the first operand is greater than or equal to the second operand.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >=(UInt32StrongType first, UInt32StrongType second)
	    {
	        return first.V >= second.V;
        }

        /// <summary>
        /// Adds the two summands.
        /// </summary>
        /// <param name="summand1">The left operand.</param>
        /// <param name="summand2">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the sum failed.</exception>
        /// <returns>The sum.</returns>
        [ExcludeFromCodeCoverage]
        public static UInt32StrongType operator +(UInt32StrongType summand1, UInt32StrongType summand2)
        {
            return (UInt32StrongType) (summand1.V + summand2.V);
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
        [ExcludeFromCodeCoverage]
        public static UInt32StrongType operator -(UInt32StrongType minuend, UInt32StrongType subtrahend)
        {
            return (UInt32StrongType)(minuend.V - subtrahend.V);
        }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static UInt32StrongType operator ++(UInt32StrongType value)
	    {
	        return (UInt32StrongType) (++value.V);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static UInt32StrongType operator --(UInt32StrongType value)
	    {
	        return (UInt32StrongType) (--value.V);
        }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object)V == null)
#pragma warning disable CS8603 // Possible null reference return.
	            return null;
#pragma warning restore CS8603 // Possible null reference return.
	        return V.ToString();
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", V);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
#pragma warning disable CS8603 // Possible null reference return.
	        return null;
#pragma warning restore CS8603 // Possible null reference return.
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        V = (System.UInt32)reader.ReadElementContentAs(typeof(System.UInt32), null);
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(V));
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (UInt32StrongType)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(UInt32StrongType);
                instance.V = (System.UInt32) Convert.ChangeType(reader.Value, typeof(System.UInt32));
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(UInt32StrongType);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<UInt32StrongType>
        {
		    [ExcludeFromCodeCoverage]
            public override UInt32StrongType Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
            {
                return (UInt32StrongType)reader.GetUInt32();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer, UInt32StrongType value, System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="UInt64StrongType" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(UInt64StrongType.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(UInt64StrongType.SystemTextJsonConverter))]
	public partial struct UInt64StrongType : IEquatable<UInt64StrongType>, IComparable<UInt64StrongType>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.UInt64 V { get; set; }

		[ExcludeFromCodeCoverage]
		private UInt64StrongType(System.UInt64 value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private UInt64StrongType(SerializationInfo info, StreamingContext context)
		{
            V = (System.UInt64)info.GetValue("v", typeof(System.UInt64));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="UInt64StrongType"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator UInt64StrongType(System.UInt64 value)
	    {
	        return new UInt64StrongType(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.UInt64"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.UInt64(UInt64StrongType value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="UInt64StrongType"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(UInt64StrongType other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return this.V == other.V;
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
			return Equals((UInt64StrongType)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="UInt64StrongType"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="UInt64StrongType"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="UInt64StrongType"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(UInt64StrongType other)
		{
			if (Equals(null, V))
				return 1;
			return V.CompareTo(other.V);
		}

        /// <summary>
        /// Checks if both operands are equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>True</b>, if both operands are equal; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator ==(UInt64StrongType first, UInt64StrongType second)
	    {
	        if (ReferenceEquals(first, second))
	            return true;

			return first.V == second.V;
	    }

        /// <summary>
        /// Checks if both operands are not equal.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
        /// <returns><b>False</b>, if both operands are equal; otherwise, <b>true</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator !=(UInt64StrongType first, UInt64StrongType second)
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
        public static bool operator <(UInt64StrongType first, UInt64StrongType second)
	    {
	        return first.V < second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is greater than the second one.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >(UInt64StrongType first, UInt64StrongType second)
	    {
	        return first.V > second.V;
	    }

	    /// <summary>
	    /// Checks if the first operand is less than or equal to the second operand.
	    /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is less than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator <=(UInt64StrongType first, UInt64StrongType second)
	    {
	        return first.V <= second.V;
	    }

        /// <summary>
        /// Checks if the first operand is greater than or equal to the second operand.
        /// </summary>
        /// <param name="first">The first operand.</param>
        /// <param name="second">The second operand.</param>
	    /// <returns><b>True</b>, if the <paramref name="first"/> operand is greater than or equal to the <paramref name="second"/>; otherwise, <b>false</b>.</returns>
        [ExcludeFromCodeCoverage]
        public static bool operator >=(UInt64StrongType first, UInt64StrongType second)
	    {
	        return first.V >= second.V;
        }

        /// <summary>
        /// Adds the two summands.
        /// </summary>
        /// <param name="summand1">The left operand.</param>
        /// <param name="summand2">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the sum failed.</exception>
        /// <returns>The sum.</returns>
        [ExcludeFromCodeCoverage]
        public static UInt64StrongType operator +(UInt64StrongType summand1, UInt64StrongType summand2)
        {
            return (UInt64StrongType) (summand1.V + summand2.V);
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
        [ExcludeFromCodeCoverage]
        public static UInt64StrongType operator -(UInt64StrongType minuend, UInt64StrongType subtrahend)
        {
            return (UInt64StrongType)(minuend.V - subtrahend.V);
        }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static UInt64StrongType operator ++(UInt64StrongType value)
	    {
	        return (UInt64StrongType) (++value.V);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static UInt64StrongType operator --(UInt64StrongType value)
	    {
	        return (UInt64StrongType) (--value.V);
        }

		/// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
		[ExcludeFromCodeCoverage]
	    public override string ToString()
	    {
	        if ((object)V == null)
#pragma warning disable CS8603 // Possible null reference return.
	            return null;
#pragma warning restore CS8603 // Possible null reference return.
	        return V.ToString();
	    }
				
		[ExcludeFromCodeCoverage]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("v", V);
		}
		
		[ExcludeFromCodeCoverage]
		XmlSchema IXmlSerializable.GetSchema()
	    {
#pragma warning disable CS8603 // Possible null reference return.
	        return null;
#pragma warning restore CS8603 // Possible null reference return.
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.ReadXml(XmlReader reader)
	    {
	        V = (System.UInt64)reader.ReadElementContentAs(typeof(System.UInt64), null);
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(V));
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (UInt64StrongType)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(UInt64StrongType);
                instance.V = reader.Value == null ? default : (System.UInt64)(System.Numerics.BigInteger)reader.Value;
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(UInt64StrongType);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<UInt64StrongType>
        {
		    [ExcludeFromCodeCoverage]
            public override UInt64StrongType Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
            {
                return (UInt64StrongType)reader.GetUInt64();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer, UInt64StrongType value, System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }
}