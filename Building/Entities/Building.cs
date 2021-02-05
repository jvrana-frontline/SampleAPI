using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FL.PG.PLM_EEM_API.Entities
{
    public class Building
    {
        public int int_BuildingID { get; set; }
        public int int_DistrictID { get; set; }
        public string var_BuildingName { get; set; }
        public string var_BuildingType { get; set; }
        public string var_BuildingAddress2 { get; set; }
        public string var_BuildingAddress1 { get; set; }
        public string var_BuildingCity { get; set; }
        public string var_BuildingState { get; set; }
        public string var_BuildingZip { get; set; }
        public string var_BuildingContact { get; set; }
        public string var_BuildingPhone { get; set; }
        public int int_AdminID { get; set; }
        public int int_Order { get; set; }
        public int int_Admin2ID { get; set; }
        public string var_BuildingCode { get; set; }
        public int int_Admin3ID { get; set; }
        public bool bit_Active { get; set; }
        public int int_Admin4ID { get; set; }
        public int int_Admin5ID { get; set; }
        public string var_BNCESID { get; set; }
        public int int_Admin6ID { get; set; }
        public int int_Admin7ID { get; set; }
        public int int_Admin8ID { get; set; }
        public int int_Admin9ID { get; set; }
        public bool bit_IsExternal { get; set; }
        public string var_RemoteSysName { get; set; }
        public string var_RemoteSysID { get; set; }
    }
}
