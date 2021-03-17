﻿using System;
using Trading.UI.Demo.Enums;

namespace Trading.UI.Demo.Models
{
    public class PendingOrderModel : OrderModel
    {
        private double _price;
        private PendingOrderType _type;
        private double _limitRangeInPips;
        private bool _isExpiryEnabled;
        private DateTime _expiryTime = DateTime.Now;

        public double Price { get => _price; set => SetProperty(ref _price, value); }

        public PendingOrderType Type { get => _type; set => SetProperty(ref _type, value); }

        public double LimitRangeInPips { get => _limitRangeInPips; set => SetProperty(ref _limitRangeInPips, value); }

        public bool IsExpiryEnabled { get => _isExpiryEnabled; set => SetProperty(ref _isExpiryEnabled, value); }

        public DateTime ExpiryTime { get => _expiryTime; set => SetProperty(ref _expiryTime, value); }
    }
}