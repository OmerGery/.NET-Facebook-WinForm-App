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
        
    }
}
