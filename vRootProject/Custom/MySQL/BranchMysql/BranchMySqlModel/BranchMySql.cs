﻿using CoreLayer.Enum.BusinessEnums;
using CoreLayer.Models;
using System.ComponentModel.DataAnnotations;

namespace vRootProject.Custom.MySQL.BranchMysql.BranchMySqlModel
{
    public class BranchMySql: BaseEntity
    {
        [Key]
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string R_Code { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string OtherMobile { get; set; }
        public string HomePhone { get; set; }
        public string Photo { get; set; }
        public string WhatsAppNo { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; }
        public int NumberOfEmployee { get; set; }
        public string OwnerShip { get; set; }
        public string Website { get; set; }
        public string FacebookPage { get; set; }
        public string LinkedPage { get; set; }
        public string Email { get; set; }
        public TimeZones TimeZone { get; set; }
        public ProductType Type { get; set; }
        public string Address { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? GovernmentId { get; set; }
        public int? AreaId { get; set; }
        public string SpecialMark { get; set; }
        public int CompanyId { get; set; }
        public int? IndustryId { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
