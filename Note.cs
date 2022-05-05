using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Note
    {
        public int id { get; set; }

        private string title, describe;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Describe
        {
            get { return describe; }
            set { describe = value; }
        }

        public Note() {}

        public Note(string title, string describe) {
            this.title = title;
            this.describe = describe;
        }
    }
}
