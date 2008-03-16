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

namespace UpdateControls
{
    /// <summary>
    /// Protects update methods against reentrancy.
    /// <remarks>
    /// Some APIs do not distinguish between user changes and programmatic
    /// changes. A user change should cause a property to be set, but a
    /// programmatic change should not.
    /// <para/>
    /// Create an UpdateController to manage the corresponding dependent
    /// property. Enclose the update method within using (<see cref="BeginUpdate"/>).
    /// Then in the change event, use if (<see cref="NotUpdating"/>) to
    /// ensure that reentrancy has not occurred.
    /// </remarks>
    /// </summary>
    public class UpdateController
    {
        private int _updating = 0;

        public bool NotUpdating { get { return _updating == 0; } }
        public IDisposable BeginUpdating()
        {
            ++_updating;
            return new DisposeHelper(delegate()
            {
                --_updating;
            });
        }
    }
}
