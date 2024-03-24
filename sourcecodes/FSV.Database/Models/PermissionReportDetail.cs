﻿// FolderSecurityViewer is an easy-to-use NTFS permissions tool that helps you effectively trace down all security owners of your data.
// Copyright (C) 2015 - 2024  Carsten Schäfer, Matthias Friedrich, and Ritesh Gite
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

namespace FSV.Database.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class PermissionReportDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required] public int PermissionReportId { get; set; }

        [MapAtttribute("sAMAccountName")] public string AccountName { get; set; }

        [MapAtttribute("givenName")] public string FirstName { get; set; }

        [MapAtttribute("sn")] public string LastName { get; set; }

        [MapAtttribute("mail")] public string Email { get; set; }

        [MapAtttribute("department")] public string Department { get; set; }

        [MapAtttribute("division")] public string Division { get; set; }

        [MapAtttribute("Domain")] public string Domain { get; set; }

        [MapAtttribute("OriginatingGroup")] public string OriginatingGroup { get; set; }

        [MapAtttribute("Rights")] public string Permissions { get; set; }

        public virtual PermissionReport PermissionReport { get; set; }
    }
}