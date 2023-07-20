using ET.EventType;

namespace ET
{
    public class InstallComputer_AddComponent : AEvent<EventType.InstallComputer>
    {
        protected override void Run(InstallComputer arg)
        {
            Computer computer = arg.computer;
            computer.AddComponent<PCCaseComponent>();
            computer.AddComponent<MonitorsComponent>();
            computer.AddComponent<KeyBoardComponent>();
            computer.AddComponent<MouseComponent>();
        }
    }
}