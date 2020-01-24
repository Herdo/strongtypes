// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable InheritdocConsiderUsage
// ReSharper disable RedundantNameQualifier
// ReSharper disable HeuristicUnreachableCode
// ReSharper disable ReferenceEqualsWithValueType
// ReSharper disable ConditionIsAlwaysTrueOrFalse
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable RedundantCast.0

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
	/// Implements the strong type <see cref="UserID" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(UserID.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(UserID.SystemTextJsonConverter))]
	public partial struct UserID : IEquatable<UserID>, IComparable<UserID>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.Int32 V { get; set; }

		[ExcludeFromCodeCoverage]
		private UserID(System.Int32 value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private UserID(SerializationInfo info, StreamingContext context)
		{
            V = (System.Int32)info.GetValue("v", typeof(System.Int32));
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
	        return value.V;
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
			return V == other.V;
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
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="UserID"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="UserID"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(UserID other)
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
        public static bool operator ==(UserID first, UserID second)
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
	        return first.V < second.V;
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
	        return first.V > second.V;
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
	        return first.V <= second.V;
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
        public static UserID operator +(UserID summand1, UserID summand2)
        {
            return (UserID) (summand1.V + summand2.V);
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
            return (UserID)(minuend.V - subtrahend.V);
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
	        return (UserID) (++value.V);
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
	        return (UserID) (--value.V);
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
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer,
                                           object value,
                                           Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (UserID)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader,
                                            Type objectType,
                                            object existingValue,
                                            Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(UserID);
                instance.V = (System.Int32) Convert.ChangeType(reader.Value, TypeCode.Int32);
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(CustomerID);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<UserID>
        {
		    [ExcludeFromCodeCoverage]
            public override UserID Read(ref System.Text.Json.Utf8JsonReader reader,
                                       Type typeToConvert,
                                       System.Text.Json.JsonSerializerOptions options)
            {
                return (UserID)reader.GetInt32();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer,
                                       UserID value,
                                       System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }

	/// <summary>
	/// CustomerID with consistent formatting across all applications.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(CustomerID.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(CustomerID.SystemTextJsonConverter))]
	public partial struct CustomerID : IEquatable<CustomerID>, IComparable<CustomerID>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.Int32 V { get; set; }

		[ExcludeFromCodeCoverage]
		private CustomerID(System.Int32 value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private CustomerID(SerializationInfo info, StreamingContext context)
		{
            V = (System.Int32)info.GetValue("v", typeof(System.Int32));
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
	        return value.V;
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
			return V == other.V;
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
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="CustomerID"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="CustomerID"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(CustomerID other)
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
        public static bool operator ==(CustomerID first, CustomerID second)
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
	        return (CustomerID) (++value.V);
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
	        return V.ToString("D5");
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
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer,
                                           object value,
                                           Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (CustomerID)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader,
                                            Type objectType,
                                            object existingValue,
                                            Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(CustomerID);
                instance.V = (System.Int32) Convert.ChangeType(reader.Value, TypeCode.Int32);
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(CustomerID);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<CustomerID>
        {
		    [ExcludeFromCodeCoverage]
            public override CustomerID Read(ref System.Text.Json.Utf8JsonReader reader,
                                       Type typeToConvert,
                                       System.Text.Json.JsonSerializerOptions options)
            {
                return (CustomerID)reader.GetInt32();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer,
                                       CustomerID value,
                                       System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="Year" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(Year.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(Year.SystemTextJsonConverter))]
	public partial struct Year : IEquatable<Year>, IComparable<Year>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.Int16 V { get; set; }

		[ExcludeFromCodeCoverage]
		private Year(System.Int16 value)
	    {
	        V = Validate(value);
	    }

		[ExcludeFromCodeCoverage]
		private Year(SerializationInfo info, StreamingContext context)
		{
            V = Validate((System.Int16)info.GetValue("v", typeof(System.Int16)));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="Year"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator Year(System.Int16 value)
	    {
	        return new Year(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Int16"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.Int16(Year value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="Year"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(Year other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return V == other.V;
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
			return Equals((Year)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="Year"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="Year"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="Year"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(Year other)
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
        public static bool operator ==(Year first, Year second)
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
        [ExcludeFromCodeCoverage]
        public static bool operator <(Year first, Year second)
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
        public static bool operator >(Year first, Year second)
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
        public static bool operator <=(Year first, Year second)
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
        public static bool operator >=(Year first, Year second)
	    {
	        return first.V >= second.V;
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
        [ExcludeFromCodeCoverage]
        public static Year operator -(Year minuend, Year subtrahend)
        {
            return (Year)(minuend.V - subtrahend.V);
        }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static Year operator ++(Year value)
	    {
	        return (Year) (++value.V);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static Year operator --(Year value)
	    {
	        return (Year) (--value.V);
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
		private static System.Int16 Validate(System.Int16 value)
		{
			if (!IsValid(value, out var validationError))
				throw new InvalidCastException("Invalid cast into the strong type. The validation failed. Error: " + validationError);
			return value;
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
	        V = Validate((System.Int16)reader.ReadElementContentAs(typeof(System.Int16), null));
	    }
		
		[ExcludeFromCodeCoverage]
	    void IXmlSerializable.WriteXml(XmlWriter writer)
	    {
            writer.WriteString(XmlConvert.ToString(V));
	    }

		public sealed class NewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter
        {
		    [ExcludeFromCodeCoverage]
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer,
                                           object value,
                                           Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (Year)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader,
                                            Type objectType,
                                            object existingValue,
                                            Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(Year);
                instance.V = (System.Int16) Convert.ChangeType(reader.Value, TypeCode.Int16);
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(CustomerID);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<Year>
        {
		    [ExcludeFromCodeCoverage]
            public override Year Read(ref System.Text.Json.Utf8JsonReader reader,
                                       Type typeToConvert,
                                       System.Text.Json.JsonSerializerOptions options)
            {
                return (Year)reader.GetInt16();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer,
                                       Year value,
                                       System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }

	/// <summary>
	/// Implements the strong type <see cref="Years" />.
	/// </summary>
	[GeneratedCode("Herdo.StrongTypes.StrongTypeGenerator", "2.0.0")]
	[Serializable]
	[Newtonsoft.Json.JsonConverter(typeof(Years.NewtonsoftJsonConverter))]
	[System.Text.Json.Serialization.JsonConverter(typeof(Years.SystemTextJsonConverter))]
	public partial struct Years : IEquatable<Years>, IComparable<Years>, ISerializable, IXmlSerializable
	{
        /// <summary>
        /// Actual backing property which holds the value.
        /// </summary>
        /// <remarks>This property is basically readonly, but must be non-readonly due to the XML-deserialization which will be called from outside the constructor.</remarks>
        [UsedImplicitly]
		public System.Int16 V { get; set; }

		[ExcludeFromCodeCoverage]
		private Years(System.Int16 value)
	    {
	        V = value;
	    }

		[ExcludeFromCodeCoverage]
		private Years(SerializationInfo info, StreamingContext context)
		{
            V = (System.Int16)info.GetValue("v", typeof(System.Int16));
		}

	    /// <summary>
	    /// Converts the weak type into a <see cref="Years"/> instance.
	    /// </summary>
	    /// <param name="value">The value to convert.</param>
	    /// <returns>A new instance of the strong type.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator Years(System.Int16 value)
	    {
	        return new Years(value);
	    }

	    /// <summary>
	    /// Converts the strong type into a <see cref="System.Int16"/> value.
	    /// </summary>
	    /// <param name="value">The instance to convert.</param>
	    /// <returns>The converted value.</returns>
		[ExcludeFromCodeCoverage]
	    public static explicit operator System.Int16(Years value)
	    {
	        return value.V;
	    }

		/// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="Years"/> object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns><b>true</b> if <paramref name="other"/> is equal to this instance; otherwise, <b>false</b>.</returns>
		[ExcludeFromCodeCoverage]
		public bool Equals(Years other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return V == other.V;
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
			return Equals((Years)other);
		}

		/// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="Years"/>.</returns>
		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			if (Equals(null, V))
				return 0;
			return V.GetHashCode();
		}

		/// <summary>
        /// Compares this instance to a specified <see cref="Years"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="Years"/> to compare to.</param>
        /// <returns>A signed integer that indicates the relative order of this instance and <paramref name="other"/>.</returns>
		[ExcludeFromCodeCoverage]
		public int CompareTo(Years other)
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
        public static bool operator ==(Years first, Years second)
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
        public static bool operator !=(Years first, Years second)
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
        public static bool operator <(Years first, Years second)
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
        public static bool operator >(Years first, Years second)
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
        public static bool operator <=(Years first, Years second)
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
        public static bool operator >=(Years first, Years second)
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
        public static Years operator +(Years summand1, Years summand2)
        {
            return (Years) (summand1.V + summand2.V);
        }

        /// <summary>
        /// Substracts the <paramref name="subtrahend"/> from the <paramref name="minuend"/>.
        /// </summary>
        /// <param name="minuend">The left operand.</param>
        /// <param name="subtrahend">The right operand.</param>
        /// <exception cref="InvalidCastException">The validation of the difference value failed.</exception>
        /// <returns>The difference value.</returns>
        [ExcludeFromCodeCoverage]
        public static Years operator -(Years minuend, Years subtrahend)
        {
            return (Years)(minuend.V - subtrahend.V);
        }

        /// <summary>
        /// Increments the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <exception cref="InvalidCastException">The validation of the incremented value failed.</exception>
        /// <returns>The incremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static Years operator ++(Years value)
	    {
	        return (Years) (++value.V);
        }

        /// <summary>
        /// Decrements the <paramref name="value"/> by 1.
        /// </summary>
        /// <param name="value">The value to decrement.</param>
        /// <exception cref="InvalidCastException">The validation of the decremented value failed.</exception>
        /// <returns>The decremented value.</returns>
        [ExcludeFromCodeCoverage]
        public static Years operator --(Years value)
	    {
	        return (Years) (--value.V);
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
            public override void WriteJson(Newtonsoft.Json.JsonWriter writer,
                                           object value,
                                           Newtonsoft.Json.JsonSerializer serializer)
			{
				var instance = (Years)value;
				writer.WriteValue(instance.V);
			}
			
		    [ExcludeFromCodeCoverage]
            public override object ReadJson(Newtonsoft.Json.JsonReader reader,
                                            Type objectType,
                                            object existingValue,
                                            Newtonsoft.Json.JsonSerializer serializer)
            {
			    if (reader.Value == null && Nullable.GetUnderlyingType(objectType) != null)
				    return null;

                var instance = default(Years);
                instance.V = (System.Int16) Convert.ChangeType(reader.Value, TypeCode.Int16);
                return instance;
			}
			
		    [ExcludeFromCodeCoverage]
            public override bool CanConvert(Type objectType) => objectType == typeof(CustomerID);
        }
        
        public sealed class SystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<Years>
        {
		    [ExcludeFromCodeCoverage]
            public override Years Read(ref System.Text.Json.Utf8JsonReader reader,
                                       Type typeToConvert,
                                       System.Text.Json.JsonSerializerOptions options)
            {
                return (Years)reader.GetInt16();
            }

			[ExcludeFromCodeCoverage]
            public override void Write(System.Text.Json.Utf8JsonWriter writer,
                                       Years value,
                                       System.Text.Json.JsonSerializerOptions options)
            {
				writer.WriteNumberValue(value.V);
            }
        }
    }
}