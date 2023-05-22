using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionGUI
{
    public static class ConfigConnection
    {
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["ProyectoConnection"].ConnectionString;
    }
}
