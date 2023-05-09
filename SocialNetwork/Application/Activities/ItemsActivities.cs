using BusinessDomain.Model;
using MediatR;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Activities
{
	public class ItemsActivities
	{
		public class Query : IRequest<List<Activeness>> { }

		public class Handler : IRequestHandler<Query, List<Activeness>>
		{
			private readonly DataContext context;

			public Handler(DataContext context)
			{
				this.context = context;
			}

			async Task<List<Activeness>> IRequestHandler<Query, List<Activeness>>.Handle(Query request, CancellationToken cancellationToken)
			{
				return await context.Activities.ToListAsync(cancellationToken);
			}
		}
	}
}
