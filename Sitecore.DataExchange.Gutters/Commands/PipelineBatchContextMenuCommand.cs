namespace Sitecore.DataExchange.Gutters.Commands
{
    using System;
    using Data;
    using Shell.Framework.Commands;
    using Sitecore.Diagnostics;
    using Web.UI.HtmlControls;
    using Web.UI.Sheer;

    [Serializable]
    public class PipelineBatchContextMenuCommand : Command
    {
        public override void Execute(CommandContext context)
        {
            Assert.ArgumentNotNull(context, nameof(context));

            Menu menu = new Menu();
            SheerResponse.DisableOutput();
            menu.Add("Run it", "Office/32x32/elements_selection.png", "dataExchange:runPipelineBatchCommand");
            menu.Add("Clean Summary", "Office/32x32/document_empty.png", "dataExchange:cleanPipelineBatchSummary");
            menu.Add("Display Pipeline Steps", "office/32x32/elements.png", "dataExchange:displayPipelineSteps");

            SheerResponse.EnableOutput();
            SheerResponse.ShowContextMenu(Sitecore.Context.ClientPage.ClientRequest.Control, "right", menu);
        }
    }
}