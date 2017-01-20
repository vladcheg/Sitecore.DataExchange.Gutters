namespace Sitecore.DataExchange.Gutters.Commands
{
  using System;
  using Data.Items;
  using Diagnostics;
  using Globalization;
  using Shell.Framework.Commands;
  using Sitecore.Diagnostics;
  using Version = Data.Version;

  [Serializable]
  public class EnableItemCommand: Command
  {
    public override void Execute(CommandContext context)
    {
      Assert.ArgumentNotNull(context, nameof(context));
      string database = context.Parameters["database"];
      string id = context.Parameters["id"];
      string language = context.Parameters["language"];
      string version = context.Parameters["version"];

      var db = Sitecore.Configuration.Factory.GetDatabase(database);
      var item = db.GetItem(id, Language.Parse(language), Version.Parse(version));

      using (new EditContext(item))
      {
        item["Enabled"] = "1";
      }
    }
  }
}