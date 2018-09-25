namespace Sitecore.Support.EmailCampaign.Cd.sitecore_modules.Web.EXM
{
    using Sitecore.EmailCampaign.Cd;
    using Sitecore.EmailCampaign.Model.Messaging;
    using Sitecore.Modules.EmailCampaign.Core;
    using Sitecore.XConnect;
    using System;

    public class Unsubscribe : Sitecore.EmailCampaign.Cd.sitecore_modules.Web.EXM.Unsubscribe
    {
        protected override string VerifyContactSubscriptions(ContactIdentifier contactIdentifier, Guid messageID)
        {
            return base.VerifyContactSubscriptions(contactIdentifier, messageID);
        }

    }
}