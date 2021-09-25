using System;
using RocketProy.Shared.Entity;
using System.Collections.Generic;

namespace RocketProy.Client.Services
{
    public class Service : IService
    {
        public List<Rocket> GetRocket(){
            return new List<Rocket>(){
                new Rocket()
            {
                RocketName = "Ariane 5", RocketDescription = "El cohete con más lanzamientos exitosos de la ESA",
                SpaceAgency = "ESA", RocketImage = "/Images/Cohete-Ariane5.jpg",
                PublicationDate = new DateTime(2021, 06, 21)},
            new Rocket()
            {
                RocketName = "Delta", RocketDescription = "La familia de cohetes Delta lleva en servicio desde agosto de 1960",
                SpaceAgency = "NASA", RocketImage = "/Images/Cohete-Delta.jpg",
                PublicationDate = new DateTime(2021, 08, 19)},
            new Rocket()
            {
                RocketName = "Proton M", RocketDescription = "Potente lanzador sin tripulación soviético heredado por Rusia",
                SpaceAgency = "Roscosmos", RocketImage = "/Images/Cohete-Proton.jpg",
                PublicationDate = new DateTime(2021, 07, 12)},
            new Rocket()
            {
                RocketName = "OneSpace", RocketDescription = "Primer cohete lanzado de empresas privadas Chinas",
                SpaceAgency = "OneSpace", RocketImage = "/Images/Cohete-OneSpace.webp",
                PublicationDate = new DateTime(2021, 09, 17)},
            new Rocket()
            {
                RocketName = "Safir", RocketDescription = "Parte del desarrollo espacial de Irán, no tripulado.",
                SpaceAgency = "Iranian Space Agency (ISA)", RocketImage = "/Images/Cohete-Safir.jpg",
                PublicationDate = new DateTime(2021, 08, 24)},
            new Rocket()
            {
                RocketName = "Falcon 9", RocketDescription = "Vehículo de lanzamiento parcialmente reutilizable de dos etapas.",
                SpaceAgency = "SpaceX - NASA", RocketImage = "/Images/Cohete-Falcon9.jpg",
                PublicationDate = new DateTime(2021, 07, 25)}

            };
        }
    }
}