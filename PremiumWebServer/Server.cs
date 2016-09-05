using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PubNubMessaging.Core;
using Newtonsoft.Json;
using System.Reflection;
using MySql.Data.MySqlClient;
using System.Data;

namespace PremiumWebServer
{
    class Server
    {
        Message MsgActual;
        //estatus de la conexion con la bd
        public enum DbServerEstatus {Activo=1,Desactivado=0,Error=3}
        
       // static dynamic reader;
        static  MySqlDataReader dr;
        MySqlConnection mysql = new MySqlConnection();
        static Pubnub pubnub;
      

        public Server(string pubkey,string subkey,string servername)
        {
            //"pub-c-358c0c48-3aa1-45d2-b23c-f4a789ab414e", "sub-c-c930c986-cdc4-11e5-8a35-0619f8945a4f"
            pubnub = new Pubnub(pubkey,subkey);
            pubnub.Subscribe(servername, subscribeCallback, connectCallback, errorCallback);
            DbConexionEstatus = DbServerEstatus.Desactivado;
        }

        private void errorCallback(PubnubClientError obj)
        {
            throw new NotImplementedException("Error Al iniciar el servidor consulte con el administrador");
        }

        public DbServerEstatus StartDbService()
        {
          
            mysql.ConnectionString  = "server=" + Mysqlserver + ";user=" + Mysqldbuser + ";database=" + MysqlDb + ";port=" + Mysqldbport + ";password=" + Mysqldbkey + ";" + "pooling = false; convert zero datetime = True;";
            try
            {
                mysql.Open();
                DbConexionEstatus = DbServerEstatus.Activo;
               
            }
            catch (Exception)
            {
                DbConexionEstatus = DbServerEstatus.Error;
            }
            return DbConexionEstatus;
            // pubnub.Publish<string>(Chanel, "{Type:\"Select\"}",userCallback,errorCallback);
        }

        private void userCallback(string obj)
        {
       
        }

    

        private void connectCallback(object obj)
        {
            var objeto = ((List<object>)obj).ToArray();

            Console.WriteLine("Listenig Estatus:{1}", objeto);
          
        }

        private void subscribeCallback(object obj)
        {
            var x = ((List<object>)obj).ToArray();
            GetMessage(x[0]);
            
        }

        public void GetMessage(object message)
        {

            try
            {
                Message msg = JsonConvert.DeserializeObject<Message>(message.ToString());
              
                    MsgActual = msg;
                    ExecuteCommand(msg);
                   
              
            }catch(Exception)
            {
                Console.WriteLine("Comando Erroneo");
               
            }
        }
        private void ExecuteCommand(Message msg)
        {
            var method = (this.GetType()).GetMethod(msg.Type);
            method.Invoke(this, null);
        }

        public void Select()
        {
            Console.WriteLine("Instrucion Select Ejecutada");
            string sql = "SELECT " + MsgActual.Camps + " FROM " + MsgActual.Table+" WHERE "+MsgActual.Where;
            MySqlCommand cmd = new MySqlCommand(sql, mysql);
            cmd.CommandTimeout = 0;
            MySqlDataReader dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            List<DataRow> result = dt.AsEnumerable().ToList();
            string JSONresult;
            JSONresult = JsonConvert.SerializeObject(dt);

            pubnub.Publish(MsgActual.From, JSONresult, userCallback2, errorCallback);
        }
        public void Sql()
        {
           
          
            try { 
           
            string sql = MsgActual.Msg;
          {
                using (MySqlCommand cmd = new MySqlCommand(sql, mysql))
                {
                            dr = cmd.ExecuteReader();
                            Console.WriteLine("Instrucion Sql Ejecutada");


                            cmd.CommandTimeout = 0;
                            var dt = new DataTable();
                            
                            dt.Load(dr);
                            List<DataRow> result = dt.AsEnumerable().ToList();
                            string JSONresult;
                            JSONresult = JsonConvert.SerializeObject(dt);
                            if (JSONresult == "[]"){
                            if( (MsgActual.Msg.ToUpper()).Contains("DELETE"))
                            {
                                JSONresult = "[{\"Msg\":\"Se Elimino el(los) Registro(s)\"}]";
                            }
                            else if ((MsgActual.Msg.ToUpper()).Contains("UPDATE"))
                            {
                                JSONresult = "[{\"Msg\":\"Se Actualizo el(los) Registro(s)\"}]";
                            }else

                            {
                                JSONresult = "[{\"Msg\":\"No Existe Informacion\"}]";
                            }
                                                            
                            }
                            pubnub.Publish(MsgActual.From, JSONresult, userCallback2, errorCallback);
                            Console.WriteLine("Instrucion Sql Ejecutada");
                            dr.Close();
                    
                }
            }
            }catch(Exception err)
            {
                try
                {
                    dr.Close();
                }
                catch
                {

                }
                Error nerror = new Error { Msg = "Error:" + err.Message };
                var errorresult = JsonConvert.SerializeObject(nerror); ;
               
                pubnub.Publish(MsgActual.From, errorresult, userCallback2, errorCallback);
                
            }
  
     

        }
       
        private void userCallback2(object obj)
        {

        }
        #region SectionProperties
        public string Subkey { get; set; }
        public string Pubkey { get; set; }
        public string ServerName { get; set; }
        public DbServerEstatus DbConexionEstatus { get; set; }
        public string Mysqldbuser { get;  set; }
        public string Mysqlserver { get; set; }
        public string MysqlDb { get;  set; }
        public string Mysqldbport { get;  set; }
        public string Mysqldbkey { get; set; }
        #endregion
    }
}
