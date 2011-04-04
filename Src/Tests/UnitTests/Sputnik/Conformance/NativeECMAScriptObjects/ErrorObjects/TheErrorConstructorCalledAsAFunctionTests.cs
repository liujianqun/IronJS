// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ErrorObjects
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheErrorConstructorCalledAsAFunctionTests : SputnikTestFixture
    {
        public TheErrorConstructorCalledAsAFunctionTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.11_Error_Objects\15.11.1_The_Error_Constructor_Called_as_a_Function")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.11.1.1")]
        [Category("ECMA 16")]
        [TestCase("S15.11.1.1_A1_T1.js", Description = "If the argument \"message\" is not undefined, the message property of the newly constructed object is set to ToString(message)")]
        public void IfTheArgumentMessageIsNotUndefinedTheMessagePropertyOfTheNewlyConstructedObjectIsSetToToStringMessage(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.11.1.1")]
        [Category("ECMA 16")]
        [TestCase("S15.11.1.1_A2_T1.js", Description = "The [[Prototype]] property of the newly constructed object is set to the original Error prototype object, the one that is the initial value of Error.prototype (15.11.3.1)")]
        public void ThePrototypePropertyOfTheNewlyConstructedObjectIsSetToTheOriginalErrorPrototypeObjectTheOneThatIsTheInitialValueOfErrorPrototype151131(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.11.1.1")]
        [Category("ECMA 16")]
        [TestCase("S15.11.1.1_A3_T1.js", Description = "The [[Class]] property of the newly constructed object is set to \"Error\"")]
        public void TheClassPropertyOfTheNewlyConstructedObjectIsSetToError(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.11.1")]
        [Category("ECMA 16")]
        [TestCase("S15.11.1_A1_T1.js", Description = "The function call Error(...) is equivalent to the object creation expression new Error(...) with the same arguments")]
        public void TheFunctionCallErrorIsEquivalentToTheObjectCreationExpressionNewErrorWithTheSameArguments(string file)
        {
            RunFile(file);
        }
    }
}