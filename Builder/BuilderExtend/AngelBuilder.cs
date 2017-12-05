namespace BuilderExtend
{
    class AngelBuilder : ActorBuilder
    {
        public override void BuildType()
        {
            actor.Type = "天使";
        }

        public override void BuildSex()
        {
            actor.Sex = "女";
        }

        public override void BuildFace()
        {
            actor.Face = "漂亮";
        }

        public override void BuildCostume()
        {
            actor.Costume = "白裙";
        }

        public override void BuildHairstyle()
        {
            actor.Hairstyle = "披肩长发";
        }	
    }
}
