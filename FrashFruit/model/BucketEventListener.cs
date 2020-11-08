using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrashFruit.model
{
    interface BucketEventListener
    {
        void onSuceed(string message);
        void onFailed(string message);
    }
}
