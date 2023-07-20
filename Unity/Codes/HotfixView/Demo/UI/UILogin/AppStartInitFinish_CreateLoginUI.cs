

namespace ET
{
	public class AppStartInitFinish_CreateLoginUI: AEvent<EventType.AppStartInitFinish>
	{
		protected override void Run(EventType.AppStartInitFinish args)
		{
			UIHelper.Create(args.ZoneScene, UIType.UILogin, UILayer.Mid).Coroutine();

			Computer computer = args.ZoneScene.AddChild<Computer>();


			// Test(args.ZoneScene).Coroutine();
			
			// Game.EventSystem.Publish(new EventType.InstallComputer() { computer = computer });
			// computer.Start();
			
			Game.EventSystem.PublishAsync(new EventType.InstallComputerAsync() { computer = computer }).Coroutine();
		}

		public async ETTask Test(Scene zoneScene)
		{
			Computer computer = zoneScene.AddChild<Computer>();
			computer.AddComponent<PCCaseComponent>();
			computer.AddComponent<MonitorsComponent>();
			computer.AddComponent<KeyBoardComponent>();
			computer.AddComponent<MouseComponent>();
			
			computer.Start();

			await TimerComponent.Instance.WaitAsync(3000);
			
			computer.Dispose();
		}
	}
}
