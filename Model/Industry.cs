namespace SqliteEfTest.Model
{
    internal class Industry
    {
        public int id { get; set; }

        public bool lastLevel { get; set; }

        public virtual Industry parent { get; set; }

        public string code { get; set; }

        public string farsiName { get; set; }

        public bool systemic { get; set; }

        public string comments { get; set; }

        public short attachmentCount { get; set; }

        public int createTime { get; set; }

        public int updateTime { get; set; }
    }
}