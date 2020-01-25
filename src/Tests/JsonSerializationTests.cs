using NUnit.Framework;

namespace Tests
{
    using System;
    using FluentAssertions;
    using Helper;
    using Herdo.StrongTypes.DotNetStandard.StrongTypes;

    public class JsonSerializationTests
    {
        [Test]
        public void NewtonsoftJson_SerializedAndDeserializedCorrectly()
        {
            // Arrange
            var initialInstance = new SerializationClass
            {
                BooleanStrongTypeNotNull = (BooleanStrongType)true,
                ByteStrongTypeNotNull = (ByteStrongType)215,
                DecimalStrongTypeNotNull = (DecimalStrongType)15.55m,
                DoubleStrongTypeNotNull = (DoubleStrongType)276.1231,
                GuidStrongTypeNotNull = (GuidStrongType)Guid.NewGuid(),
                Int16StrongTypeNotNull = (Int16StrongType)(-13264),
                Int32StrongTypeNotNull = (Int32StrongType)(-13645841),
                Int64StrongTypeNotNull = (Int64StrongType)12354878548,
                SByteStrongTypeNotNull = (SByteStrongType)(-100),
                SingleStrongTypeNotNull = (SingleStrongType)14234.1230,
                StringStrongTypeNotNull = (StringStrongType)"foo bar",
                UInt16StrongTypeNotNull = (UInt16StrongType)50146,
                UInt32StrongTypeNotNull = (UInt32StrongType)3156469123,
                UInt64StrongTypeNotNull = (UInt64StrongType)17464894014012346145
            };

            // Act
            var serialized = Newtonsoft.Json.JsonConvert.SerializeObject(initialInstance);
            var deserialized = Newtonsoft.Json.JsonConvert.DeserializeObject<SerializationClass>(serialized);

            // Assert
            initialInstance.Should().BeEquivalentTo(deserialized);
        }

        [Test]
        public void SystemTextJson_SerializedAndDeserializedCorrectly()
        {
            // Arrange
            var initialInstance = new SerializationClass
            {
                BooleanStrongTypeNotNull = (BooleanStrongType)true,
                ByteStrongTypeNotNull = (ByteStrongType)215,
                DecimalStrongTypeNotNull = (DecimalStrongType)15.55m,
                DoubleStrongTypeNotNull = (DoubleStrongType)276.1231,
                GuidStrongTypeNotNull = (GuidStrongType)Guid.NewGuid(),
                Int16StrongTypeNotNull = (Int16StrongType)(-13264),
                Int32StrongTypeNotNull = (Int32StrongType)(-13645841),
                Int64StrongTypeNotNull = (Int64StrongType)12354878548,
                SByteStrongTypeNotNull = (SByteStrongType)(-100),
                SingleStrongTypeNotNull = (SingleStrongType)14234.1230,
                StringStrongTypeNotNull = (StringStrongType)"foo bar",
                UInt16StrongTypeNotNull = (UInt16StrongType)50146,
                UInt32StrongTypeNotNull = (UInt32StrongType)3156469123,
                UInt64StrongTypeNotNull = (UInt64StrongType)17464894014012346145
            };

            // Act
            var serialized = System.Text.Json.JsonSerializer.Serialize(initialInstance);
            var deserialized = System.Text.Json.JsonSerializer.Deserialize<SerializationClass>(serialized);

            // Assert
            initialInstance.Should().BeEquivalentTo(deserialized);
        }

        [Test]
        public void NewtonsoftJsonToSystemTextJson_SerializedAndDeserializedCorrectly()
        {
            // Arrange
            var initialInstance = new SerializationClass
            {
                BooleanStrongTypeNotNull = (BooleanStrongType)true,
                ByteStrongTypeNotNull = (ByteStrongType)215,
                DecimalStrongTypeNotNull = (DecimalStrongType)15.55m,
                DoubleStrongTypeNotNull = (DoubleStrongType)276.1231,
                GuidStrongTypeNotNull = (GuidStrongType)Guid.NewGuid(),
                Int16StrongTypeNotNull = (Int16StrongType)(-13264),
                Int32StrongTypeNotNull = (Int32StrongType)(-13645841),
                Int64StrongTypeNotNull = (Int64StrongType)12354878548,
                SByteStrongTypeNotNull = (SByteStrongType)(-100),
                SingleStrongTypeNotNull = (SingleStrongType)14234.1230,
                StringStrongTypeNotNull = (StringStrongType)"foo bar",
                UInt16StrongTypeNotNull = (UInt16StrongType)50146,
                UInt32StrongTypeNotNull = (UInt32StrongType)3156469123,
                UInt64StrongTypeNotNull = (UInt64StrongType)17464894014012346145
            };

            // Act
            var serialized = Newtonsoft.Json.JsonConvert.SerializeObject(initialInstance);
            var deserialized = System.Text.Json.JsonSerializer.Deserialize<SerializationClass>(serialized);

            // Assert
            initialInstance.Should().BeEquivalentTo(deserialized);
        }

        [Test]
        public void SystemTextJsonToNewtonsoftJson_SerializedAndDeserializedCorrectly()
        {
            // Arrange
            var initialInstance = new SerializationClass
            {
                BooleanStrongTypeNotNull = (BooleanStrongType)true,
                ByteStrongTypeNotNull = (ByteStrongType)215,
                DecimalStrongTypeNotNull = (DecimalStrongType)15.55m,
                DoubleStrongTypeNotNull = (DoubleStrongType)276.1231,
                GuidStrongTypeNotNull = (GuidStrongType)Guid.NewGuid(),
                Int16StrongTypeNotNull = (Int16StrongType)(-13264),
                Int32StrongTypeNotNull = (Int32StrongType)(-13645841),
                Int64StrongTypeNotNull = (Int64StrongType)12354878548,
                SByteStrongTypeNotNull = (SByteStrongType)(-100),
                SingleStrongTypeNotNull = (SingleStrongType)14234.1230,
                StringStrongTypeNotNull = (StringStrongType)"foo bar",
                UInt16StrongTypeNotNull = (UInt16StrongType)50146,
                UInt32StrongTypeNotNull = (UInt32StrongType)3156469123,
                UInt64StrongTypeNotNull = (UInt64StrongType)17464894014012346145
            };

            // Act
            var serialized = System.Text.Json.JsonSerializer.Serialize(initialInstance);
            var deserialized = Newtonsoft.Json.JsonConvert.DeserializeObject<SerializationClass>(serialized);

            // Assert
            initialInstance.Should().BeEquivalentTo(deserialized);
        }
    }
}