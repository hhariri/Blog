using System;
using JetBrains.ReSharper.Daemon;
using JetBrains.ReSharper.Daemon.CSharp.Errors;
using JetBrains.ReSharper.Psi.CSharp.Tree;

namespace MakeVirtualPlugin
{
    [StaticSeverityHighlighting(Severity.SUGGESTION, "C#")]
    public class MakeMethodVirtualSuggestion : CSharpHighlightingBase, IHighlighting
    {
        public ICSharpTypeMemberDeclaration Declaration { get; private set; }

        public MakeMethodVirtualSuggestion(ICSharpTypeMemberDeclaration memberDeclaration)
        {
            Declaration = memberDeclaration;
        }

        public string ToolTip
        {
            get { return "Method could be marked as virtual"; }
        }

        public string ErrorStripeToolTip
        {
            get { return ToolTip; }

        }

        public override bool IsValid()
        {
            return Declaration.IsValid();
        }

        public int NavigationOffsetPatch
        {
            get { return 0; }
        }
    }
}