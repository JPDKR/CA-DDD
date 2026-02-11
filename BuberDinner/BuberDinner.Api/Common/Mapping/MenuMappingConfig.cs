// <copyright file="MenuMappingConfig.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using BuberDinner.Application.Menus.Commands.CreateMenu;
using BuberDinner.Contracts.Menus;
using BuberDinner.Domain.Menu;
using Mapster;

using MenuSection = BuberDinner.Domain.Menu.Entities.MenuSection;
using MenuItem = BuberDinner.Domain.Menu.Entities.MenuItem;

namespace BuberDinner.Api.Common.Mapping;

public class MenuMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<(CreateMenuRequest request, string hostId), CreateMenuCommand>()
            .Map(dest => dest.Name, src => src.request.Name)
            .Map(dest => dest, src => src.request);

        config.NewConfig<Menu, MenuResponse>()
            .Map(dest => dest.Id, src => src.Id.Value)
            .Map(dest => dest.AverageRating, src => src.AverageRating!.Value)
            .Map(dest => dest.HostId, src => src.HostId.Value)
            .Map(dest => dest.DinnerIds, src => src.DinnerIds.Select(id => id.Value))
            .Map(dest => dest.MenuReviewIds, src => src.MenuReviewIds.Select(menuId => menuId.Value));

        config.NewConfig<MenuSection, MenuSectionResponse>()
            .Map(dest => dest.Id, src => src.Id.Value);

            config.NewConfig<MenuItem, MenuItemResponse>()
            .Map(dest => dest.Id, src => src.Id.Value);
    }
}