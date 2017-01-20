namespace Sitecore.DataExchange.Gutters.Commands
{
  using System;
  using Data.Items;
  using Shell.Framework.Commands;

  [Serializable]
  public class CleanPipelineBatchSummaryCommand : Command
  {
    public override void Execute(CommandContext context)
    {
      var item = context.Items[0];

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