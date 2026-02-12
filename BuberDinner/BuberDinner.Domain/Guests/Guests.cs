using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Guests.ValueObjects;

namespace BuberDinner.Domain.Guests;

public sealed class Guest(GuestId id) : AggregateRoot<GuestId, Guid>(id)
{
}