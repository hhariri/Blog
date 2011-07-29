using System;
using System.Collections.Generic;

using JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;
using JetBrains.ReSharper.Feature.Services.Lookup;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Services;
using JetBrains.Util;

namespace CustomTemplateMacros
{
    [Macro("CustomTemplateMacros.MethodResultTypeMacro", 
        ShortDescription = "Result type of containing method",
        LongDescription = "Obtains the result type of the containing method it is used in")]
    public class MethodResultTypeMacro: IMacro
    {
        public string GetPlaceholder()
        {
            return "a";
        }

        public bool HandleExpansion(IHotspotContext context, IList<string> arguments)
        {
            return false;
        }

        public HotspotItems GetLookupItems(IHotspotContext context, IList<string> arguments)
        {
            var method = TextControlToPsi.GetContainingTypeOrTypeMember(context.SessionContext.Solution, context.SessionContext.TextControl);

            if (method is IMethod)
            {
                var lookupItems = new List<ILookupItem>();

                var item = new TextLookupItem(((IMethod)method).ReturnType.GetPresentableName(method.PresentationLanguage));
                
                lookupItems.Add(item);
                
                var hotSpotItems = new HotspotItems(lookupItems);
                
                return hotSpotItems;
            }
            return null;
        }

        public string EvaluateQuickResult(IHotspotContext context, IList<string> arguments)
        {
            return null;
        }

        public ParameterInfo[] Parameters
        {
            get { return EmptyArray<ParameterInfo>.Instance; }
        }
    }
}