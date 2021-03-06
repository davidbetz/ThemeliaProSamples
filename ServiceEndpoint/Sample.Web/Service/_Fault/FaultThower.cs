﻿using System;
using System.ServiceModel;
//+
namespace Sample.Service
{
    public static class FaultThrower
    {
        //- ~Throw -//
        public static void Throw<T>(T exception) where T : Exception
        {
            throw new FaultException<T>(exception, exception.Message);
        }
    }
}