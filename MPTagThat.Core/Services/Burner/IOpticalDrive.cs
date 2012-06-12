﻿#region Copyright (C) 2009-2011 Team MediaPortal
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
namespace MPTagThat.Core.Burning
{
  /// <summary>
  ///   Interface for optical hardware devices like DVD burners
  /// </summary>
  public interface IOpticalDrive
  {
    /// <summary>
    ///   the SCSI bus id to be used by cdrtools
    /// </summary>
    string BusId { get; }

    /// <summary>
    ///   the vendor's device identification string
    /// </summary>
    string DeviceName { get; }

    /// <summary>
    ///   the vendor's name
    /// </summary>
    string DeviceVendor { get; }

    /// <summary>
    ///   indicates whether there's a disc present
    /// </summary>
    bool HasMedia { get; }

    /// <summary>
    ///   The Selected Write Speed for the device
    /// </summary>
    int SelectedWriteSpeed { get; set; }

    //bool IsDeviceInUse();
    //bool IsAutoPlayEnabled();
  }
}