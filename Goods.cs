﻿using System;

namespace Lab1Components
{
    public enum GoodsType
    {
        Food,
        Electronics,
        Furniture
    }

    public class Goods : ISaveableEntity, ISelectable
    {
        public int Id { get; set; }

        public bool Selected { get; set; }
        public GoodsType Type { get; set; }
        public int Price { get; set; }

        public Goods(int id, GoodsType type, int price)
        {
            Id = id;
            Type = type;
            Price = price;
        }

        public double ProcessTime
        {
            get
            {
                switch (Type)
                {
                    case GoodsType.Food:
                        return 0.1;

                    case GoodsType.Electronics:
                        return 0.2;

                    case GoodsType.Furniture:
                        return 0.5;

                    default:
                        throw new InvalidOperationException("unknown item type");
                }
            }
        }
    }
}