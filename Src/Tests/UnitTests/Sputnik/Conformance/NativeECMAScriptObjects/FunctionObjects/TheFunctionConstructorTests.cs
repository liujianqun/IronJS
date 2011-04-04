// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.FunctionObjects
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheFunctionConstructorTests : SputnikTestFixture
    {
        public TheFunctionConstructorTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.3_Function_Objects\15.3.2_The_Function_Constructor")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [Category("ECMA 15.3.2.1")]
        [TestCase("S15.3.2.1_A1_T1.js", Description = "When the Function constructor is called with one argument then body be that argument and the following steps are taken: i) Call ToString(body) ii) If P is not parsable as a FormalParameterListopt then throw a SyntaxError exception iii) If body is not parsable as FunctionBody then throw a SyntaxError exception iv) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody. Pass in a scope chain consisting of the global object as the Scope parameter v) Return Result(iv)")]
        [TestCase("S15.3.2.1_A1_T10.js", Description = "When the Function constructor is called with one argument then body be that argument and the following steps are taken: i) Call ToString(body) ii) If P is not parsable as a FormalParameterListopt then throw a SyntaxError exception iii) If body is not parsable as FunctionBody then throw a SyntaxError exception iv) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody. Pass in a scope chain consisting of the global object as the Scope parameter v) Return Result(iv)")]
        [TestCase("S15.3.2.1_A1_T11.js", Description = "When the Function constructor is called with one argument then body be that argument and the following steps are taken: i) Call ToString(body) ii) If P is not parsable as a FormalParameterListopt then throw a SyntaxError exception iii) If body is not parsable as FunctionBody then throw a SyntaxError exception iv) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody. Pass in a scope chain consisting of the global object as the Scope parameter v) Return Result(iv)")]
        [TestCase("S15.3.2.1_A1_T12.js", Description = "When the Function constructor is called with one argument then body be that argument and the following steps are taken: i) Call ToString(body) ii) If P is not parsable as a FormalParameterListopt then throw a SyntaxError exception iii) If body is not parsable as FunctionBody then throw a SyntaxError exception iv) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody. Pass in a scope chain consisting of the global object as the Scope parameter v) Return Result(iv)")]
        [TestCase("S15.3.2.1_A1_T13.js", Description = "When the Function constructor is called with one argument then body be that argument and the following steps are taken: i) Call ToString(body) ii) If P is not parsable as a FormalParameterListopt then throw a SyntaxError exception iii) If body is not parsable as FunctionBody then throw a SyntaxError exception iv) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody. Pass in a scope chain consisting of the global object as the Scope parameter v) Return Result(iv)")]
        [TestCase("S15.3.2.1_A1_T2.js", Description = "When the Function constructor is called with one argument then body be that argument and the following steps are taken: i) Call ToString(body) ii) If P is not parsable as a FormalParameterListopt then throw a SyntaxError exception iii) If body is not parsable as FunctionBody then throw a SyntaxError exception iv) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody. Pass in a scope chain consisting of the global object as the Scope parameter v) Return Result(iv)")]
        [TestCase("S15.3.2.1_A1_T3.js", Description = "When the Function constructor is called with one argument then body be that argument and the following steps are taken: i) Call ToString(body) ii) If P is not parsable as a FormalParameterListopt then throw a SyntaxError exception iii) If body is not parsable as FunctionBody then throw a SyntaxError exception iv) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody. Pass in a scope chain consisting of the global object as the Scope parameter v) Return Result(iv)")]
        [TestCase("S15.3.2.1_A1_T4.js", Description = "When the Function constructor is called with one argument then body be that argument and the following steps are taken: i) Call ToString(body) ii) If P is not parsable as a FormalParameterListopt then throw a SyntaxError exception iii) If body is not parsable as FunctionBody then throw a SyntaxError exception iv) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody. Pass in a scope chain consisting of the global object as the Scope parameter v) Return Result(iv)")]
        [TestCase("S15.3.2.1_A1_T5.js", Description = "When the Function constructor is called with one argument then body be that argument and the following steps are taken: i) Call ToString(body) ii) If P is not parsable as a FormalParameterListopt then throw a SyntaxError exception iii) If body is not parsable as FunctionBody then throw a SyntaxError exception iv) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody. Pass in a scope chain consisting of the global object as the Scope parameter v) Return Result(iv)")]
        [TestCase("S15.3.2.1_A1_T6.js", Description = "When the Function constructor is called with one argument then body be that argument and the following steps are taken: i) Call ToString(body) ii) If P is not parsable as a FormalParameterListopt then throw a SyntaxError exception iii) If body is not parsable as FunctionBody then throw a SyntaxError exception iv) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody. Pass in a scope chain consisting of the global object as the Scope parameter v) Return Result(iv)")]
        [TestCase("S15.3.2.1_A1_T7.js", Description = "When the Function constructor is called with one argument then body be that argument and the following steps are taken: i) Call ToString(body) ii) If P is not parsable as a FormalParameterListopt then throw a SyntaxError exception iii) If body is not parsable as FunctionBody then throw a SyntaxError exception iv) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody. Pass in a scope chain consisting of the global object as the Scope parameter v) Return Result(iv)")]
        [TestCase("S15.3.2.1_A1_T8.js", Description = "When the Function constructor is called with one argument then body be that argument and the following steps are taken: i) Call ToString(body) ii) If P is not parsable as a FormalParameterListopt then throw a SyntaxError exception iii) If body is not parsable as FunctionBody then throw a SyntaxError exception iv) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody. Pass in a scope chain consisting of the global object as the Scope parameter v) Return Result(iv)")]
        [TestCase("S15.3.2.1_A1_T9.js", Description = "When the Function constructor is called with one argument then body be that argument and the following steps are taken: i) Call ToString(body) ii) If P is not parsable as a FormalParameterListopt then throw a SyntaxError exception iii) If body is not parsable as FunctionBody then throw a SyntaxError exception iv) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody. Pass in a scope chain consisting of the global object as the Scope parameter v) Return Result(iv)")]
        public void WhenTheFunctionConstructorIsCalledWithOneArgumentThenCertainStepsAreTaken(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.3.2.1")]
        [TestCase("S15.3.2.1_A2_T1.js", Description = "It is permissible but not necessary to have one argument for each formal parameter to be specified")]
        [TestCase("S15.3.2.1_A2_T2.js", Description = "It is permissible but not necessary to have one argument for each formal parameter to be specified")]
        [TestCase("S15.3.2.1_A2_T3.js", Description = "It is permissible but not necessary to have one argument for each formal parameter to be specified")]
        [TestCase("S15.3.2.1_A2_T4.js", Description = "It is permissible but not necessary to have one argument for each formal parameter to be specified")]
        [TestCase("S15.3.2.1_A2_T5.js", Description = "It is permissible but not necessary to have one argument for each formal parameter to be specified")]
        [TestCase("S15.3.2.1_A2_T6.js", Description = "It is permissible but not necessary to have one argument for each formal parameter to be specified")]
        public void ItIsPermissibleButNotNecessaryToHaveOneArgumentForEachFormalParameterToBeSpecified(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [Category("ECMA 15.3.2.1")]
        [TestCase("S15.3.2.1_A3_T1.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        [TestCase("S15.3.2.1_A3_T10.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        [TestCase("S15.3.2.1_A3_T11.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        [TestCase("S15.3.2.1_A3_T12.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        [TestCase("S15.3.2.1_A3_T13.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        [TestCase("S15.3.2.1_A3_T14.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        [TestCase("S15.3.2.1_A3_T15.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        [TestCase("S15.3.2.1_A3_T2.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        [TestCase("S15.3.2.1_A3_T3.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        [TestCase("S15.3.2.1_A3_T4.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        [TestCase("S15.3.2.1_A3_T5.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        [TestCase("S15.3.2.1_A3_T6.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        [TestCase("S15.3.2.1_A3_T7.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        [TestCase("S15.3.2.1_A3_T8.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        [TestCase("S15.3.2.1_A3_T9.js", Description = "When the Function constructor is called with arguments p, body the following steps are taken: i) Let Result(i) be the first argument ii) Let P be ToString(Result(i)) iii) Call ToString(body) iv) If P is not parsable as a FormalParameterList_opt then throw a SyntaxError exception v) If body is not parsable as FunctionBody then throw a SyntaxError exception vi) Create a new Function object as specified in 13.2 with parameters specified by parsing P as a FormalParameterListopt and body specified by parsing body as a FunctionBody Pass in a scope chain consisting of the global object as the Scope parameter vii) Return Result(vi)")]
        public void WhenTheFunctionConstructorIsCalledWithArgumentsPBodyCertainStepsAreTaken(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.3.2")]
        [TestCase("S15.3.2_A1.js", Description = "When Function is called as part of a new expression, it is a constructor: it initialises the newly created object")]
        public void WhenFunctionIsCalledAsPartOfANewExpressionItIsAConstructorItInitialisesTheNewlyCreatedObject(string file)
        {
            RunFile(file);
        }
    }
}