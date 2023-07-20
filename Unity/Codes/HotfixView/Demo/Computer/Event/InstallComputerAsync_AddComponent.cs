using ET.EventType;

namespace ET
{
    public class InstallComputerAsync_AddComponent : AEventAsync<EventType.InstallComputerAsync>
    {
        protected async override ETTask Run(InstallComputerAsync arg)
        {
            Computer computer = arg.computer;
            computer.AddComponent<PCCaseComponent>();
            computer.AddComponent<MonitorsComponent>();
            computer.AddComponent<KeyBoardComponent>();
            computer.AddComponent<MouseComponent>();

            await TimerComponent.Instance.WaitAsync(3000);
            
            computer.Start();
        }
    }
}