using System;
using System.Xml.Serialization;
using SAML2.Schema.Core;

namespace SAML2.Schema.Protocol
{
    /// <summary>
    /// To request an alternate name identifier for a principal from an identity provider, a requester sends an
    /// &lt;NameIDMappingRequest&gt; message
    /// </summary>
    [Serializable]
    [XmlType(Namespace=Saml20Constants.Protocol)]
    [XmlRoot(ElementName, Namespace=Saml20Constants.Protocol, IsNullable=false)]
    public class NameIDMappingRequest : RequestAbstract
    {
        /// <summary>
        /// The XML Element name of this class
        /// </summary>
        public const string ElementName = "NameIDMappingRequest";

        #region Elements

        /// <summary>
        /// Gets or sets the item.
        /// The identifier and associated descriptive data that specify the principal as currently recognized by the
        /// requester and the responder.
        /// </summary>
        /// <value>The item.</value>
        [XmlElement("BaseID", typeof (BaseIDAbstract), Namespace = Saml20Constants.Assertion)]
        [XmlElement("EncryptedID", typeof (EncryptedElement), Namespace = Saml20Constants.Assertion)]
        [XmlElement("NameID", typeof (NameID), Namespace = Saml20Constants.Assertion)]
        public object Item { get; set; }
        
        /// <summary>
        /// Gets or sets the name ID policy.
        /// The requirements regarding the format and optional name qualifier for the identifier to be returned
        /// </summary>
        /// <value>The name ID policy.</value>
        [XmlElement("NameIDPolicy")]
        public NameIDPolicy NameIDPolicy { get; set; }

        #endregion
    }
}
