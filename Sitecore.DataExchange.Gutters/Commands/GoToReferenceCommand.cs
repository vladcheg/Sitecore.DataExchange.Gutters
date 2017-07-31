namespace Sitecore.DataExchange.Gutters.Commands
{
    using System;
    using Shell.Framework.Commands;

    [Serializable]
    public class GoToReferenceCommand : Command
    {
        public override void Execute(CommandContext context)
        {
            var item = context.Items[0];
            string id = context.Parameters["id"];

            //Sitecore.Context.ClientPage.ClientResponse.Timer(string.Format("item:load(id={0})", id), 100);
            Sitecore.Text.UrlString parameters = new Sitecore.Text.UrlString();
            parameters.Add("id", id);
            parameters.Add("fo", id);
            Sitecore.Shell.Framework.Windows.RunApplication("Content Editor", parameters.ToString());
        }
    }
}