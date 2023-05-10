﻿using Application.Activities;
using BusinessDomain.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace PresentationAPI.Controllers
{
	public class ActivenessController : BaseController
	{
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Activeness>>> Get()
		{
			return await Mediator.Send(new ItemsActivities.Query());

		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Activeness>> Get(Guid id)
		{
			return await Mediator.Send(new ItemActivities.Query() { Id = id });
		}

		[HttpPost]
		public async Task<IActionResult> Create(Activeness activeness)
		{
			Debug.WriteLine(activeness);

			return Ok(await Mediator.Send(new CreateActivities.Command()
			{
				Item = activeness
			}));
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> Edit(Guid id, Activeness activeness)
		{
			activeness.Id = id;
			return Ok(await Mediator.Send(new EditActivities.Command()
			{
				Item = activeness
			}));
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Remove(Guid id)
		{
			return Ok(await Mediator.Send(new RemoveActivities.Command()
			{
				Id = id
			}));
		}
	}
}
