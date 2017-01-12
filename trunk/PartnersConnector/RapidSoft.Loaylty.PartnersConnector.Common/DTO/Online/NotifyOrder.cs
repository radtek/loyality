﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 
namespace RapidSoft.Loaylty.PartnersConnector.Common.DTO.Online
{
    using System.Xml.Serialization;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class NotifyOrder
    {

        private NotifyOrderItem[] itemField;

        private string userTicketField;

        private string shopIdField;

        private string orderIdField;

        private decimal totalCostField;

        private sbyte orderStatusField;

        private string internalStatusCodeField;

        private string descriptionField;

        private System.DateTime dateTimeField;

        private System.DateTime utcDateTimeField;

        private string signatureField;

        /// <remarks/>
        [XmlElement("Item")]
        public NotifyOrderItem[] Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string UserTicket
        {
            get
            {
                return this.userTicketField;
            }
            set
            {
                this.userTicketField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string ShopId
        {
            get
            {
                return this.shopIdField;
            }
            set
            {
                this.shopIdField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string OrderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal TotalCost
        {
            get
            {
                return this.totalCostField;
            }
            set
            {
                this.totalCostField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public sbyte OrderStatus
        {
            get
            {
                return this.orderStatusField;
            }
            set
            {
                this.orderStatusField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string InternalStatusCode
        {
            get
            {
                return this.internalStatusCodeField;
            }
            set
            {
                this.internalStatusCodeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public System.DateTime DateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public System.DateTime UtcDateTime
        {
            get
            {
                return this.utcDateTimeField;
            }
            set
            {
                this.utcDateTimeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    public partial class NotifyOrderItem
    {

        private string idField;

        private string articleIdField;

        private string articleNameField;

        private int amountField;

        private decimal priceField;

        private int bonusPriceField;

        private int weightField;

        private string commentField;

        /// <remarks/>
        [XmlAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string ArticleId
        {
            get
            {
                return this.articleIdField;
            }
            set
            {
                this.articleIdField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string ArticleName
        {
            get
            {
                return this.articleNameField;
            }
            set
            {
                this.articleNameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int BonusPrice
        {
            get
            {
                return this.bonusPriceField;
            }
            set
            {
                this.bonusPriceField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int Weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }
    }
}
