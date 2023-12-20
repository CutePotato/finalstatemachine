namespace FSM
{
    public interface IBaseState
    {
        void Enter();
        void Update();
        void FixedUpdate();
        void Exit();
    }
}