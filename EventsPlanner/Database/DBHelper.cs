using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPlanner.Database
{
    class DBHelper
    {
      public static string DeNullString(object o)
        {
            try
            {
                return Convert.IsDBNull(o) ? String.Empty : Convert.ToString(o);
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }

        public static DateTime? GetNullableDateTime(object o, bool silent = true)
        {
            try
            {
                return Convert.IsDBNull(o) ? null : (DateTime?)o;
            }
            catch (Exception)
            {
                if (silent)
                {
                    return null;
                }

                throw;
            }
        }

        public static int DeNullInt(object o, int defaultValue = -1, bool silent = true)
        {
            try
            {
                return Convert.IsDBNull(o) ? defaultValue : Convert.ToInt32(o);
            }
            catch (Exception)
            {
                if (silent)
                {
                    return defaultValue;
                }

                throw;
            }
        }
    }
}
