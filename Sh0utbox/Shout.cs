namespace Sh0utbox
{
    class Shout
    {
        public string shoutid;
        public string tagname;
        public string name;
        public string message;
        public string time;
        public string memberid;

        public Shout(string shoutid, string tagname, string name, string message, string time, string memberid)
        {
            this.shoutid = shoutid;
            this.tagname = tagname;
            this.name = name;
            this.message = message;
            this.time = time;
            this.memberid = memberid;
        }
    }
}
