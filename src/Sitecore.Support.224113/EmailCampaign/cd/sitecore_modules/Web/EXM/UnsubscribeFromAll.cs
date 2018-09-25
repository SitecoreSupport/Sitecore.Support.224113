namespace Sitecore.Support.EmailCampaign.cd.sitecore_modules.Web.EXM
{
    using Sitecore.EmailCampaign.Model.Messaging;
    using Sitecore.Modules.EmailCampaign.Core;
    using Sitecore.XConnect;
    using System;

    public class UnsubscribeFromAll : UnsubscribeMessageEventPage
    {
        protected internal override string NoMessageIdLogMesssage
        {
            get
            {
                return "Cannot handle global unsubscription event. No message id was provided in the request.";
            }
        }

        protected internal override string NoContactIdLogMessage
        {
            get
            {
                return "Cannot handle global unsubscription event. No contact id was provided in the request and no default subscription page is configured.";
            }
        }

        protected override string UnsubscribeContact(ContactIdentifier contactIdentifier, Guid messageID)
        {
            this.ClientApiService.Unsubscribe(new UnsubscribeMessage
            {
                AddToGlobalOptOutList = true,
                ContactIdentifier = contactIdentifier,
                MessageId = messageID
            });
            return ExmContext.Message.ManagerRoot.GetConfirmativePageUrl() ?? "/";
        }
    }
}