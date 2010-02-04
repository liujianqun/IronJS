﻿using System;
using System.Collections.Generic;
using Antlr.Runtime.Tree;
using IronJS.Runtime2.Binders;
using IronJS.Runtime2.Js;
using IronJS.Tools;
using Microsoft.Scripting.Ast;
using Microsoft.Scripting.Utils;

namespace IronJS.Compiler.Ast
{
    using AstUtils = Microsoft.Scripting.Ast.Utils;
    using Et = Expression;
    using System.Text;

    public class NewNode : Node
    {
        public INode Target { get; protected set; }
        public List<INode> Args { get; protected set; }

        public NewNode(INode target, List<INode> args, ITree node)
            : base(NodeType.New, node)
        {
            Target = target;
            Args = args;
        }

        public NewNode(INode target, ITree node)
            : this(target, new List<INode>(), node)
        {

        }

        public override Type ExprType
        {
            get
            {
                return IjsTypes.Object;
            }
        }

        public override INode Analyze(FuncNode astopt)
        {
            IfIdentiferUsedAs(
                Target = Target.Analyze(astopt), 
                IjsTypes.Object
            );

            for (int i = 0; i < Args.Count; ++i)
                Args[i] = Args[i].Analyze(astopt);

            return this;
        }

        public override void Print(StringBuilder writer, int indent)
        {
            var indentStr = new String(' ', indent * 2);
            var indentStr2 = new String(' ', (indent + 1) * 2);

            writer.AppendLine(indentStr + "(" + NodeType);

            writer.AppendLine(indentStr2 + "(Args");
            foreach (var arg in Args)
                arg.Print(writer, indent + 2);
            writer.AppendLine(indentStr2 + ")");

            Target.Print(writer, indent + 1);

            writer.AppendLine(indentStr + ")");
        }
    }
}
