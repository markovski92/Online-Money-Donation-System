namespace OnlineMoneyDonationSystem.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using OnlineMoneyDonationSystem.Data.Common.Repositories;
    using OnlineMoneyDonationSystem.Data.Models;
    using OnlineMoneyDonationSystem.Services.Mapping;

    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
        {
            return this.settingsRepository.AllAsNoTracking().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }
    }
}
