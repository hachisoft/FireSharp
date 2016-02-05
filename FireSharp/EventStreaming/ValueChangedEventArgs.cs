using System;

namespace FireSharp.EventStreaming
{
    public class ValueChangedEventArgs : EventArgs
    {
        public ValueChangedEventArgs(string path, object data, object oldData)
        {
            Path = path;
            Data = data;
            OldData = oldData;
        }

        public string Path { get; private set; }
        public object Data { get; private set; }
        public object OldData { get; private set; }
    }
}