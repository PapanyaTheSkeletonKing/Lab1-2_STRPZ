﻿using System;
using Services.Services;
using View.Abstractions.PresentersAbstractions;
using View.Views;

namespace View.Presenters
{
    public class OrderOptionsPresenter : IOptionsPresenter
    {
        private readonly GoodsService _goodsService;
        private readonly WarehouseService _warehouseService;
        private readonly StaffService _staffService;
        
        private readonly OrderOptionsView _view;

        public OrderOptionsPresenter(OrderOptionsView view,
            GoodsService goodsService,
            WarehouseService warehouseService,
            StaffService staffService)        
        {
            _goodsService = goodsService;
            _warehouseService = warehouseService;
            _staffService = staffService;

            _view = view;
            SubscribeOnViewEvents();
            
            NotifyPresenterLoaded();
        }

        private void NotifyPresenterLoaded()
        {
            _view.PresenterCreated();
        }
        public void SubscribeOnViewEvents()
        {
            _view.DataRequested += DataLoadHandler;
        }

        private void DataLoadHandler(object sender, EventArgs args)
        {
            _view.ShowAllGoods(_goodsService.GetAll());
            _view.ShowAllWarehouses(_warehouseService.GetAll());
            _view.UpdateChanges();
        }

        
    }
}