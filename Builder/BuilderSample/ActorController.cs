namespace BuilderSample
{
    class ActorController
    {
        //逐步构建复杂产品对象
        public Actor Construct(ActorBuilder ab)
        {
            Actor actor;
            ab.BuildType();
            ab.BuildSex();
            ab.BuildFace();
            ab.BuildCostume();
            ab.BuildHairstyle();
            actor = ab.CreateActor();
            return actor;
        }
    }
}
