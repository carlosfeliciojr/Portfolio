using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoCliente.Util
{
    public class WebAPI
    {
        // Endereço da API.
        public static string TOKEN = "123sfas146sdf46165546dsf";

        private static string RequestGET_DELETE(string metodo, string parametro, string tipo)
        {
            // Realizar uma requisição. "(HttpWebRequest)" é um cast para não ter problemas de tipos
            var request = (HttpWebRequest)WebRequest.Create(URI + metodo + "/" + parametro);
            request.Headers.Add("Token", TOKEN);
            request.Method = tipo;
            // Obtem uma resposta. "(HttpWebResponse)" é um cast.
            var response = (HttpWebResponse)request.GetResponse();
            // Tranforma os dados em formato String para exibir no console.
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        public static string RequestGET(string metodo, string parametro)
        {

            //// MÉTODO GET.
            //// Realizar uma requisição. "(HttpWebRequest)" é um cast para não ter problemas de tipos
            //var request = (HttpWebRequest)WebRequest.Create(URI + metodo + "/" + parametro);
            // Obtem uma resposta. "(HttpWebResponse)" é um cast.
            //var response = (HttpWebResponse)request.GetResponse();
            // Tranforma os dados em formato String para exibir no console.
            //var responseString = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();

            return RequestGET_DELETE(metodo, parametro, "GET");
        }

        public static string RequestDELETE(string metodo, string parametro)
        {

            //// MÉTODO DELETE.
            //// Realizar uma requisição. "(HttpWebRequest)" é um cast para não ter problemas de tipos
            //var request = (HttpWebRequest)WebRequest.Create(URI + metodo + "/" + parametro);
            //request.Headers.Add("Token", TOKEN);
            //request.Method = "DELETE";
            //// Obtem uma resposta. "(HttpWebResponse)" é um cast.
            //var response = (HttpWebResponse)request.GetResponse();
            //// Tranforma os dados em formato String para exibir no console.
            //var responseString = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();

            return RequestGET_DELETE(metodo, parametro, "DELETE");
        }

        public static string RequestPOST(string metodo, string jsonData)
        {
            // MÉTODO POST.
            // Realizar uma requisição. "(HttpWebRequest)" é um cast para não ter problemas de tipos
            var request = (HttpWebRequest)WebRequest.Create(URI + metodo);
            request.Headers.Add("Token", TOKEN);
            // Obtém os dados do postData.
            var data = Encoding.ASCII.GetBytes(jsonData);
            // Configurar método como POST, pois por padrão é GET.
            request.Method = "POST";
            request.Headers.Add("Token", TOKEN);
            // Indicar o content type. É o tipo de conteúdo que está sendo enviado.
            request.ContentType = "application/json";
            // Configurar o content lenght. É o tamanho de conteúdo que está sendo enviado.
            request.ContentLength = data.Length;


            // Envia os dados do POST capturando a resposta para devolver ao usuario.
            using (var stream = request.GetRequestStream())
            {
                // Escreve o conteúdo de data, iniciando em 0, terminando com o tamanho enviado.
                stream.Write(data, 0, data.Length);
            }
            // Recebe a requisição com cast para (HttpWebResponse).
            var response = (HttpWebResponse)request.GetResponse();
            // Instancia novo objeto representando a requisição.
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();


            return responseString;
        }

        public static string RequestPUT(string metodo, string jsonData)
        {
            // MÉTODO POST.
            // Realizar uma requisição. "(HttpWebRequest)" é um cast para não ter problemas de tipos
            var request = (HttpWebRequest)WebRequest.Create(URI + metodo);
            // Obtém os dados do postData.
            var data = Encoding.ASCII.GetBytes(jsonData);
            // Configurar método como POST, pois por padrão é GET.
            request.Method = "PUT";
            request.Headers.Add("Token", TOKEN);
            // Indicar o content type. É o tipo de conteúdo que está sendo enviado.
            request.ContentType = "application/json";
            // Configurar o content lenght. É o tamanho de conteúdo que está sendo enviado.
            request.ContentLength = data.Length;


            // Envia os dados do POST capturando a resposta para devolver ao usuario.
            using (var stream = request.GetRequestStream())
            {
                // Escreve o conteúdo de data, iniciando em 0, terminando com o tamanho enviado.
                stream.Write(data, 0, data.Length);
            }
            // Recebe a requisição com cast para (HttpWebResponse).
            var response = (HttpWebResponse)request.GetResponse();
            // Instancia novo objeto representando a requisição.
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();


            return responseString;
        }


    }
}
