// <copyright file="CreateMenuCommandHandler.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using BuberDinner.Domain.Hosts.ValueObjects;
using BuberDinner.Domain.Menu;
using BuberDinner.Domain.Menu.Entities;
using ErrorOr;

using MediatR;

namespace BuberDinner.Application.Menus.Commands.CreateMenu;

public class CreateMenuCommandHandler(IMenuRepository menuRepository) : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
{
    private readonly IMenuRepository _menuRepository = menuRepository;
    public async Task<ErrorOr<Menu>> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var menu = Menu.Create(
            name: request.Name,
            description: request.Description,
            hostId: HostId.Create(request.HostId),
            sections: request.Sections.ConvertAll(section => MenuSection.Create(
                name: section.Name,
                description: section.Description,
                section.Items.ConvertAll(item => MenuItem.Create(
                    name: item.Name,
                    description: item.Description)))));

        _menuRepository.Add(menu);

        return default!;
    }
}