// FolderSecurityViewer is an easy-to-use NTFS permissions tool that helps you effectively trace down all security owners of your data.
// Copyright (C) 2015 - 2024  Carsten Sch�fer, Matthias Friedrich, and Ritesh Gite
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.

namespace FSV.AdServices
{
    using System;
    using Cache;

    public static class PrincipalContextCacheExtensions
    {
        public static bool TryGetContext(this IPrincipalContextCache cache, string contextKey, out PrincipalContextInfo context, Func<PrincipalContextInfo> addIfMissing)
        {
            if (cache == null)
            {
                throw new ArgumentNullException(nameof(cache));
            }

            if (addIfMissing == null)
            {
                throw new ArgumentNullException(nameof(addIfMissing));
            }

            if (string.IsNullOrWhiteSpace(contextKey))
            {
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(contextKey));
            }

            if (cache.TryGetContext(contextKey, out context) == false)
            {
                context = addIfMissing();
                if (context != null)
                {
                    cache.AddContext(contextKey, context);
                }
            }

            return context != null;
        }
    }
}