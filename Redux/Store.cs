namespace Redux
{
    public class Store
    {
        private State _state;
        private readonly Reducer _reducer;

        public Store(Reducer reducer)
        {
            _reducer = reducer;
            _state = _reducer.Reduce();
        }

        public void Dispatch(Action action)
        {
            _state = _reducer.Reduce(_state, action);
        }

        public State GetState()
        {
            return _state;
        }
    }
}
