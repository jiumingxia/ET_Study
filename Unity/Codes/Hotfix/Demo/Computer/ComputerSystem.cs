namespace ET
{
    public class ComputerAwakeSystem: AwakeSystem<Computer>
    {
        public override void Awake(Computer self)
        {
            Log.Debug("Computer Awake..");
        }
    }
    
    public class ComputerUpdateSystem: UpdateSystem<Computer>
    {
        public override void Update(Computer self)
        {
            Log.Debug("Computer Update..");
        }
    }
    
    public class ComputerDestroySystem: DestroySystem<Computer>
    {
        public override void Destroy(Computer self)
        {
            Log.Debug("Computer Destroy..");
        }
    }
    
    public static class ComputerSystem
    {
        public static void Start(this Computer self)
        {
            Log.Debug("Start Computer....");
            self.GetComponent<PCCaseComponent>().StartPower();
            self.GetComponent<MonitorsComponent>().Display();
        }
    }
}