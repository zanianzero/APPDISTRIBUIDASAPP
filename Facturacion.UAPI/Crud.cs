using System;
using System.Data;
using System.Net;


namespace Facturacion.UAPI
{
    public class Crud<T>
    {
        public T[] Select(string Url)
        {

            try
            {
                using (var api = new webClient())
                {
                    api.headers.add("content-type", "application/json");
                    var json = api.Downloadstring(Url);
                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<T[]>(json);
                    return data;


                }

            }
            catch (WebException ex)
            {
                throw new Exception("Ha sucedido un error inesperado (" + ex.Message + ")");

            }
        }


        public T SelectByID(string Url, string id)
        {

            try
            {

                //por id
                using (var api = new webClient())
                {
                    api.headers.add("content-type", "application/json");
                    var json = api.Downloadstring(Url + "/id" + id);
                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
                    return data;

                }
            }
            catch (WebException ex)
            {
                throw new Exception("Ha sucedido un error inesperado (" + ex.Message + ")");

            }
        }



        public void Update(string Url, string id, T data)
        {
            try
            {

                using (var api = new webClient())
                {
                    api.headers.add("content-type", "application/json");
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    api.UploadString(Url + "/" + id, "PUT", json);
                }

            }
            catch (WebException ex)
            {
                throw new Exception("Ha sucedido un error inesperado (" + ex.Message + ")");

            }

        }

        public T Insert(string Url, T data)
        {
            try
            {
                using (var api = new webClient())
                {
                    api.headers.add("content-type", "application/json");
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                    json = api.UploadString(Url, "POST", json);
                    data = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
                    return data;
                }


            }
            catch (WebException ex)
            {
                throw new Exception("Ha sucedido un error inesperado (" + ex.Message + ")");

            }
        }

        public void Delete(string Url, string id)
        {
            //trycatch al momento de borrar
            try
            {
                using (var api = new webClient())
                {
                    api.headers.add("content-type", "application/json");
                    api.UploadString(Url + "/" + id, "DELETE", "");
                }

            }
            catch (WebException ex)
            {
                throw new Exception("Ha sucedido un error inesperado (" + ex.Message + ")");

            }
        }








    }

}















