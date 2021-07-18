using System.Collections.Generic;
using System.Linq;

namespace Rentoolo.Model
{
    public static class DataHelperPelmenier
    {
        public static List<Newspelmenier> GetActiveNews()
        {
            using (var ctx = new RentooloEntities())
            {
                var list = ctx.Newspelmenier.Where(x => x.Active).OrderByDescending(x => x.Date).ToList();

                return list;
            }
        }
    }
}