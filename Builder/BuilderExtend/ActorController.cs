using System;

namespace BuilderExtend
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

            //通过钩子方法来控制产品的构建
            if (!ab.IsBareheaded())
            {
                ab.BuildHairstyle();
            }
            actor = ab.CreateActor();
            return actor;
        }
    }
}
