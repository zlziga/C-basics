using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch {
    class Stopwatch {
        private DateTime _start;
        private DateTime _stop;
        private bool isRunning = false;


        public void Start() {
            if (!isRunning) {
                isRunning = true;
                _start = DateTime.UtcNow;
            }
        }

        public TimeSpan Stop() {
            if (isRunning) {
                isRunning = false;
                _stop = DateTime.UtcNow;
            }
            return _stop - _start;
        }
    }
}