using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouseLib
{    
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string MeasureUnit { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        [ForeignKey(nameof(Provider))]
        public int ProviderId { get; set; }
        public List<WareHouseProducts> WareHouseProducts { get; set; }
        public List<SupplyPermissionProducts> SupplyPermissionProducts { get; set; }
        public List<DismissalPermissionProducts> DismissalPermissionProducts { get; set; }
        public bool IsDeleted { get; set; }
        public Provider Provider { get; set; }
        public List<SupplyPermission> SupplyPermission { get; set; }
        public List<ProductMeasureUnit> MeasureUnits { get; set; }
    }
}