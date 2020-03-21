using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace vdivsvirus.Services
{

    //++++++++++++++++++++++++++++++++++++++++++++++
    //Background Service Pattern in ASP.net core
    // https://docs.microsoft.com/de-de/dotnet/architecture/microservices/multi-container-microservice-net-applications/background-tasks-with-ihostedservice
    //++++++++++++++++++++++++++++++++++++++++++++++




    // Copyright (c) .NET Foundation. Licensed under the Apache License, Version 2.0.
    /// <summary>
    /// Base class for implementing a long running <see cref="IHostedService"/>.
    /// </summary>
    public abstract class BackgroundService : IHostedService, IDisposable
    {
        private Task _executingTask;
        private readonly CancellationTokenSource _stoppingCts =
                                                       new CancellationTokenSource();

        protected abstract Task ExecuteAsync(CancellationToken stoppingToken);

        public virtual Task StartAsync(CancellationToken cancellationToken)
        {
            // Store the task we're executing
            _executingTask = ExecuteAsync(_stoppingCts.Token);

            // If the task is completed then return it,
            // this will bubble cancellation and failure to the caller
            if (_executingTask.IsCompleted)
            {
                return _executingTask;
            }

            // Otherwise it's running
            return Task.CompletedTask;
        }

        public virtual async Task StopAsync(CancellationToken cancellationToken)
        {
            // Stop called without start
            if (_executingTask == null)
            {
                return;
            }

            try
            {
                // Signal cancellation to the executing method
                _stoppingCts.Cancel();
            }
            finally
            {
                // Wait until the task completes or the stop token triggers
                await Task.WhenAny(_executingTask, Task.Delay(Timeout.Infinite,
                                                              cancellationToken));
            }

        }

        public virtual void Dispose()
        {
            _stoppingCts.Cancel();
        }
    }



    // Copyright (c) .NET Foundation. Licensed under the Apache License, Version 2.0.
    /// <summary>
    /// Base class for implementing a periodic running <see cref="IHostedService"/>.
    /// </summary>
    public abstract class CyclicBackgroundService : BackgroundService
    {
        /// <summary>
        /// Waiting Time if nothing is to do (Check == false)
        /// default 100ms
        /// </summary>
        private int msDelayBetweenCycles = 100;

        /// <summary>
        /// Constructor
        /// </summary>
        public CyclicBackgroundService()
        {

        }

        /// <summary>
        /// Background Execution Thread 
        /// (endless loop pattern - with delay)
        /// </summary>
        /// <param name="stoppingToken">Cancelation Token</param>
        /// <returns>void</returns>
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (Check())
                {
                    Execute();
                }
                else
                {
                    await Task.Delay(msDelayBetweenCycles, stoppingToken);
                }
            }
        }

        /// <summary>
        /// Execution of the available Data
        /// </summary>
        internal abstract void Execute();

        /// <summary>
        /// Check if data for execution is available
        /// </summary>
        /// <returns>1: do something, 0: nothing to do</returns>
        internal abstract bool Check();
    }
}
