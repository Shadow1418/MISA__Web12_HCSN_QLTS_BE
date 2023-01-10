namespace MISA.Web12.NVDQuang.QLTS.API.Entities
{
    public class Department
    {
        #region Property
        // ID phòng ban
        public Guid department_id { get; set; }

        // Mã phòng ban
        public string department_code { get; set; }

        // Tên phòng ban
        public string department_name { get; set; }

        // Ghi chú
        public string description { get; set; }

        // Có phải là cha không
        public string is_parent { get; set; }

        // ID phòng ban cha
        public Guid parent_id { get; set; }

        // ID đơn vị
        public Guid organization_id { get; set; }

        // Ngày tạo
        public DateTime created_date { get; set; }

        // Người tạo
        public string created_by { get; set; }

        // Ngày chỉnh sửa gần nhất
        public DateTime modified_date { get; set; }

        // Người chỉnh sửa gần nhất
        public string modified_by { get; set; } 
        #endregion
    }
}
