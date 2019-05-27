using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Website.ViewModels
{
    public class StockViewModel
    {
        public string StockId { get; set; }

        public int Discount { get; set; }

        public bool IsActive { get; set; }

        public string StockTitle { get; set; }

        public string StockDescription { get; set; }

        public string ImageFilename { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }
    }
}