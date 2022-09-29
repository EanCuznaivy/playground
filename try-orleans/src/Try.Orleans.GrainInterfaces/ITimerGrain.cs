using Orleans;

namespace Try.Orleans.GrainInterfaces;

public interface ITimerGrain : IGrainWithGuidKey
{
    void StartTimer();
    void StopTimer();
}