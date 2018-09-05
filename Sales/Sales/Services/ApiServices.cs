﻿namespace Sales.Services
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ApiServices
    {
        public async Task<Response> GetList<T>(string urlBase, string prefix, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var url = $"{prefix}{controller}";
                var response = await client.GetAsync(url);
                var answer = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = answer,
                    };
                }

                var list = Json

            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }    
    }
}
