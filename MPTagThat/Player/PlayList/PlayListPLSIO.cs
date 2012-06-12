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
using System.IO;
using System.Text;
using MPTagThat.Core;

#endregion

namespace MPTagThat.Player
{
  public class PlayListPLSIO : IPlayListIO
  {
    private const string START_PLAYLIST_MARKER = "[playlist]";
    private const string PLAYLIST_NAME = "PlaylistName";

    #region IPlayListIO Members

    public bool Load(SortableBindingList<PlayListData> playlist, string fileName)
    {
      string basePath = String.Empty;
      Stream stream;

      basePath = Path.GetDirectoryName(Path.GetFullPath(fileName));
      stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);

      playlist.Clear();
      Encoding fileEncoding = Encoding.Default;
      StreamReader file = new StreamReader(stream, fileEncoding, true);
      if (file == null)
      {
        return false;
      }

      string line;
      line = file.ReadLine();
      if (line == null)
      {
        file.Close();
        return false;
      }

      string strLine = line.Trim();
      //CUtil::RemoveCRLF(strLine);
      if (strLine != START_PLAYLIST_MARKER)
      {
        fileEncoding = Encoding.Default;
        stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
        file = new StreamReader(stream, fileEncoding, true);
      }

      string infoLine = "";
      string durationLine = "";
      fileName = "";
      line = file.ReadLine();
      while (line != null)
      {
        strLine = line.Trim();
        //CUtil::RemoveCRLF(strLine);
        int equalPos = strLine.IndexOf("=");
        if (equalPos > 0)
        {
          string leftPart = strLine.Substring(0, equalPos);
          equalPos++;
          string valuePart = strLine.Substring(equalPos);
          leftPart = leftPart.ToLower();
          if (leftPart.StartsWith("file"))
          {
            if (valuePart.Length > 0 && valuePart[0] == '#')
            {
              line = file.ReadLine();
              continue;
            }

            if (fileName.Length != 0)
            {
              PlayListData newItem = new PlayListData(infoLine, fileName, "0");
              playlist.Add(newItem);
              fileName = "";
              infoLine = "";
              durationLine = "";
            }
            fileName = valuePart;
          }
          if (leftPart.StartsWith("title"))
          {
            infoLine = valuePart;
          }
          else
          {
            if (infoLine == "")
            {
              infoLine = Path.GetFileName(fileName);
            }
          }
          if (leftPart.StartsWith("length"))
          {
            durationLine = valuePart;
          }

          if (durationLine.Length > 0 && infoLine.Length > 0 && fileName.Length > 0)
          {
            string duration = durationLine;

            // Remove trailing slashes. Might cause playback issues
            if (fileName.EndsWith("/"))
            {
              fileName = fileName.Substring(0, fileName.Length - 1);
            }

            Util.GetQualifiedFilename(basePath, ref fileName);
            PlayListData newItem = new PlayListData(infoLine, fileName, Util.SecondsToHMSString(duration));
            playlist.Add(newItem);
            fileName = "";
            infoLine = "";
            durationLine = "";
          }
        }
        line = file.ReadLine();
      }
      file.Close();

      if (fileName.Length > 0)
      {
        PlayListData newItem = new PlayListData(infoLine, fileName, "0");
      }


      return true;
    }

    public void Save(SortableBindingList<PlayListData> playlist, string fileName, bool useRelativePath)
    {
      using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.Default))
      {
        writer.WriteLine(START_PLAYLIST_MARKER);
        for (int i = 0; i < playlist.Count; i++)
        {
          PlayListData item = playlist[i];

          string musicFile = item.FileName;
          if (useRelativePath)
          {
            musicFile =
              Path.Combine(
                Util.RelativePathTo(Path.GetDirectoryName(fileName), Path.GetDirectoryName(item.FileName)),
                Path.GetFileName(item.FileName));
          }
          writer.WriteLine("File{0}={1}", i + 1, musicFile);
          writer.WriteLine("Title{0}={1}", i + 1, string.Format("{0} - {1}", item.Artist, item.Title));
          writer.WriteLine("Length{0}={1}", i + 1, Util.DurationToSeconds(item.Duration));
        }
        writer.WriteLine("NumberOfEntries={0}", playlist.Count);
        writer.WriteLine("Version=2");
      }
    }

    #endregion
  }
}