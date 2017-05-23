﻿using MyPoetry.Model;
using System;

/// <summary>
/// Multithreaded Singleton to store date of the logged User.
/// </summary>
namespace MyPoetry.Utilities
{
    public sealed class UserHandler
    {
        private static volatile UserHandler instance;
        private static object syncRoot = new Object();
        private User user;

        private UserHandler() { }

        /// <summary>
        /// Gets the Singleton instance.
        /// If the instance does not exist, it creates a new one.
        /// </summary>
        public static UserHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new UserHandler();
                    }
                }

                return instance;
            }
        }

        public void SetUser(User user)
        {
            this.user = user;
        }

        public User GetUser()
        {
            return this.user;
        }
    }
}