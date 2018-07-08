using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace ConsistTelerikTest
{



    public partial class _Default : Page
    {
   
        public _Default()
        {
 
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadGrid1_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {

            RadGrid1.DataSource = MockDataStore.Instance.Data;
        }

    }
    public class MockDataStore
    {
        private static MockDataStore _instance;
        public static MockDataStore Instance
        {
            get
            {
                return _instance ?? (_instance = new MockDataStore());
            }
        }
        public DataTable Data { get;  }
    
      
        private MockDataStore()
        {
            Data = new DataTable();
            Data.Columns.Add(new DataColumn() { ColumnName = "AccountId", Caption = "Account" });
            Data.Columns.Add(new DataColumn() { ColumnName = "FirstName", Caption = "First Name" });
            Data.Columns.Add(new DataColumn() { ColumnName = "LastName", Caption = "Last Name" });


            for (int i = 0; i < 1000; i++)
            {
                Data.Rows.Add(new object[] { i, string.Format("Name {0}", i), string.Format("LastName {0}", i) });
            }
         
        }

    }

}
