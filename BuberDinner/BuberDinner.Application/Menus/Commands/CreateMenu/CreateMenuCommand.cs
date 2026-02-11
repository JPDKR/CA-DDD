// <copyright file="CreateMenuCommand.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using BuberDinner.Domain.Menu;

using ErrorOr;

using MediatR;

namespace BuberDinner.Application.Menus.Commands.CreateMenu;

public record CreateMenuCommand(
    string HostId,
    string Name,
    string Description,
    List<MenuSectionCommand> Sections) : IRequest<ErrorOr<Menu>>;
public record MenuSectionCommand(
    string Name,
    string Description,
    List<MenuItemCommand> Items);
public record MenuItemCommand(
    string Name,
    string Description);