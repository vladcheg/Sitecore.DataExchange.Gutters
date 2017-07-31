namespace Sitecore.DataExchange.Gutters.Commands
{
    using System;
    using Shell.Framework.Commands;
    using Web.UI.HtmlControls;
    using Web.UI.Sheer;

    [Serializable]
    public class ReferenceMenuCommand : Command
    {
        public override void Execute(CommandContext context)
        {
            var item = context.Items[0];
            string fieldName = context.Parameters["fieldName"];

            Sitecore.Data.Fields.MultilistField multilistField =
                (Sitecore.Data.Fields.MultilistField) item.Fields[fieldName];

            var targetIDs = multilistField.TargetIDs;
            
            Menu menu = new Menu();
            SheerResponse.DisableOutput();

            foreach (var targetID in targetIDs)
            {
                var item1 = item.Database.GetItem(targetID);

                menu.Add(item1.DisplayName, "Office/32x32/radio_button_selected.png",
                    string.Concat(new object[] { "dataExchange:goToReference(id=", targetID, ")" })); 
            }
            SheerResponse.EnableOutput();
            SheerResponse.ShowContextMenu(Sitecore.Context.ClientPage.ClientRequest.Control, "right", menu);
        }
    }
}