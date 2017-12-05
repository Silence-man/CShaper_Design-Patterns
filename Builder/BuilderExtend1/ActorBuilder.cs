namespace BuilderExtend1
{
    //角色建造者：抽象建造者
    abstract class ActorBuilder
    {
        protected static Actor actor = new Actor();

        public abstract void BuildType();
        public abstract void BuildSex();
        public abstract void BuildFace();
        public abstract void BuildCostume();
        public abstract void BuildHairstyle();

        public static Actor Construct(ActorBuilder ab)
        {
            ab.BuildType();
            ab.BuildSex();
            ab.BuildFace();
            ab.BuildCostume();
            ab.BuildHairstyle();
            return actor;
        }

        public  Actor Construct()
        {
            this.BuildType();
            this.BuildSex();
            this.BuildFace();
            this.BuildCostume();
            this.BuildHairstyle();
            return actor;
        }
    }
}
