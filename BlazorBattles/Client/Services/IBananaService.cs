using System;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
    public interface IBananaService
    {
        int Bananas { get; set; }
        void EatBananas(int amount);
        void AddBananas(int amount);
        Task GetBananas();

        event Action OnChange;
    }
}
