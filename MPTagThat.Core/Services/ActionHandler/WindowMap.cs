#region Copyright (C) 2009-2011 Team MediaPortal
// Copyright (C) 2009-2011 Team MediaPortal
// http://www.team-mediaportal.com
// 
// MPTagThat is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// MPTagThat is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with MPTagThat. If not, see <http://www.gnu.org/licenses/>.
#endregion
#region

using System.Collections.Generic;

#endregion

namespace MPTagThat.Core
{
  public class WindowMap
  {
    #region Variales

    private readonly List<Button> mapButtons = new List<Button>();

    #endregion

    #region Properties

    public int Window { get; set; }

    public List<Button> Buttons
    {
      get { return mapButtons; }
    }

    public string Description { get; set; }

    #endregion

    #region ctor

    #endregion
  }
}