/**********************************************************************
 * 
 * Update Controls .NET
 * Copyright 2008 Mallard Software Designs
 * Licensed under LGPL
 * 
 * http://updatecontrols.net
 * http://www.codeplex.com/updatecontrols/
 * 
 **********************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace UpdateControls.Test
{
    public class Order
    {
        private List<Item> _items = new List<Item>();

        #region Dynamic properties
        // Generated by Update Controls --------------------------------
        private Dynamic _dynItems = new Dynamic();

        public Item NewItem()
        {
            _dynItems.OnSet();
            Item item = new Item();
            _items.Add(item);
            return item;
        }

        public void DeleteItem(Item item)
        {
            _dynItems.OnSet();
            _items.Remove(item);
        }

        public IEnumerable<Item> Items
        {
            get { _dynItems.OnGet(); return _items; }
        }
        // End generated code --------------------------------
        #endregion

        public decimal Total
        {
            get
            {
                decimal total = 0;
                foreach (Item item in Items)
                    total += item.Total;
                return total;
            }
        }
    }
}
