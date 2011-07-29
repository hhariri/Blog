using System;
using JetBrains.Application.Progress;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.Bulbs;
using JetBrains.ReSharper.Feature.Services.CSharp.Bulbs;
using JetBrains.ReSharper.Intentions;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp.Tree;
using JetBrains.TextControl;
using JetBrains.Util;

namespace MakeVirtualPlugin
{
    [ContextAction(Group="C#", Name = "MakeMethodVirtual", Description = "Adds context action to make methods virtual")]
    public class MakeMethodVirtualContextAction : BulbItemImpl, IContextAction
    {
        readonly ICSharpContextActionDataProvider _provider;


        public MakeMethodVirtualContextAction(ICSharpContextActionDataProvider provider)
        {
            _provider = provider;
        }

        public bool IsAvailable(IUserDataHolder cache)
        {
            var item = _provider.GetSelectedElement<IMethodDeclaration>(false, true);

            if (item != null)
            {
                var accessRights = item.GetAccessRights();

                if (accessRights == AccessRights.PUBLIC && !item.IsStatic && !item.IsVirtual && !item.IsOverride)
                {
                    return true;
                }
            }
            return false;
        }

        protected override Action<ITextControl> ExecutePsiTransaction(ISolution solution, IProgressIndicator progress)
        {
            var method = _provider.GetSelectedElement<IMethodDeclaration>(false, true);

            if (method != null)
            {
                method.SetVirtual(true);
            }

            return null;
        }


        public override string Text
        {
            get { return "Make Method Virtual"; }
        }
    }


}


