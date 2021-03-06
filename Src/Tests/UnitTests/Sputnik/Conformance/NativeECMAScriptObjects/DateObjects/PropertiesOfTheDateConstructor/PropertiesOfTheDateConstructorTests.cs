// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.DateObjects.PropertiesOfTheDateConstructor
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PropertiesOfTheDateConstructorTests : SputnikTestFixture
    {
        public PropertiesOfTheDateConstructorTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.9_Date_Objects\15.9.4_Properties_of_the_Date_Constructor")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.4")]
        [TestCase("S15.9.4_A1.js", Description = "The Date constructor has the property \"prototype\"")]
        public void TheDateConstructorHasThePropertyPrototype(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.4")]
        [TestCase("S15.9.4_A2.js", Description = "The Date constructor has the property \"parse\"")]
        public void TheDateConstructorHasThePropertyParse(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.4")]
        [TestCase("S15.9.4_A3.js", Description = "The Date constructor has the property \"UTC\"")]
        public void TheDateConstructorHasThePropertyUTC(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.4")]
        [TestCase("S15.9.4_A4.js", Description = "The value of the internal [[Prototype]] property of the Date constructor is the Function prototype object")]
        public void TheValueOfTheInternalPrototypePropertyOfTheDateConstructorIsTheFunctionPrototypeObject(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.4")]
        [TestCase("S15.9.4_A5.js", Description = "Date constructor has length property whose value is 7")]
        public void DateConstructorHasLengthPropertyWhoseValueIs7(string file)
        {
            RunFile(file);
        }
    }
}