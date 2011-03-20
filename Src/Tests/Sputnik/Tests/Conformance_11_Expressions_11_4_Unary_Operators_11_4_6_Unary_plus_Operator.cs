using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests.Sputnik {
  [TestClass]
  public class Conformance_11_Expressions_11_4_Unary_Operators_11_4_6_Unary_plus_Operator : BaseTest {
    [TestInitialize]
    public void Init() { SetSputnikDir(@"Conformance\11_Expressions\11.4_Unary_Operators\11.4.6_Unary_plus_Operator"); }
    [TestMethod] public void S11_4_6_A1_js() { RunFile(@"S11.4.6_A1.js"); }
    [TestMethod] public void S11_4_6_A2_1_T1_js() { RunFile(@"S11.4.6_A2.1_T1.js"); }
    [TestMethod] public void S11_4_6_A2_1_T2_js() { RunFile(@"S11.4.6_A2.1_T2.js"); }
    [TestMethod] public void S11_4_6_A2_2_T1_js() { RunFile(@"S11.4.6_A2.2_T1.js"); }
    [TestMethod] public void S11_4_6_A3_T1_js() { RunFile(@"S11.4.6_A3_T1.js"); }
    [TestMethod] public void S11_4_6_A3_T2_js() { RunFile(@"S11.4.6_A3_T2.js"); }
    [TestMethod] public void S11_4_6_A3_T3_js() { RunFile(@"S11.4.6_A3_T3.js"); }
    [TestMethod] public void S11_4_6_A3_T4_js() { RunFile(@"S11.4.6_A3_T4.js"); }
    [TestMethod] public void S11_4_6_A3_T5_js() { RunFile(@"S11.4.6_A3_T5.js"); }
  }
}