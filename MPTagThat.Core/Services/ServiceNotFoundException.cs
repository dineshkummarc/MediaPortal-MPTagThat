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

using System;
using System.Globalization;

#endregion

namespace MPTagThat.Core
{
  /// <summary>
  ///   Occurs when requested service is not found in the current- or one of its parent <see cref = "ServiceScope" />s.
  /// </summary>
  [Serializable]
  public class ServiceNotFoundException : Exception
  {
    private readonly Type serviceType;

    public ServiceNotFoundException() {}

    public ServiceNotFoundException(string message)
      : base(message) {}

    public ServiceNotFoundException(string message, Exception innerException)
      : base(message, innerException) {}

    /// <summary>
    ///   Creates a new <see cref = "ServiceNotFoundException" /> instance, and initializes it with the given type.
    /// </summary>
    /// <param name = "serviceType">the type of service that was not found.</param>
    public ServiceNotFoundException(Type serviceType)
      : base(string.Format(CultureInfo.InvariantCulture, "Could not find the {0} service", serviceType))
    {
      this.serviceType = serviceType;
    }

    /// <summary>
    ///   Returns the type of the service that was not found.
    /// </summary>
    public Type ServiceType
    {
      get { return serviceType; }
    }
  }
}