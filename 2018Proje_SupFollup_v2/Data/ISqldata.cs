using System.Data.SqlClient;

namespace _2018Proje_SupFollup_v2.Data
{
    public interface ISqldata
    {
        SqlConnection connection { get;}
        SqlCommand command { get; }
        
    }
}
