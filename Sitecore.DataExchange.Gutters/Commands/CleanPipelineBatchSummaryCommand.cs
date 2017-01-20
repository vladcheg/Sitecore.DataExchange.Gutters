namespace Sitecore.DataExchange.Gutters.Commands
{
    using System;
    using Data;
    using Data.Items;
    using Shell.Framework.Commands;
    using Sitecore.Diagnostics;
    using Web.UI.Sheer;

    [Serializable]
    public class CleanPipelineBatchSummaryCommand : Command
    {
        protected readonly ID PipelineBatchTemplateId = new ID("{075C4FBD-F54E-4E6D-BD54-D49BDA0913D8}");

        public override void Execute(CommandContext context)
        {
            Assert.ArgumentNotNull(context, nameof(context));
            var item = context.Items[0];
            if (item.TemplateID != this.PipelineBatchTemplateId)
            {
                SheerResponse.Alert("The context item is not Pipeline Batch.");
                return;
            }

            using (new EditContext(item))
            {
                item["{985BA535-0F3E-4DA8-A768-A469026DE9DB}"] = string.Empty;
                item["{6A2B2CBB-4338-4814-A8A9-9FECBB90456A}"] = string.Empty;
                item["{47F8050D-6EEE-423F-A9F0-3DC34948C365}"] = string.Empty;
                item["{83E6292F-A00E-463D-A1C6-0FC25BC0FBAD}"] = string.Empty;
            }
        }
    }
}