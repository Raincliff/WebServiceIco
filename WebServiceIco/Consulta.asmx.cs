using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace WebServiceIco
{
    // <summary>
    // Descripción breve de Consulta
    // </summary>
    [WebService(Namespace = "WebServiceIco")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    //[System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    //[System.Web.Script.Services.ScriptService]
    public class Consulta : System.Web.Services.WebService
    {

        //[WebMethod]
        public DataSet HelloWorld()
        {


            SqlConnection con = new SqlConnection();


            con.ConnectionString = "Data Source=;Initial Catalog=;User ID=;Password=;Integrated Security = false";
            SqlDataAdapter da = new SqlDataAdapter("select * from PEDIDOQM", con);
            DataSet ds = new DataSet();
            //da.Fill(ds);
            ds.GetXml();
            // ds.WriteXml("algo");
            //string strXML = ds.GetXml();
            return ds;

            //doc.LoadXml(ds.GetXml());



        }
        [WebMethod]
        public String GetData()
        {
            SqlConnection con = new SqlConnection();


            con.ConnectionString = "Data Source=;Initial Catalog=RANDOM;User ID=;Password=;Integrated Security = false";
            SqlDataAdapter da = new SqlDataAdapter("select * from PEDIDOQM", con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            string XML = ds.GetXml();
            
            return XML;


                                          
        }



    }
}
