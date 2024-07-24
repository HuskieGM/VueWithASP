using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using VueWithASP.Server.Models;
using 玉山.Models.ViewModels;

namespace VueWithASP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly provisionContext _context;
        private readonly ILogger<CompanyController> _logger;

        public CompanyController(provisionContext context, ILogger<CompanyController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // 查詢 API
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Query_Company>>> GetCompanies()
        {
            try
            {
                var companies = await _context.Companies.FromSqlRaw("EXEC SP_COMPANY_SELECT").ToListAsync();
                return Ok(companies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"發生錯誤: {ex.Message}");
            }
        }

        // 新增資料 API
        [HttpPost]
        public async Task<ActionResult> InsertCompany([FromBody] Insert_Company companyDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var outputMessage = new SqlParameter("@O_MESSAGE", System.Data.SqlDbType.NVarChar, 500)
                {
                    Direction = System.Data.ParameterDirection.Output
                };

                await _context.Database.ExecuteSqlRawAsync(
                    "EXEC SP_COMPANY_INSERT @EXPORT_DATE = {0}, " +
                    "@DATA_MONTH = {1}, " +
                    "@COMPANY_CODE = {2}, " +
                    "@COMPANY_NAME = {3}, " +
                    "@INDUSTRY_CATEGORY = {4}, " +
                    "@REVENUE_CURRENT_MONTH = {5}, " +
                    "@REVENUE_LAST_MONTH = {6}, " +
                    "@REVENUE_SAME_MONTH_LAST_YEAR = {7}, " +
                    "@REVENUE_CHANGE_LAST_MONTH_PERCENT = {8}, " +
                    "@REVENUE_CHANGE_SAME_MONTH_LAST_YEAR_PERCENT = {9}, " +
                    "@ACCUMULATED_REVENUE_CURRENT_MONTH = {10}, " +
                    "@ACCUMULATED_REVENUE_LAST_YEAR = {11}, " +
                    "@ACCUMULATED_REVENUE_CHANGE_PERCENT = {12}, " +
                    "@REMARKS = {13}, " +
                    "@O_MESSAGE = {14} OUTPUT",
                    companyDto.ExportDate ?? (object)DBNull.Value,
                    companyDto.DataMonth ?? (object)DBNull.Value,
                    companyDto.CompanyCode ?? (object)DBNull.Value,
                    companyDto.CompanyName ?? (object)DBNull.Value,
                    companyDto.IndustryCategory ?? (object)DBNull.Value,
                    companyDto.RevenueCurrentMonth ?? (object)DBNull.Value,
                    companyDto.RevenueLastMonth ?? (object)DBNull.Value,
                    companyDto.RevenueSameMonthLastYear ?? (object)DBNull.Value,
                    companyDto.RevenueChangeLastMonthPercent ?? (object)DBNull.Value,
                    companyDto.RevenueChangeSameMonthLastYearPercent ?? (object)DBNull.Value,
                    companyDto.AccumulatedRevenueCurrentMonth ?? (object)DBNull.Value,
                    companyDto.AccumulatedRevenueLastYear ?? (object)DBNull.Value,
                    companyDto.AccumulatedRevenueChangePercent ?? (object)DBNull.Value,
                    companyDto.Remarks ?? (object)DBNull.Value,
                    outputMessage
                );

                var message = outputMessage.Value.ToString();
                if (!string.IsNullOrEmpty(message))
                {
                    return BadRequest(message);
                }

                return Ok();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "插入資料時，出現錯誤");
                return StatusCode(StatusCodes.Status500InternalServerError, "請求出現錯誤!");
            }
        }
    }
}
