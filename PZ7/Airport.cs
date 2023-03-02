//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PZ7
//{
//    public class Airport : IObservable
//    {


//        private List<IObserver> baggage;
//        public Airport()
//        {
//            baggage = new List<IObserver>();
//        }
//        public void AddObserver(IObserver admin)
//        {
//            administrators.Add(admin);
//        }
//        public void RemoveObserver(IObserver admin)
//        {
//            administrators.Remove(admin);
//        }
//        private int _countError = 0;
//        public void NotifyObservers()
//        {
//            _countError++;
//            foreach (IObserver admin in administrators)
//            {
//                admin.Update("Произошел сбой: " + _countError);
//            }
//        }

//        public void DoSite()
//        {
//            Random rand = new Random();
//            if (rand.NextDouble() > reliability)
//            {
//                NotifyObservers();
//            }
//        }


//    }
//}
