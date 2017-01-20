namespace Sitecore.DataExchange.Gutters.Commands
{
  using System.Collections.Generic;
  using System.Linq;
  using Common;
  using Data;
  using Data.Items;
  using localhost;
  using Pipelines.GetLookupSourceItems;
  using Shell.Framework.Commands;
  public class DisplayPipelineStepsCommand : Command
  {
    public override void Execute(CommandContext context)
    {
      var item = context.Items[0];
      var db = item.Database;

      var pipelines = this.GetPipelines(item);

      var enumerable = pipelines as ID[] ?? pipelines.ToArray();
      if (!enumerable.Any())
      {
        Sitecore.Context.ClientPage.ClientResponse.Alert("Pipelines are not set.");
        return;
      }

      var list = new List<ID>();

      foreach (var pipeline in enumerable)
      {
        list.AddRange(this.GetSteps(pipeline, db));
      }

      string str = string.Empty;

      int k = 0;
      foreach (var id in list)
      {
        ++k;
        str = str + k + ". " + db.GetItem(id).DisplayName + "\n";
      }

      Sitecore.Context.ClientPage.ClientResponse.Alert(str);

    }

    protected virtual IEnumerable<ID> GetPipelines(Item item)
    {
      var multilistField = (Sitecore.Data.Fields.MultilistField)item.Fields["Pipelines"];

      return multilistField == null ? Enumerable.Empty<ID>() : multilistField.TargetIDs;
    }

    protected virtual List<ID> GetSteps(ID pipelineId, Database database)
    {
      var list = new List<ID>();
      var items = database.GetItem(pipelineId).Children.Where(i => !string.IsNullOrEmpty(i["Enabled"]) && i["Enabled"] != "0");
      foreach (var item in items)
      {
        list.Add(item.ID);
        if (!string.IsNullOrEmpty(item["Pipelines"]))
        {
          var pipelines = this.GetPipelines(item);
          foreach (var pipeline in pipelines)
          {
            list.AddRange(this.GetSteps(pipeline, database));
          }
        }
      }

      return list;
    }
  }
}