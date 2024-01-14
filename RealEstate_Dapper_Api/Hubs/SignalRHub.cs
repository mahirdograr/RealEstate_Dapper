using Microsoft.AspNetCore.SignalR;

namespace RealEstate_Dapper_Api.Hubs
{
    public class SignalRHub:Hub
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public SignalRHub(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task SendCategoryCount()
		{
			#region Statistics7
			var client7 = _httpClientFactory.CreateClient();
			var responseMessage7 = await client7.GetAsync("https://localhost:44331/api/Statistics/CategoryCount");
			var value = await responseMessage7.Content.ReadAsStringAsync();
			await Clients.All.SendAsync("ReceiveCategoryCount", value);
			//clients signalr kanal gibi çalışıyor
			#endregion
		}
	}
}
