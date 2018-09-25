namespace Sitecore.Support.EmailCampaign.Cd.sitecore_modules.Web.EXM
{
    using Sitecore.EmailCampaign.Cd;
    using Sitecore.EmailCampaign.Model.Messaging;
    using Sitecore.Modules.EmailCampaign.Core;
    using Sitecore.XConnect;
    using System;

    public class UnsubscribeFromAll : Sitecore.EmailCampaign.Cd.sitecore_modules.Web.EXM.UnsubscribeFromAll
    {
        protected override string VerifyContactSubscriptions(ContactIdentifier contactIdentifier, Guid messageID)
        {
            return base.VerifyContactSubscriptions(contactIdentifier, messageID);
        }
    }
}