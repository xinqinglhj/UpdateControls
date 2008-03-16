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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using UpdateControls;

namespace UpdateControls.Test
{
    public partial class ChildForm : UserControl
    {
        private int _item;

        #region Dynamic properties
        // Generated by Update Controls --------------------------------
        private Dynamic _dynItem = new Dynamic();

        public int Item
        {
            get { _dynItem.OnGet(); return _item; }
            set { _dynItem.OnSet(); _item = value; }
        }
        // End generated code --------------------------------
        #endregion

        public ChildForm()
        {
            InitializeComponent();
        }

        private string itemTextBox_GetText()
        {
            return Item.ToString();
        }
    }
}
