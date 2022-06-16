// Copyright (C) 2022 Brandon Hook
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace SQLHelper_Civ.Globals
{
    public static class Globals
    {
        public const string ConfigurationName = "Configuration";
        public const string LocalizationName = "Localization";
        public const string GameplayName = "Gameplay";

        public const string All = "<All>";
        public const string None = "<None>";

        public enum InsertTypes
        {
            Insert = 0,
            InsertOrIgnore,
            InsertOrReplace
        }
    }
}
