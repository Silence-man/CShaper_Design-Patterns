namespace BuilderSample
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

        //工厂方法，返回一个完整的游戏角色对象
        public Actor CreateActor()
        {
            return actor;
        }
    }
}
