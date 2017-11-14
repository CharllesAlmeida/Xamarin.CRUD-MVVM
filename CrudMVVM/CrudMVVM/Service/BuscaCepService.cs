using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using CrudMVVM.Model;





namespace CrudMVVM.Service
{
    public class BuscaCepService
    {

        private static string UrlBase = "https://viacep.com.br/ws/{0}/json/";

        public BuscaCepService()        {

        }

        public async static Task<CEP> BuscaCEP(string cep)
        {
            HttpClient http = new HttpClient();
            string URL = String.Format(UrlBase, cep);
            string json = await http.GetStringAsync(URL);

            CEP objetoCEP = JsonConvert.DeserializeObject<CEP>(json);

            //  string Resultado = string.Format("CEP: {0}, UF:{1}, Endereço: {2}, Cidade: {3}", objetoCEP.cep, objetoCEP.uf, objetoCEP.logradouro, objetoCEP.localidade);
            return objetoCEP;

        }
    }
}