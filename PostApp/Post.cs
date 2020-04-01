using System;
using System.Collections.Generic;
using System.Text;

namespace PostApp {
    class Post {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDateTime { get; } = DateTime.UtcNow;
        private int _voteValue;

        public int displayVotes() {
            return _voteValue;
        }

        public void UpVote() {
            _voteValue++;
        }

        public void DownVote() {
            _voteValue--;
        }
    }
}
