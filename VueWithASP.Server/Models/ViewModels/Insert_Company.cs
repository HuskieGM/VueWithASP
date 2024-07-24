using System.ComponentModel.DataAnnotations;

namespace 玉山.Models.ViewModels
{
    public class Insert_Company
    {
        public string? ExportDate { get; set; }

        public string? DataMonth { get; set; }

        [Required(ErrorMessage = "Company Code 是必填")]
        public string? CompanyCode { get; set; }

        [Required(ErrorMessage = "Company Name 是必填")]
        public string? CompanyName { get; set; }

        public string? IndustryCategory { get; set; }

        public int? RevenueCurrentMonth { get; set; }

        public int? RevenueLastMonth { get; set; }

        public int? RevenueSameMonthLastYear { get; set; }

        public double? RevenueChangeLastMonthPercent { get; set; }

        public double? RevenueChangeSameMonthLastYearPercent { get; set; }

        public long? AccumulatedRevenueCurrentMonth { get; set; }

        public long? AccumulatedRevenueLastYear { get; set; }

        public double? AccumulatedRevenueChangePercent { get; set; }

        public string? Remarks { get; set; }
    }
}
