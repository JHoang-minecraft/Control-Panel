namespace Control_Panel
{
    internal class SQLiteDataAdapter
    {
        private SQLiteCommand cmd;

        public SQLiteDataAdapter(SQLiteCommand cmd)
        {
            this.cmd = cmd;
        }
    }
}
