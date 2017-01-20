namespace Sitecore.DataExchange.Gutters
{
  using Data;
  using Data.Items;
  using Data.Managers;
  using Diagnostics;
  using Shell.Applications.ContentEditor.Gutters;
  using Sitecore.Diagnostics;

    public class PipelineBatchGutter : GutterRenderer
  {
    protected readonly ID PipelineBatchTemplateId = new ID("{075C4FBD-F54E-4E6D-BD54-D49BDA0913D8}");

    protected override GutterIconDescriptor GetIconDescriptor(Item item)
    {
      Assert.ArgumentNotNull(item, nameof(item));
      if (item.TemplateID == this.PipelineBatchTemplateId)
      {
        var gutterIconDescriptor = new GutterIconDescriptor() {Icon = TemplateManager.GetTemplate(item).Icon, Tooltip = item.DisplayName};
        gutterIconDescriptor.Click = "dataExchange:pipelineBatchContextMenu()";
        return gutterIconDescriptor;
      }
      return null;
    }
  }
}