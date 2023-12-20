using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Models
{
    public class VoucherModel
    {
        public int? voucher_id { get; set; }
        public string voucher_name { get; set; }
        public int required_points { get; set; }
        public string voucher_type { get; set; }
        public int voucher_reward { get; set; }

    }
}
