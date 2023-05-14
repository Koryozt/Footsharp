using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ESPNET.Models;
using ESPNET.Query.Soccer;

namespace ESPNET.Request;

public class Sender
{
	public HttpClient Client { get; init; }
	private HttpMethod Method { get; init; }
	private Uri Address { get; init; }
	private const string UserAgent = "Koryozt.ESPNET";

	public Sender(Sports sport)
	{
		Client = new HttpClient();
		Method = HttpMethod.Get;
		Address = new Uri($"http://site.api.espn.com/apis/site/v2/sports/{sport.ToString().ToLower()}/");
	}

	public async Task<string> SendAsync(string endpoint, CancellationToken cancellationToken)
	{
		HttpRequestMessage request = new HttpRequestMessage()
		{
			RequestUri = new Uri(Address, endpoint),
			Method = Method,
		};

		string content = string.Empty;

		request.Headers.UserAgent.TryParseAdd(UserAgent);

		try
		{
			HttpResponseMessage response = await Client.SendAsync(request, cancellationToken);

			Console.WriteLine(response.IsSuccessStatusCode);

			if (response.IsSuccessStatusCode)
			{
				content = await response.Content.ReadAsStringAsync(cancellationToken);
			}

			return content;
		}
		catch (Exception)
		{
			throw;
		}
	}
}
