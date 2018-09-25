namespace Sitecore.Support.EmailCampaign.Cd.sitecore_modules.Web.EXM
{
    using Sitecore.Data;
    using Sitecore.Data.Items;
    using Sitecore.EmailCampaign.Cd;
    using Sitecore.Links;
    using Sitecore.EmailCampaign.Model.Messaging;
    using Sitecore.Sites;
    using Sitecore.Web;
    using Sitecore.Modules.EmailCampaign.Core;
    using Sitecore.XConnect;
    using System;

    public class UnsubscribeFromAll : Sitecore.EmailCampaign.Cd.sitecore_modules.Web.EXM.UnsubscribeFromAll
    {
        protected override string VerifyContactSubscriptions(ContactIdentifier contactIdentifier, Guid messageID)
        {
            base.VerifyContactSubscriptions(contactIdentifier, messageID);
            #region Sitecore.Support.224113
            string alreadyItemPath = ExmContext.Message.ManagerRoot.Settings.AlreadyUnsubscribedPage;
            Item alreadyItem = Database.GetDatabase("master").GetItem(alreadyItemPath);
            string itemUrl = String.Empty;
            SiteInfo site = null;
            var siteInfoList = Sitecore.Configuration.Factory.GetSiteInfoList();
            foreach (SiteInfo siteInf in siteInfoList)
            {
                if (siteInf.RootPath.Trim() != "" && siteInf.StartItem.Trim() != "" && alreadyItem.Paths.FullPath.Trim().Contains(siteInf.RootPath.Trim() + siteInf.StartItem.Trim()))
                {
                    site = siteInf;
                }
            }

            using (new SiteContextSwitcher(SiteContextFactory.GetSiteContext(site.Name)))
            {
                itemUrl = LinkManager.GetItemUrl(alreadyItem);
            }
            return itemUrl;
            #endregion
        }
    }
}