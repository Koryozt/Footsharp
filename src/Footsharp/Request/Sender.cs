using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Footsharp.Exceptions;

namespace Footsharp.Request;

public class Sender
{
	public HttpClient Client { get; init; }
	private HttpMethod Method { get; init; }
	private Uri Address { get; init; }
	private const string UserAgent = "Koryozt.ESPNET";
	private const string TrailingDecimal = ".0";

	public Sender()
	{
		Client = new HttpClient();
		Method = HttpMethod.Get;
		Address = new Uri($"http://site.api.espn.com/apis/site/v2/sports/soccer/");
	}

	public async Task<string> SendAsync(string endpoint, CancellationToken cancellationToken)
	{
		HttpRequestMessage request = new HttpRequestMessage()
		{
			RequestUri = new Uri(Address, endpoint),
			Method = Method,
		};

		string content;

		request.Headers.UserAgent.TryParseAdd(UserAgent);

		try
		{
			HttpResponseMessage response = await Client.SendAsync(request, cancellationToken);

			if (!response.IsSuccessStatusCode)
			{
				throw new LeagueOrCompetitionNotFoundException();
			}

			content = await response.Content.ReadAsStringAsync(cancellationToken);
			content = content.Replace(TrailingDecimal, string.Empty);

			return content;
		}
		catch (InvalidSenderRequestException)
		{
			throw;
		}
	}
}
