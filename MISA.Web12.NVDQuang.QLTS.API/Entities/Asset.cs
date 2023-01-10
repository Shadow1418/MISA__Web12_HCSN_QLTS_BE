namespace MISA.Web12.NVDQuang.QLTS.API.Entities
{
    public class Asset
    {
        // ID tài sản
        public Guid fixed_asset_id { get; set; }

        // Mã tài sản
        public string fixed_asset_code { get; set; }

        // Tên tài sản
        public string fixed_asset_name { get; set; }


        // ID của đơn vị
        public Guid organization_id { get; set; }

        // Mã của đơn vị
        public string organization_code { get; set; }

        // Tên của đơn vị
        public string organization_name { get; set; }

        // ID phòng ban
        public Guid department_id { get; set; }

        // Mã phòng ban
        public string department_code { get; set; }

        // Tên phòng ban
        public string department_name { get; set; }

        // ID loại tài sản
        public Guid fixed_asset_category_id { get; set; }

        // Mã loại tài sản
        public string fixed_asset_category_code { get; set; }

        // Tên loại tài sản
        public string fixed_asset_category_name { get; set; }

        // Ngày mua
        public DateTime purchase_date { get; set; }

        // Nguyên giá
        public string cost { get; set; }

        // Số lượng
        public int quantity { get; set; }

        // Tỷ lệ hao mòn
        public float depreciation_rate { get; set; }

        // Năm bắt đầu theo dõi tài sản trên phần mềm
        public int tracked_year { get; set; }

        // Số năm sử dụng
        public int life_time { get; set; }

        // Năm sử dụng
        public int production_year { get; set; }

        // Trạng thái sử dụng
        public bool active { get; set; }

        // Ngày tạo
        public DateTime created_date { get; set; }

        // Người tạo
        public string created_by { get; set; }

        // Ngày chỉnh sửa gần nhất
        public DateTime modified_date { get; set; }

        // Người chỉnh sửa gần nhất
        public string modified_by { get; set; }

    }
}
