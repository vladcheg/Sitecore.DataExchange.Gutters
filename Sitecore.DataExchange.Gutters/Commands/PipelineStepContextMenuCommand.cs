﻿namespace Sitecore.DataExchange.Gutters.Commands
{
    using System;
    using Data;
    using Shell.Framework.Commands;
    using Sitecore.Diagnostics;
    using Web.UI.HtmlControls;
    using Web.UI.Sheer;

    [Serializable]
    public class PipelineStepContextMenuCommand : Command
    {
        public override void Execute(CommandContext context)
        {
            Assert.ArgumentNotNull(context, nameof(context));

            Menu menu = new Menu();
            SheerResponse.DisableOutput();
            menu.Add("Display Required", "Applications/32x32/warning.png", "dataExchange:displayRequired");

            SheerResponse.EnableOutput();
            SheerResponse.ShowContextMenu(Sitecore.Context.ClientPage.ClientRequest.Control, "right", menu);
        }
    }
}