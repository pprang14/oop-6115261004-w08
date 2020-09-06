using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261004_w08
{
    class Video
    {
        private string videocode;
        private string videoname;
        private string videotype;
        private int videoview;
        private Channel videoChanel;

        public string VideoCode
        {
            get { return this.videocode; }
            set { this.videocode = value; }
        }
        public string VideoName
        {
            get { return this.videoname; }
            set { this.videoname = value; }
        }
        public string VideoType
        {
            get { return this.videotype; }
            set { this.videotype = value; }
        }
        public int  VideoView
        {
            get { return this.videoview; }
            set { this.videoview = value; }
        }
        public Channel VideoChanel
        {
            get { return this.videoChanel; }
            set { this.videoChanel = value; }
        }
        public Video() { }
        public Video(string vc, string vn, string vt, int vv, Channel cv1)
        {
            this.videocode = vc;
            this.videoname = vn;
            this.videotype = vt;
            this.videoview = vv;
            this.videoChanel = cv1;
        }
        public override string ToString()
        {
            return this.VideoCode + " VideoName :" + this.VideoName + "Videotype : " + this.VideoType + " view: " + this.videoview
                + " Channelname : " + this.videoChanel.ChannelName;
        }
    }
    } 