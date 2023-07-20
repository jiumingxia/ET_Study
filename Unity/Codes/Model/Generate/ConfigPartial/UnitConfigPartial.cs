using System.Collections.Generic;
using System.Numerics;

namespace ET
{
    public partial class UnitConfig
    {
        public Vector3 TestVector3;
    }

    public class TestVector3
    {
        public Vector3 TestValue;
    }
    
    public partial class UnitConfigCategory
    {
        public List<TestVector3> TestVector3List = new List<TestVector3>();
        
        public override void AfterEndInit()
        {
            base.AfterEndInit();

            foreach (var config in this.dict.Values)
            {
                config.TestVector3 = new Vector3(config.Position, config.Height, config.Weight);
                TestVector3List.Add(new TestVector3(){ TestValue = config.TestVector3});
            }
        }

        public UnitConfig GetUnitConfigByHeight(int height)
        {
            UnitConfig unitConfig = null;
            foreach (var info in this.dict.Values)
            {
                if (info.Height == height)
                {
                    unitConfig = info;
                    break;
                }
            }
            return unitConfig;
        }
    }
}