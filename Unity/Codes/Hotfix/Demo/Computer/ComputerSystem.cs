namespace ET
{
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