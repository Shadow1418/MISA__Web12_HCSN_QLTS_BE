using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Web12.NVDQuang.QLTS.API.Entities;
using MySqlConnector;
using Swashbuckle.AspNetCore.Annotations;

namespace MISA.Web12.NVDQuang.QLTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, type: typeof(List<Asset>))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAllDepartments()
        {
            try
            {
                // Khởi tạo kết nối Database
                string conectionString = "Server=localhost;Port=3306;Database=misa.web12.hcsn.nvdquang;Uid=root;Pwd=089910;";
                var mySqlConection = new MySqlConnection(conectionString);

                // Khởi tạo câu lệnh truy vấn
                string getAllAssetsCommand = "SELECT * FROM fixed_asset";

                // Thực hiện gọi DB để thực hiện câu lệnh truy vấn ở trên
                var assets = mySqlConection.Query<Asset>(getAllAssetsCommand);

                if (assets != null)
                {
                    return StatusCode(StatusCodes.Status200OK, assets);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "e002");
                }
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpPost]
        public string InsertAsset([FromBody] Asset asset)
        {
            return $"Thêm thành công tài sản {asset.fixed_asset_name}";
        }


        [HttpPut("{assetID}")]
        public string UpdateAsset([FromBody] Asset asset, [FromRoute] Guid assetID)
        {
            return $"Cập nhật tài sản ID {assetID} có tên {asset.fixed_asset_name} thành công";
        }


        [HttpDelete("{assetID}")]
        public string DeleteAsset([FromRoute] Guid assetID)
        {
            return $"Xóa tài sản có ID là {assetID} thành công";
        }

    }
}
