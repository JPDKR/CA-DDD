// <copyright file="MenusController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using BuberDinner.Application.Menus.Commands.CreateMenu;
using BuberDinner.Contracts.Menus;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[Route("hosts/{hostId}/menus")]
public class MenusController(IMapper mapper, ISender mediator) : ApiController
{
    private readonly IMapper _mapper = mapper;
    private readonly ISender _mediator = mediator;
    [HttpPost]
    public async Task<IActionResult> CreateMenu(CreateMenuRequest request, string hostId)
    {
        var command = _mapper.Map<CreateMenuCommand>((request, hostId));

        var createMenuResult =await _mediator.Send(command, default);
        return createMenuResult.Match(
            menu => Ok(_mapper.Map<MenuResponse>(menu)),
            errors => Problem(errors));
    }
}