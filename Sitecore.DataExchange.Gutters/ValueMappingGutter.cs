namespace Sitecore.DataExchange.Gutters
{
    using Data;
    using Data.Items;
    using Data.Managers;
    using Shell.Applications.ContentEditor.Gutters;
    using Sitecore.Diagnostics;

    public class ValueMappingGutter : GutterRenderer
    {
        protected readonly ID ValueMappingTemplateId = new ID("{450C8F38-91C9-4896-957B-6F7DAF18CCFC}");


        protected override GutterIconDescriptor GetIconDescriptor(Item item)
        {
            Assert.ArgumentNotNull(item, nameof(item));
            if (item.TemplateID == this.ValueMappingTemplateId)
            {
                var gutterIconDescriptor = new GutterIconDescriptor() { Icon = TemplateManager.GetTemplate(item).Icon, Tooltip = item.DisplayName };
                gutterIconDescriptor.Click = "dataExchange:valueMappingContextMenu()";
                return gutterIconDescriptor;
            }
            return null;
        }
    }
}