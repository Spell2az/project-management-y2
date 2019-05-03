using System;
using System.Collections.Generic;
using ApplicationCore.Domain;

namespace ApplicationCore.Services
{
    public class LocationService: ILocationService
    {
        private readonly IUnitOfWork unitOfWork;
        public LocationService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork ?? throw new ArgumentNullException("unitOfWork");
        }
        public IEnumerable<WarehouseLocation> GetWarehouseLocations()
        {
            return unitOfWork.WarehouseLocations.GetAll();
        }
    }
}