﻿namespace PTW_API.Contracts
{
    public interface ICorrelationIdGenerator
    {
        string Get();

        void Set(string correlationId);

    }
}