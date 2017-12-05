namespace BuilderExtend
{
    //角色建造者：抽象建造者
    abstract class ActorBuilder
    {
        protected Actor actor = new Actor();

        public abstract void BuildType();
        public abstract void BuildSex();
        public abstract void BuildFace();
        public abstract void BuildCostume();
        public abstract void BuildHairstyle();

        //钩子方法
        public virtual bool IsBareheaded()
        {
            return false;
        }

        public Actor CreateActor()
        {
            return actor;
        }
    }
}
