using Microsoft.Azure.Mobile.Server;

namespace p8jkbxjr6kservice.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}