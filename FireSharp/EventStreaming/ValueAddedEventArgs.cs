using System;

namespace FireSharp.EventStreaming
{
    public class ValueAddedEventArgs : EventArgs
    {
        public ValueAddedEventArgs(string path, object data)
        {
            Path = path;
            Data = data;
        }

        public string Path { get; private set; }
        public object Data { get; private set; }
    }
}