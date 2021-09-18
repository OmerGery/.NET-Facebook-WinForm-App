using System;

namespace Logic
{
    public class ExitNotifier
    {
        public event Action ExitClicked;

        public void NotifyAll()
        {
            ExitClicked?.Invoke();
        }

        public void Attach(Action i_ActionToAdd)
        {
            ExitClicked += i_ActionToAdd;
        }
        public void Detach(Action i_ActionToRemove)
        {
            ExitClicked -= i_ActionToRemove;
        }


    }
}
