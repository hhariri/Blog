using System;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Daemon;

namespace MakeVirtualPlugin
{

    [DaemonStage(StagesBefore = new[]  { typeof(LanguageSpecificDaemonStage) })]
    public class MakeMethodVirtualDaemonStage: IDaemonStage
    {
        public IDaemonStageProcess CreateProcess(IDaemonProcess process, DaemonProcessKind processKind)
        {
            return new MakeMethodVirtualDaemonStageProcess(process);
        }

        public ErrorStripeRequest NeedsErrorStripe(IProjectFile projectFile)
        {
            return ErrorStripeRequest.STRIPE_AND_ERRORS;
        }
    }
}