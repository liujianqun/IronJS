// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.BooleanObjects
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PropertiesOfTheBooleanPrototypeObjectTests : SputnikTestFixture
    {
        public PropertiesOfTheBooleanPrototypeObjectTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.6_Boolean_Objects\15.6.4_Properties_of_the_Boolean_Prototype_Object")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.6.4.1")]
        [TestCase("S15.6.4.1_A1.js", Description = "The initial value of Boolean.prototype.constructor is the built-in Boolean constructor")]
        public void TheInitialValueOfBooleanPrototypeConstructorIsTheBuiltInBooleanConstructor(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.6.4.2")]
        [TestCase("S15.6.4.2_A1_T1.js", Description = "toString: If this boolean value is true, then the string \"true\" is returned, otherwise, this boolean value must be false, and the string \"false\" is returned")]
        [TestCase("S15.6.4.2_A1_T2.js", Description = "toString: If this boolean value is true, then the string \"true\" is returned, otherwise, this boolean value must be false, and the string \"false\" is returned")]
        public void ToStringIfThisBooleanValueIsTrueThenTheStringTrueIsReturnedOtherwiseThisBooleanValueMustBeFalseAndTheStringFalseIsReturned(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.6.4.2")]
        [TestCase("S15.6.4.2_A2_T1.js", Description = "The toString function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        [TestCase("S15.6.4.2_A2_T2.js", Description = "The toString function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        [TestCase("S15.6.4.2_A2_T3.js", Description = "The toString function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        [TestCase("S15.6.4.2_A2_T4.js", Description = "The toString function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        [TestCase("S15.6.4.2_A2_T5.js", Description = "The toString function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        public void TheToStringFunctionIsNotGenericItCannotBeTransferredToOtherKindsOfObjectsForUseAsAMethodAndThereIsShouldBeATypeErrorExceptionIfItsThisValueIsNotABooleanObject(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.6.4.3")]
        [TestCase("S15.6.4.3_A1_T1.js", Description = "Boolean.prototype.valueOf() returns this boolean value")]
        [TestCase("S15.6.4.3_A1_T2.js", Description = "Boolean.prototype.valueOf() returns this boolean value")]
        public void BooleanPrototypeValueOfReturnsThisBooleanValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.6.4.3")]
        [TestCase("S15.6.4.3_A2_T1.js", Description = "The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        [TestCase("S15.6.4.3_A2_T2.js", Description = "The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        [TestCase("S15.6.4.3_A2_T3.js", Description = "The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        [TestCase("S15.6.4.3_A2_T4.js", Description = "The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        [TestCase("S15.6.4.3_A2_T5.js", Description = "The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        public void TheValueOfFunctionIsNotGenericItCannotBeTransferredToOtherKindsOfObjectsForUseAsAMethodAndThereIsShouldBeATypeErrorExceptionIfItsThisValueIsNotABooleanObject(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.6.4")]
        [TestCase("S15.6.4_A1.js", Description = "The Boolean prototype object is itself a Boolean object (its [[Class]] is \"Boolean\") whose value is false")]
        public void TheBooleanPrototypeObjectIsItselfABooleanObjectItsClassIsBooleanWhoseValueIsFalse(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.6.4")]
        [TestCase("S15.6.4_A2.js", Description = "The value of the internal [[Prototype]] property of the Boolean prototype object is the Object prototype object")]
        public void TheValueOfTheInternalPrototypePropertyOfTheBooleanPrototypeObjectIsTheObjectPrototypeObject(string file)
        {
            RunFile(file);
        }
    }
}