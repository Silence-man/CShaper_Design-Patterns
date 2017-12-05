namespace BuilderExtend
{
    class DevilBuilder : ActorBuilder
    {
        public override void BuildType()
        {
            actor.Type = "恶魔";
        }

        public override void BuildSex()
        {
            actor.Sex = "妖";
        }

        public override void BuildFace()
        {
            actor.Face = "丑陋";
        }

        public override void BuildCostume()
        {
            actor.Costume = "黑衣";
        }

        public override void BuildHairstyle()
        {
            actor.Hairstyle = "光头";
        }

        //覆盖钩子方法
        public override bool IsBareheaded()
        {
            return true;
        }	
    }
}
