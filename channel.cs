using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261004_w08
{

    class Channel
    {
        private string channelcode;
        private string channelname;
        private string channeltype;
        public string ChannelCode
        {
            get { return channelcode; }
            set { this.channelcode = value; }
        }
        public string ChannelName
        {
            get { return channelname; }
            set { this.channelname = value; }
        }
        public string ChannelType
        {
            get { return channeltype; }
            set { this.channeltype = value; }
        }


        public Channel() { }
        public Channel(string cc, string cn, string ct)
        {
            this.channelcode = cc;
            this.channelname = cn;
            this.channeltype = ct;
        }

        public override string ToString()
        {
            return this.channelcode + " NAME : " + this.channelname + " TYPE :" + this.channeltype;
        }
    }
}