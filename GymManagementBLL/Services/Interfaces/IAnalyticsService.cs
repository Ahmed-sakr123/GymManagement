using GymManagementBLL.Common;
using GymManagementBLL.ViewModels.AnalyticsViewModels;
using GymManagementBLL.ViewModels.BookingViewModels;
using GymManagementBLL.ViewModels.MembershipViewModels;
using GymManagementBLL.ViewModels.SessionViewModels;

namespace GymManagementBLL.Services.Interfaces
{
    public interface IAnalyticsService
    {
        Task<AnalyticsViewModel> GetAnalyticsDataAsync(CancellationToken ct = default);
    }
}
