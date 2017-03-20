using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using Shared;
using Shared.Delegates;
using Shared.Interfaces;
using AppCollectorAgent.SR_RunningAppsQueryService;

namespace AppCollectorAgent
{
    class Worker
    {
        private Timer timer;
        private StringMessageInformer informer;
        private ISubmitable submit;
        private RunningAppsQueryServiceSoapClient client;
        private List<string> appList;

        internal List<string> AppList
        {
            get { return appList; }
            set { appList = value; }
        }

        /// <summary>
        /// updateInterval in ms!
        /// </summary>
        /// <param name="updateInterval"></param>
        public Worker(int updateInterval, StringMessageInformer informer, ISubmitable submissionType)
        {
            client = new RunningAppsQueryServiceSoapClient();
            this.informer = informer;
            timer = new Timer(updateInterval);
            timer.Elapsed += timer_Elapsed;

            //setup message transmission
            submit = submissionType;
            submit.Start();
        }

        /// <summary>
        /// Timer elapsed => do something
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //Inform Console
            informer("");

            appList = client.QueryApps();
            //Inform Adapter via MSMQ
            string temp = "";

            foreach (var item in appList)
            {
                temp = temp + item + "\n";
            }
            submit.Submit(new CoreMessage() { Source = "AppCollectorAgent", Date = DateTime.Now, Data = temp });

        }

        /// <summary>
        /// Starts the timer
        /// </summary>
        public void StartCollectingAppInfo()
        {
            timer.Start();
        }

        /// <summary>
        /// Stops the Timer
        /// </summary>
        public void StopCollectingAppInfo()
        {
            timer.Stop();
        }
        
    }
}
