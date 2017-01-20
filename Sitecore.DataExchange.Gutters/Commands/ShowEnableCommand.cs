namespace Sitecore.DataExchange.Gutters.Commands
{
  using System;
  using Diagnostics;
  using Shell.Framework.Commands;
  using Sitecore.Diagnostics;
  using Web.UI.HtmlControls;
  using Web.UI.Sheer;

  [Serializable]
  public class ShowEnableCommand : Command
  {
    public override void Execute(CommandContext context)
    {
      Assert.ArgumentNotNull(context, nameof(context));
      string database = context.Parameters["database"];
      string id = context.Parameters["id"];
      string language = context.Parameters["language"];
      string version = context.Parameters["version"];

      Menu menu = new Menu();
      SheerResponse.DisableOutput();
      menu.Add("Enable", "Office/32x32/selection.png", string.Concat(new object[] { "dataExchange:enableItem(id=", id, ",language=",language, ",version=", version, ",database=", database, ")" }));

      SheerResponse.EnableOutput();
      SheerResponse.ShowContextMenu(Sitecore.Context.ClientPage.ClientRequest.Control, "right", menu);
    }
  }
}