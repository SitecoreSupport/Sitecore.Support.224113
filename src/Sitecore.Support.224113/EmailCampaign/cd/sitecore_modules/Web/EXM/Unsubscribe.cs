namespace Sitecore.Support.EmailCampaign.cd.sitecore_modules.Web.EXM
{
    using Sitecore.EmailCampaign.Model.Messaging;
    using Sitecore.Modules.EmailCampaign.Core;
    using Sitecore.XConnect;
    using System;

    public class Unsubscribe
    {
        public class Unsubscribe : UnsubscribeMessageEventPage
        {
            protected override string UnsubscribeContact(ContactIdentifier contactIdentifier, Guid messageID)
            {
                this.ClientApiService.Unsubscribe(new UnsubscribeMessage
                {
                    AddToGlobalOptOutList = false,
                    ContactIdentifier = contactIdentifier,
                    MessageId = messageID
                });
                return ExmContext.Message.ManagerRoot.GetConfirmativePageUrl() ?? "/";
            }
        }
    }
}