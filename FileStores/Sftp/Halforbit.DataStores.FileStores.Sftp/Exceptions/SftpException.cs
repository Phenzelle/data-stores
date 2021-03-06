﻿using System;

namespace Halforbit.DataStores.FileStores.Sftp.Exceptions
{
    public class SftpException : Exception
    {
        public SftpException(
            string message, 
            Exception innerException, 
            bool isRetryable = true) : 
                base(message, innerException) 
        {
            IsRetryable = isRetryable;
        }

        public bool IsRetryable { get; }
    }
}
