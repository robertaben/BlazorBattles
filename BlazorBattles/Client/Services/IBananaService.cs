using System;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
    public interface IBananaService
    {
        int Bananas { get; set; }
        void EatBananas(int amount);
        Task AddBananas(int amount);
        Task GetBananas();

        event Action OnChange;
    }
}
