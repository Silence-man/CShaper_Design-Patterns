namespace BuilderSample
{
    class Actor
    {
        private string type; //角色类型
        private string sex; //性别
        private string face; //面容
        private string costume; //服装
        private string hairstyle; //发型

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Face
        {
            get { return face; }
            set { face = value; }
        }

        public string Costume
        {
            get { return costume; }
            set { costume = value; }
        }

        public string Hairstyle
        {
            get { return hairstyle; }
            set { hairstyle = value; }
        }
    }
}
