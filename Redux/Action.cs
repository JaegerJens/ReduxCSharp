namespace Redux
{
    public class Action
    {
        public Action(ActionType action)
        {
            Type = action;
        }

        public enum ActionType
        {
            Increment,
            Decrement
        }

        public ActionType Type { get; set; }
    }
}