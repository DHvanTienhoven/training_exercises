using System;
using System.Collections.Generic;

namespace JsonElementExercise
{
    class JsonElement
    {
        public event EventHandler<ChildChangedEventArgs> ChildChanged;
        private readonly List<JsonElement> children = new List<JsonElement>();

        // TODO: Implement the indexer property

        // TODO: Implement the count property with a body expression
        public int Count

        public void AddChild(JsonElement child)
        {
            children.Add(child);

            // Here is an example on how to send an event, just call this method with the correct parameters.
            OnChildChanged(child, children.Count-1);
        }

        private void OnChildChanged(JsonElement child, int index)
        {
            ChildChanged?.Invoke(this, new ChildChangedEventArgs(child, index));
        }
    }
}
