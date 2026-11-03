using System;
using System.ComponentModel;

namespace EntitiesLayer
{
    public class DailyReport
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Tarih")]
        public DateTime ReportDate { get; set; }

        [DisplayName("Kart Toplam")]
        public decimal CardTotal { get; set; }

        [DisplayName("Nakit Toplam")]
        public decimal CashTotal { get; set; }

        [DisplayName("Çek Toplam")]
        public decimal CheckTotal { get; set; }

        [DisplayName("Ciro")]
        public decimal Revenue { get; set; }
    }
}
