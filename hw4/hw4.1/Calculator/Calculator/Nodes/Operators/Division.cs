﻿namespace Calculator.Nodes.Operators
{
    public class Division : Operator
    {
        public Division(INode leftNode, INode rightNode) : base(leftNode, rightNode)
        { }

        protected sealed override char OperationSymbol => '/';

        public sealed override double Calculate() => LeftNode.Calculate() / RightNode.Calculate();
    }
}
