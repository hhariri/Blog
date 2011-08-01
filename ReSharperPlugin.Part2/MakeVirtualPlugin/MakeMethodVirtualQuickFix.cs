using System;
using JetBrains.Application.Progress;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.Bulbs;
using JetBrains.ReSharper.Intentions;
using JetBrains.TextControl;
using JetBrains.Util;

namespace MakeVirtualPlugin
{
    [QuickFix]
    public class MakeMethodVirtualQuickFix : BulbItemImpl, IQuickFix
    {
        readonly MakeMethodVirtualSuggestion _highlighter;

        // Takes as parameter the Highlighter the quickfix refers to
        public MakeMethodVirtualQuickFix(MakeMethodVirtualSuggestion highlighter)
        {
            _highlighter = highlighter;
        }

        // In the transaction we make the necessary changes to the code
        protected override Action<ITextControl> ExecutePsiTransaction(ISolution solution, IProgressIndicator progress)
        {
            _highlighter.Declaration.SetVirtual(true);

            return null;
        }

        // Text that appears in the context menu
        public override string Text
        {
            get { return "Make Method Virtual"; }
        }

        // Indicates when the option is available 
        public bool IsAvailable(IUserDataHolder cache)
        {
            return _highlighter.IsValid();
        }
    }
}