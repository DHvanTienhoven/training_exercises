using System;

namespace JsonElementExercise
{
    class ChildChangedEventArgs : EventArgs
    {
        public ChildChangedEventArgs(JsonElement child, int index)
        {
            Child = child;
            Index = index;
        }

        public JsonElement Child
        {
            get;
            private set;
        }

        public int Index
        {
            get;
            private set;
        }
    }
}
