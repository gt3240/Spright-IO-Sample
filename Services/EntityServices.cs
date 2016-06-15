using Microsoft.Practices.Unity;
using Sabio.Data;
using Sabio.Web.Domain;
using Sabio.Web.Enums;
using Sabio.Web.Models.Requests;
using Sabio.Web.Models.Requests.EVA;
using Sabio.Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Sabio.Web.Services
{
    public class EntityServices : BaseService, IEntityServices
    {
        [Dependency]
        public IAttributeServices AttrService { get; set; }

        public int Insert(EVA_EntityRequestModel model)
        {
            int oid = 0;

            DataProvider.ExecuteNonQuery(GetConnection, "dbo.EVA_Entity_Insert"
               , inputParamMapper: delegate (SqlParameterCollection paramCollection)
               {
                   paramCollection.AddWithValue("@WebsiteId", model.WebsiteId);
                   paramCollection.AddWithValue("@Name", model.Name);
                   paramCollection.AddWithValue("@Slug", model.Slug);

                   SqlParameter p = new SqlParameter("@OID", System.Data.SqlDbType.Int);
                   p.Direction = System.Data.ParameterDirection.Output;

                   paramCollection.Add(p);

               }, returnParameters: delegate (SqlParameterCollection param)
               {
                   int.TryParse(param["@OID"].Value.ToString(), out oid);
               }
               );
            return oid;
        }

    }
}
