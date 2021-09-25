using RocketProy.Shared.Entity;
using System.Collections.Generic;

namespace RocketProy.Client.Services
{
    public interface IService
    {
        List<Rocket> GetRocket();
    }
}