﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using VueWithASP.Server.Models;

namespace VueWithASP.Server.Models
{
    public partial class provisionContext
    {
        private IprovisionContextProcedures _procedures;

        public virtual IprovisionContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new provisionContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public IprovisionContextProcedures GetProcedures()
        {
            return Procedures;
        }

        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SP_COMPANY_SELECTResult>().HasNoKey().ToView(null);
        }
    }

    public partial class provisionContextProcedures : IprovisionContextProcedures
    {
        private readonly provisionContext _context;

        public provisionContextProcedures(provisionContext context)
        {
            _context = context;
        }

        public virtual async Task<int> SP_COMPANY_INSERTAsync(string EXPORT_DATE, string DATA_MONTH, string COMPANY_CODE, string COMPANY_NAME, string INDUSTRY_CATEGORY, int? REVENUE_CURRENT_MONTH, int? REVENUE_LAST_MONTH, int? REVENUE_SAME_MONTH_LAST_YEAR, double? REVENUE_CHANGE_LAST_MONTH_PERCENT, double? REVENUE_CHANGE_SAME_MONTH_LAST_YEAR_PERCENT, long? ACCUMULATED_REVENUE_CURRENT_MONTH, long? ACCUMULATED_REVENUE_LAST_YEAR, double? ACCUMULATED_REVENUE_CHANGE_PERCENT, string REMARKS, OutputParameter<string> O_MESSAGE, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterO_MESSAGE = new SqlParameter
            {
                ParameterName = "O_MESSAGE",
                Size = 1000,
                Direction = System.Data.ParameterDirection.InputOutput,
                Value = O_MESSAGE?._value ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            };
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "EXPORT_DATE",
                    Size = 10,
                    Value = EXPORT_DATE ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "DATA_MONTH",
                    Size = 10,
                    Value = DATA_MONTH ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "COMPANY_CODE",
                    Size = 10,
                    Value = COMPANY_CODE ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "COMPANY_NAME",
                    Size = 100,
                    Value = COMPANY_NAME ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "INDUSTRY_CATEGORY",
                    Size = 100,
                    Value = INDUSTRY_CATEGORY ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "REVENUE_CURRENT_MONTH",
                    Value = REVENUE_CURRENT_MONTH ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "REVENUE_LAST_MONTH",
                    Value = REVENUE_LAST_MONTH ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "REVENUE_SAME_MONTH_LAST_YEAR",
                    Value = REVENUE_SAME_MONTH_LAST_YEAR ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "REVENUE_CHANGE_LAST_MONTH_PERCENT",
                    Value = REVENUE_CHANGE_LAST_MONTH_PERCENT ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Float,
                },
                new SqlParameter
                {
                    ParameterName = "REVENUE_CHANGE_SAME_MONTH_LAST_YEAR_PERCENT",
                    Value = REVENUE_CHANGE_SAME_MONTH_LAST_YEAR_PERCENT ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Float,
                },
                new SqlParameter
                {
                    ParameterName = "ACCUMULATED_REVENUE_CURRENT_MONTH",
                    Value = ACCUMULATED_REVENUE_CURRENT_MONTH ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.BigInt,
                },
                new SqlParameter
                {
                    ParameterName = "ACCUMULATED_REVENUE_LAST_YEAR",
                    Value = ACCUMULATED_REVENUE_LAST_YEAR ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.BigInt,
                },
                new SqlParameter
                {
                    ParameterName = "ACCUMULATED_REVENUE_CHANGE_PERCENT",
                    Value = ACCUMULATED_REVENUE_CHANGE_PERCENT ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Float,
                },
                new SqlParameter
                {
                    ParameterName = "REMARKS",
                    Size = 200,
                    Value = REMARKS ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                parameterO_MESSAGE,
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[SP_COMPANY_INSERT] @EXPORT_DATE = @EXPORT_DATE, @DATA_MONTH = @DATA_MONTH, @COMPANY_CODE = @COMPANY_CODE, @COMPANY_NAME = @COMPANY_NAME, @INDUSTRY_CATEGORY = @INDUSTRY_CATEGORY, @REVENUE_CURRENT_MONTH = @REVENUE_CURRENT_MONTH, @REVENUE_LAST_MONTH = @REVENUE_LAST_MONTH, @REVENUE_SAME_MONTH_LAST_YEAR = @REVENUE_SAME_MONTH_LAST_YEAR, @REVENUE_CHANGE_LAST_MONTH_PERCENT = @REVENUE_CHANGE_LAST_MONTH_PERCENT, @REVENUE_CHANGE_SAME_MONTH_LAST_YEAR_PERCENT = @REVENUE_CHANGE_SAME_MONTH_LAST_YEAR_PERCENT, @ACCUMULATED_REVENUE_CURRENT_MONTH = @ACCUMULATED_REVENUE_CURRENT_MONTH, @ACCUMULATED_REVENUE_LAST_YEAR = @ACCUMULATED_REVENUE_LAST_YEAR, @ACCUMULATED_REVENUE_CHANGE_PERCENT = @ACCUMULATED_REVENUE_CHANGE_PERCENT, @REMARKS = @REMARKS, @O_MESSAGE = @O_MESSAGE OUTPUT", sqlParameters, cancellationToken);

            O_MESSAGE.SetValue(parameterO_MESSAGE.Value);
            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<SP_COMPANY_SELECTResult>> SP_COMPANY_SELECTAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<SP_COMPANY_SELECTResult>("EXEC @returnValue = [dbo].[SP_COMPANY_SELECT]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}