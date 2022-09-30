using Orleans;

namespace Try.Orleans.GrainInterfaces;

public interface IReminderGrain : IGrainWithStringKey, IRemindable
{
    Task SendMessage();
    Task StopMessage();
}