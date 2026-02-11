// <copyright file="CreateMenuRequest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BuberDinner.Contracts.Menus;

public record CreateMenuRequest(
    string Name,
    string Description,
    List<MenuSection> Sections);
public record MenuSection(
    string Name,
    string Description,
    List<MenuItem> Items);
public record MenuItem(
    string Name,
    string Description);