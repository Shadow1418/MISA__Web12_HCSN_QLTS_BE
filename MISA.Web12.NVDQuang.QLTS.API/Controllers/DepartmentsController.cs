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
    public class DepartmentsController : ControllerBase
    {
        /// <summary>
        /// API Lấy toàn bộ danh sách phòng ban
        /// </summary>
        /// <returns>Danh sách phòng ban</returns>
        /// Created by: NVDQuang (08/01/2023)
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, type: typeof(List<Department>))]
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
                string getAllDepartmentsCommand = "SELECT * FROM department";

                // Thực hiện gọi DB để thực hiện câu lệnh truy vấn ở trên
                var departments = mySqlConection.Query<Department>(getAllDepartmentsCommand);

                if (departments != null)
                {
                    return StatusCode(StatusCodes.Status200OK, departments);
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
    }
}
