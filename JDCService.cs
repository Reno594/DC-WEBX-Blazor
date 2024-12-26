using System.Net.Http.Json;

namespace BlazorWebAssembly.Client.Services
{
    public class JDCService
    {
        private readonly HttpClient _httpClient;

        public JDCService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<JDC_Razon>> GetJDCsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<JDC_Razon>>("api/jdcs");
        }

        public async Task AddJDCAsync(JDC_Razon jdc)
        {
            await _httpClient.PostAsJsonAsync("api/jdcs", jdc);
        }
    }
}

