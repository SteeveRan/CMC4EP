using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Resources;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;

namespace Ctrl
{
    public enum pony_type { earthpony, pegasus, regular, unihorn, zebra, special };
    public enum user_type { player, admin, moder, helper, coder, bilder};


    public class MyFriend : Brony
    {
        public MyFriend()
        {
            this.Name = "Derpy";
            this.AboutBrony = "Derp!!!";
            this.pType = pony_type.pegasus;
            this.uType = user_type.player;
            this.status = "Muffins!";
            this.isActive = false;
            this.statusColor = define_color(this.pType, this.isActive);
            this.Avatar = new BitmapImage(new Uri("/CMC4EP;component/Media/derp.jpg", UriKind.Relative));
        }

        public MyFriend(string _name, string _about, pony_type _ptype, user_type _utype, bool _isActive, BitmapImage _avatar)
        {
            this.Name = _name;
            this.AboutBrony = _about;
            this.pType = _ptype;
            this.uType = _utype;
            this.status = "";
            this.isActive = _isActive;
            this.statusColor = define_color(this.pType, this.isActive);
            this.Avatar = _avatar;
        }
    }

    public class MyFriends : ObservableCollection<MyFriend>
    {
        public MyFriends()
        {
            Add( new MyFriend());
        }
    }

    public class Brony
    {
        public string Name { get; set; }
        public string AboutBrony { get; set; }
        public pony_type pType { get; set; }
        public user_type uType { get; set; }
        public string status { get; set; }
        public bool isActive { get; set; }
        public BitmapImage Avatar { get; set; }
        public string statusColor { get; set; }

        protected Dictionary<pony_type, string> online =
            new Dictionary<pony_type, string>
            {
                {pony_type.earthpony, "#FF82C341"},
                {pony_type.pegasus, "#FF83D2E0"},
                {pony_type.regular, "#FFFFFFFF"},
                {pony_type.unihorn, "#FFF15758"},
                {pony_type.zebra, "#FF5760AC"},
                {pony_type.special, "#FFFF0DFF"}
            };
        protected Dictionary<pony_type, string> offline =
            new Dictionary<pony_type, string>
            {
                {pony_type.earthpony, "#B382C341"},
                {pony_type.pegasus, "#B383D2E0"},
                {pony_type.regular, "#B3FFFFFF"},
                {pony_type.unihorn, "#B3F15758"},
                {pony_type.zebra, "#B35760AC"},
                {pony_type.special, "#FF690569"}
            };

        public Brony()
        {
            this.Name = "Derpy";
            this.AboutBrony = "Derp!!!";
            this.pType = pony_type.pegasus;
            this.uType = user_type.player;
            this.status = "Muffins!";
            this.isActive = false;
            this.statusColor = define_color(this.pType, this.isActive);
            this.Avatar = new BitmapImage(new Uri("/CMC4EP;component/Media/derp.jpg", UriKind.Relative));
        }

        public Brony(string _name, string _about, pony_type _ptype, user_type _utype, string _status, bool _isActive, BitmapImage _avatar)
        {
            this.Name = _name;
            this.AboutBrony = _about;
            this.pType = _ptype;
            this.uType = _utype;
            this.status = _status;
            this.isActive = _isActive;
            this.statusColor = define_color(this.pType, this.isActive);
            this.Avatar = new BitmapImage();
            this.Avatar = _avatar;
        }

        public Brony(string _name, string _about, pony_type _ptype, user_type _utype, string _status, bool _isActive, Uri _URL_avatar)
        {
            this.Name = _name;
            this.AboutBrony = _about;
            this.pType = _ptype;
            this.uType = _utype;
            this.status = _status;
            this.isActive = _isActive;
            this.statusColor = define_color(this.pType, this.isActive);
            this.Avatar = new BitmapImage(_URL_avatar);
        }

        public Brony(string _name, string _about, pony_type _ptype, user_type _utype, string _status, bool _isActive, string _URL_avatar)
        {
            this.Name = _name;
            this.AboutBrony = _about;
            this.pType = _ptype;
            this.uType = _utype;
            this.status = _status;
            this.isActive = _isActive;
            this.statusColor = define_color(this.pType, this.isActive);
            this.Avatar = new BitmapImage(new Uri(_URL_avatar, UriKind.Relative));
        }

        public Brony(string _name, string _about, pony_type _ptype, user_type _utype, bool _isActive, BitmapImage _avatar)
        {
            this.Name = _name;
            this.AboutBrony = _about;
            this.pType = _ptype;
            this.uType = _utype;
            this.status = "";
            this.isActive = _isActive;
            this.statusColor = define_color(this.pType, this.isActive);
            this.Avatar = _avatar;
        }
        public Brony(string _name, pony_type _ptype, bool _isActive)
        {
            this.Name = _name;
            this.AboutBrony = "";
            this.pType = _ptype;
            this.uType = user_type.player;
            this.status = "";
            this.isActive = _isActive;
            this.statusColor = define_color(this.pType, this.isActive);
            this.Avatar = new BitmapImage(new Uri("/CMC4EP;component/Media/derp.jpg", UriKind.Relative));
        }

        protected string define_color(pony_type _t, bool isA)
        {
            if (isActive) return online[_t];
            else return offline[_t];
        }

    }

    public class Bronys : ObservableCollection<Brony>
    {
        public Bronys()
        {

        }
    }
}
