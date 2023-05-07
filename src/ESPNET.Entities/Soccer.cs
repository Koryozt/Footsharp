using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ESPNET.Models.Soccer;
using ESPNET.Request;

namespace ESPNET;
public sealed class Soccer
{
	private Sender Sender { get; init; }

	public Soccer()
	{
		Sender = new Sender();
	}

	public async Task<SoccerLeague> GetSoccerEnglandLeagueAsync(
		int division = 1,
		CancellationToken cancellationToken = default)
	{
		
		var respnose = await Sender.SendAsync();
	}
}
