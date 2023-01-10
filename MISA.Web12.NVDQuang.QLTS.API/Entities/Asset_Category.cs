namespace MISA.Web12.NVDQuang.QLTS.API.Entities
{
    public class Asset_Category
    {
        #region Property
        // ID Loại tài sản
        public Guid fixed_asset_category_id { get; set; }

        // Mã phòng ban
        public string fixed_asset_category_code { get; set; }

        // Tên phòng ban
        public string fixed_asset_category_name { get; set; }

        // ID của đơn vị
        public Guid organization_id { get; set; }

        // Tỷ lệ hao mòn
        public float depreciation_rate { get; set; }

        // Số năm sử dụng
        public int life_time { get; set; }

        // Ghi chú
        public string description { get; set; }

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
