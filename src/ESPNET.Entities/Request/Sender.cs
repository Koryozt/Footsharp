using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ESPNET.Request;

public sealed class Sender
{
	public HttpClient Client { get; init; }
	private HttpMethod Method { get; init; }
	private Uri Address { get; init; } 
	private const string UserAgent = ".NET.ESPNET.Package";

	public Sender()
	{
		Client = new HttpClient();
		Method = HttpMethod.Get;
		Address = new Uri("http://site.api.espn.com/apis/site/v2/sports/");
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
