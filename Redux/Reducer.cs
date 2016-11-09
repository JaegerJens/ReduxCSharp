namespace Redux
{
    public class Reducer
    {
        public State Reduce()
        {
            return new State(0);
        }

        public State Reduce(State current, Action action)
        {
            switch (action.Type)
            {
                case Action.ActionType.Increment:
                    return new State(current.Counter + 1);
                case Action.ActionType.Decrement:
                    return new State(current.Counter - 1);
            }
            return current;
        }
    }
}