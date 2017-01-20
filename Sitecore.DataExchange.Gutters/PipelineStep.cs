namespace Sitecore.DataExchange.Gutters
{
    using Data;
    using Data.Items;
    using Data.Managers;
    using Shell.Applications.ContentEditor.Gutters;
    using Sitecore.Diagnostics;

    public class PipelineStep : GutterRenderer
    {
        protected readonly ID PipelineTemplateId = new ID("{2DC9C843-B841-483C-BB9B-AE0C9386404C}");
        protected readonly ID PipelinesFolderId = new ID("{70ED1D4D-3796-400D-A64E-E538D933E12C}");

        protected override GutterIconDescriptor GetIconDescriptor(Item item)
        {
            Assert.ArgumentNotNull(item, nameof(item));
            if (item.TemplateID != this.PipelinesFolderId && item.ParentID != ID.Null && item.Parent.TemplateID == this.PipelineTemplateId)
            {
                var gutterIconDescriptor = new GutterIconDescriptor() { Icon = TemplateManager.GetTemplate(item).Icon, Tooltip = item.DisplayName };
                gutterIconDescriptor.Click = "dataExchange:pipelineStepContextMenu()";
                return gutterIconDescriptor;
            }
            return null;
        }
    }
}