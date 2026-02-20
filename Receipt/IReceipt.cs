using System;
using System.Collections.Generic;
using System.Text;

namespace Kassasystem1.Receipt
{
    public interface IReceipt
    {
        string Extension { get; }
        void Write(string filename);
    }
}
