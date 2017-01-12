﻿namespace RapidSoft.Loaylty.PartnersConnector.Interfaces.Entities
{
	using System;
	using System.Runtime.Serialization;

	[DataContract]
	[Serializable]
	public class Order
	{
		/// <summary>
		/// Идентификатор заказа
		/// </summary>
		[DataMember]
		public int Id
		{
			get;
			set;
		}

		/// <summary>
		/// Идентификатор заказа в информационной системе партнёра предоставленный партнёром во время подтверждения заказа.
		/// </summary>
		[DataMember]
		public string ExternalOrderId
		{
			get;
			set;
		}

		/// <summary>
		/// Идентификатор партнёра.
		/// </summary>
		[DataMember]
		public int PartnerId
		{
			get;
			set;
		}

		/// <summary>
		/// Статус заказа
		/// </summary>
		[DataMember]
		public OrderStatuses Status
		{
			get;
			set;
		}

		/// <summary>
		/// Код статуса в информационной системе поставщика. Предназначен для сверок. Не обязателен к заполнению.
		/// </summary>
		[DataMember]
		public string ExternalOrderStatusCode
		{
			get;
			set;
		}

		/// <summary>
		/// Текстовое пояснение статуса заказа от партнёра
		/// </summary>
		[DataMember]
		public string ExternalOrderStatusDescription
		{
			get;
			set;
		}

		/// <summary>
		/// Дата и время изменения статуса в информационной системе поставщика.
		/// </summary>
		public DateTime? ExternalOrderStatusDateTime
		{
			get;
			set;
		}

		/// <summary>
		/// Дата и время последнего обновления статуса заказа
		/// </summary>
		[DataMember]
		public DateTime StatusChangedDate
		{
			get;
			set;
		}

		/// <summary>
		/// Сведения о доставке
		/// </summary>
		[DataMember]
		public DeliveryInfo DeliveryInfo
		{
			get;
			set;
		}

		/// <summary>
		/// Дата и время создания заказа.
		/// </summary>
		[DataMember]
		public DateTime InsertedDate
		{
			get;
			set;
		}

		/// <summary>
		/// Имя пользователя в системе безопасности, который создал заказ.
		/// </summary>
		[DataMember]
		public string InsertedUserId
		{
			get;
			set;
		}

		/// <summary>
		/// Имя пользователя в системе безопасности, который внес последнее изменение.
		/// </summary>
		[DataMember]
		public string UpdatedUserId
		{
			get;
			set;
		}

		/// <summary>
		/// Массив записей типа «Позиция заказа»
		/// </summary>
		[DataMember]
		public OrderItem[] Items
		{
			get;
			set;
		}

		/// <summary>
		/// Вес заказа. Рассчитывается по формуле: Item.Weight * Item.Amount.
		/// </summary>
		[DataMember]
		public int TotalWeight
		{
			get;
			set;
		}

		/// <summary>
		/// Стоимость заказа в рублях с учетом количества заказанных экземпляров, но без учета стоимости доставки.  Рассчитывается по формуле Item.Price * Item.Amount.
		/// </summary>
		[DataMember]
		public decimal ItemsCost
		{
			get;
			set;
		}

		/// <summary>
		/// ItemsCost в баллах
		/// </summary>
		[DataMember]
		public decimal BonusItemsCost
		{
			get;
			set;
		}

		/// <summary>
		/// Стоимость доставки заказа в рублях. Если доставка не включена в заказ или не поддерживается поставщиком, то значение равно нулю.
		/// </summary>
		[DataMember]
		public decimal DeliveryCost
		{
			get;
			set;
		}

		/// <summary>
		/// DeliveryCost в баллах
		/// </summary>
		[DataMember]
		public decimal BonusDeliveryCost
		{
			get;
			set;
		}

		/// <summary>
		/// Полная стоимость заказа с учетом доставки. Рассчитывается по формуле: ItemsCost + DeliveryCost. Если доставка не включена в заказ или не поддерживается поставщиком, то значение равно ItemsCost.
		/// </summary>
		[DataMember]
		public decimal TotalCost
		{
			get;
			set;
		}

		/// <summary>
		/// Полная стоимость заказа TotalCost в баллах
		/// </summary>
		[DataMember]
		public decimal BonusTotalCost
		{
			get;
			set;
		}

		[DataMember]
		public string ClientId
		{
			get;
			set;
		}
	}
}