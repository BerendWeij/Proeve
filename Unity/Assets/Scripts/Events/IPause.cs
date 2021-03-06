﻿using UnityEngine;
using System.Collections;
namespace Events
{
    public class IPause : IEvent
    {
        /// <summary>
        /// Pause state of the game
        /// </summary>
        public bool State;

        /// <summary>
        /// Event Class that sends pause state changes to all listeners
        /// </summary>
        /// <param name="State"></param>
        public IPause(bool State)
        {
            this.State = State;
        }
    }
}