using System;

using JetBrains.ReSharper.Daemon;
using JetBrains.ReSharper.Psi;

namespace MakeVirtualPlugin
{
    [DaemonStage(StagesBefore = new[]  { typeof(LanguageSpecificDaemonStage) })]
    public class MakeMethodVirtualDaemonStage: IDaemonStage
    {
        public IDaemonStageProcess CreateProcess(IDaemonProcess process, DaemonProcessKind processKind)
        {
            return new MakeMethodVirtualDaemonStageProcess(process);
        }

        public ErrorStripeRequest NeedsErrorStripe(IPsiSourceFile projectFile)
        {
            return ErrorStripeRequest.STRIPE_AND_ERRORS;
        }
    }
}