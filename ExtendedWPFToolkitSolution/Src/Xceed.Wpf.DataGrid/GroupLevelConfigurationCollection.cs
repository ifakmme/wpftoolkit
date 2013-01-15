﻿/************************************************************************

   Extended WPF Toolkit

   Copyright (C) 2010-2012 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   For more features, controls, and fast professional support,
   pick up the Plus edition at http://xceed.com/wpf_toolkit

   Visit http://xceed.com and follow @datagrid on Twitter

  **********************************************************************/

using System;
using System.Collections.ObjectModel;
using Xceed.Wpf.DataGrid.Views;
using Xceed.Wpf.DataGrid.Markup;
using System.ComponentModel;

namespace Xceed.Wpf.DataGrid
{
  [EditorBrowsable( EditorBrowsableState.Never )]
  [Obsolete( "The GroupLevelConfigurationCollection class is obsolete and has been replaced by the LevelGroupConfigurationSelectorItemCollection class.", true )]
  public class GroupLevelConfigurationCollection : ObservableCollection<GroupLevelConfiguration>
  {
  }
}